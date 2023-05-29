using prjMidtermTopic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ISpan147.Estore.SqlDataLayer.Services;
using ISpan147.Estore.SqlDataLayer.Dtos;
using prjMidtermTopic.ViewModels;

namespace prjMidtermTopic.Form_Order
{
	public partial class form_Orders : Form
	{

		private List<OrderGridDto> _data;
		private int _row = -1;

		private int _sortedIndex = 0;
		private readonly Dictionary<string, Func<OrderGridDto, OrderGridDto, int>> _sortMap;
		private readonly string[] _orderByColumns = { "OrderID", "MemberID", "MemberName"
				, "PurchaseTime", "PaymentMethod", "PaymentAmount" };
		private readonly string[] _orderByColumnName = { "訂單編號", "顧客ID", "顧客姓名"
				, "購買時間", "付款方式", "實付金額" };

		public form_Orders()
		{
			InitializeComponent();

			_sortMap = new Dictionary<string, Func<OrderGridDto, OrderGridDto, int>>
			{
				{ "OrderID", (prev, next) => prev.OrderID.CompareTo(next.OrderID) },
				{ "MemberID", (prev, next) => prev.MemberID.CompareTo(next.MemberID) },
				{ "MemberName", (prev, next) => prev.MemberName.CompareTo(next.MemberName) },
				{ "PaymentMethod", (prev, next) => prev.PaymentMethod.CompareTo(next.PaymentMethod) },
				{ "Payed", (prev, next) => prev.Payed.CompareTo(next.Payed) },
				{ "PurchaseTime", (prev, next) => prev.PurchaseTime.GetValueOrDefault().CompareTo(next.PurchaseTime.GetValueOrDefault()) },
				{ "PaymentAmount", (prev, next) => prev.PaymentAmount.GetValueOrDefault().CompareTo(next.PaymentAmount.GetValueOrDefault()) }
			};

			comboBox_PaymentMethod.Items.AddRange(Orders.paymentOptions);
			comboBox_SortBy.Items.AddRange(_orderByColumnName);
		}

		//load
		private void form_MerchandiseOrder_Load(object sender, EventArgs e)
		{
			Display();
			DisplayGrid.Handler += AutoDisplay;
		}

		//closed
		private void form_MerchandiseOrder_FormClosed(object sender, FormClosedEventArgs e)
		{
			DisplayGrid.Handler -= AutoDisplay;
		}

		//select change
		private void dataGridView_Main_SelectionChanged(object sender, EventArgs e)
		{
			_row = dataGridView_Main.CurrentCell.RowIndex;
		}

		//buttons
		private void btn_Search_Click(object sender, EventArgs e)
		{
			Display();
		}
		private void btn_ClearSearch_Click(object sender, EventArgs e)
		{
			ClearSearchConditions();
		}
		private void btn_Edit_Click(object sender, EventArgs e)
		{
			if (_row < 0) return;
			new form_OrdersEdit(_data[_row]).ShowDialog();
		}
		private void btn_Add_Click(object sender, EventArgs e)
		{
			new form_OrdersAdd().ShowDialog();
		}

		//double click
		private void dataGridView_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				OrderByHeader(e.ColumnIndex);
				return;
			}
			var frm = new form_OrderList(_data[_row].OrderID);
			frm.Owner = this;
			frm.ShowDialog();
		}


		//methods
		private void Display()
		{
			try
			{
				var sDto = GetSearchDto();

				var gridDtoList = new OrderService().Search(sDto);

				_data = gridDtoList.OrderBy(o => o.OrderID).ToList();

				dataGridView_Main.DataSource = _data.Select(dto => dto.ToVM()).ToArray();
			}
			catch (Exception ex)
			{
				MessageBox.Show("資料查詢失敗，可能原因：" + ex.Message);
			}

		}

		private OrderSearchDto GetSearchDto()
		{
			var sDto = new OrderSearchDto();

			#region --條件判別--

			if (int.TryParse(txt_OrderID.Text.Trim(), out int _orderID))
			{
				sDto.OrderID = _orderID;
			}
			if (int.TryParse(txt_MemberID.Text.Trim(), out int _memberID))
			{
				sDto.MemberID = _memberID;
			}
			if (txt_MemberName.Text.Trim().Length > 0)
			{
				sDto.MemberName = txt_MemberName.Text.Trim();
			}
			if (comboBox_PurchaseTime.SelectedIndex != -1)
			{
				switch (comboBox_PurchaseTime.SelectedIndex)
				{
					case 0:
						sDto.PurchaseTime = DateTime.Now.AddDays(-7);
						break;
					case 1:
						sDto.PurchaseTime = DateTime.Now.AddMonths(-1);
						break;
					case 2:
						sDto.PurchaseTime = DateTime.Now.AddMonths(-3);
						break;
					case 3:
						sDto.PurchaseTime = DateTime.Now.AddYears(-1);
						break;
				}
			}
			if (comboBox_PaymentMethod.SelectedIndex != -1)
			{
				sDto.PaymentMethod = comboBox_PaymentMethod.SelectedIndex;
			}
			if (comboBox_Payed.SelectedIndex != -1)
			{
				if (comboBox_Payed.SelectedIndex == 0) sDto.Payed = true;
				if (comboBox_Payed.SelectedIndex == 1) sDto.Payed = false;
			}
			if (int.TryParse(txt_MinPaymentAmount.Text.Trim(), out int minAmount))
			{
				sDto.MinPaymentAmount = minAmount;
			}
			if (int.TryParse(txt_MaxPaymentAmount.Text.Trim(), out int maxAmount))
			{
				sDto.MaxPaymentAmount = maxAmount;
			}
			if (checkBox_MaxData.Checked)
			{
				sDto.MaxQueryNumber = int.Parse(txt_MaxQuery.Text.Trim());
				sDto.Descending = checkBox_desc.Checked;

				if (comboBox_SortBy.SelectedIndex != -1)
				{
					sDto.OrderBy = _orderByColumns[comboBox_SortBy.SelectedIndex];
				}
				else
				{
					sDto.OrderBy = "OrderID";
				}
			}

			#endregion

			return sDto;
		}

		private void OrderByHeader(int columnIndex)
		{
			if (columnIndex < 0) return;

			string colProp = dataGridView_Main.Columns[columnIndex].DataPropertyName;

			if (_sortMap.TryGetValue(colProp, out Func<OrderGridDto, OrderGridDto, int> func))
			{
				if (_sortedIndex == columnIndex)
				{
					_data.Sort((x, y) => func(y, x));
					_sortedIndex = -1;
				}
				else
				{
					_data.Sort((x, y) => func(x, y));
					_sortedIndex = columnIndex;
				}

				dataGridView_Main.DataSource = _data.Select(dto => dto.ToVM()).ToArray();
			}

		}

		private void ClearSearchConditions()
		{
			txt_OrderID.Text = string.Empty;
			txt_MemberID.Text = string.Empty;
			txt_MemberName.Text = string.Empty;
			comboBox_PurchaseTime.SelectedIndex = -1;
			comboBox_PaymentMethod.SelectedIndex = -1;
			comboBox_Payed.SelectedIndex = -1;
			txt_MinPaymentAmount.Text = string.Empty;
			txt_MaxPaymentAmount.Text = string.Empty;
			txt_MaxQuery.Text = "500";
			checkBox_MaxData.Checked = true;
			checkBox_desc.Checked = false;
			comboBox_SortBy.SelectedIndex = -1;
		}

		private void AutoDisplay(object sender, EventArgs e)
		{
			string message = (e as MessageArgs).Message;
			if (!string.IsNullOrEmpty(message) && !message.Contains("_Order_")) return;

			Display();
		}


	}
}
