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
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.ViewModels;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.EFModel;

namespace prjMidtermTopic.Form_Order
{
	public partial class form_OrderList : Form, IGrid
	{
		private IOrderListRepositoy _repo;
		private int _orderID;
		private List<OrderListGridDto> _data;
		private int _row = -1;
		private int _sortedIndex = 0;
		private readonly Dictionary<string, Func<OrderListGridDto, OrderListGridDto, int>> _sortMap;
		public form_OrderList(int orderId)
		{
			InitializeComponent();

			_orderID = orderId;

			_repo = new OrderListRepositoryDapper();

			_sortMap = new Dictionary<string, Func<OrderListGridDto, OrderListGridDto, int>>
			{
				{ "OrderListID", (prev, next) => prev.OrderListID.CompareTo(next.OrderListID) },
				{ "MerchandiseID", (prev, next) => prev.MerchandiseID.CompareTo(next.MerchandiseID) },
				{ "MerchandiseName", (prev, next) => prev.MerchandiseName.Length.CompareTo(next.MerchandiseName.Length) },
				{ "OrderID", (prev, next) => prev.OrderID.CompareTo(next.OrderID) },
				{ "Quantity", (prev, next) => prev.Quantity.CompareTo(next.Quantity) }
			};
		}

		//load
		private void form_OrderList_Load(object sender, EventArgs e)
		{
			Display();

			if (Authentication.Permission > 3)
			{
				btn_AddListItem.Enabled = false;
				btn_EditListItem.Enabled = false;
				btn_DeleteOrder.Enabled = false;
				btn_DelteListItem.Enabled = false;
			}
		}

		//select change
		private void dataGridView_Main_SelectionChanged(object sender, EventArgs e)
		{
			_row = dataGridView_Main.CurrentCell.RowIndex;
		}

		//buttons
		#region --button--

		private void btn_EditListItem_Click(object sender, EventArgs e)
		{
			if (_row < 0) return;
			if (!PermissionCheck.Enable(3)) return;

			var frm = new Form_OrderListEdit(_data[_row]);
			frm.Owner = this;
			frm.ShowDialog();
		}
		private void btn_AddListItem_Click(object sender, EventArgs e)
		{
			if (!PermissionCheck.Enable(3)) return;

			var frm = new form_OrderListAdd(_orderID);
			frm.Owner = this;
			frm.ShowDialog();
		}
		private void btn_DelteListItem_Click(object sender, EventArgs e)
		{
			if (!PermissionCheck.Enable(3)) return;

			DialogResult dialogResult = MessageBox.Show("確定篩除該項目？", "確認刪除", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.No) return;

			try
			{
				int orderListID = int.Parse(dataGridView_Main.Rows[_row]
								.Cells[0].Value.ToString());
				new OrderListService(_repo).Delete(orderListID);

				Display();
			}
			catch (Exception ex)
			{
				MessageBox.Show("刪除失敗，可能原因為：" + ex.Message);
			}
		}
		private void btn_DeleteOrder_Click(object sender, EventArgs e)
		{
			if (!PermissionCheck.Enable(3)) return;

			DialogResult dialogResult = MessageBox.Show("確定篩除該訂單？", "確認刪除", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.No) return;

			try
			{
				if (_data.Count > 0)
				{
					MessageBox.Show("仍然有關連清單，訂單刪除失敗");
					return;
				}
				new OrderService().Delete(_orderID);

				DisplayGrid.DisplayAll(this, new MessageArgs());
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("刪除失敗，可能原因為：" + ex.Message);
			}
		}

		#endregion

		//cell double click
		//依據標題欄位排序
		private void dataGridView_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 || e.ColumnIndex < 0) return;

			//取得雙擊標題(column header)所對應的資料屬性名稱(Property Name)
			string colProp = dataGridView_Main.Columns[e.ColumnIndex].DataPropertyName; 
			
			//將對應的名稱字串輸入Dictionary _sortMap,並得到對應比較方式的委派
			if (_sortMap.TryGetValue(colProp, out Func<OrderListGridDto, OrderListGridDto, int> func))
			{
				//如果雙擊的標題是剛好是之前升冪排序的資料行(column)，則反轉為降冪排序
				if (_sortedIndex == e.ColumnIndex)
				{
					//因為_data是List，所以直接呼叫List.Sort方法，並依照其中的委派比較方式做排序
					_data.Sort((x, y) => func(y, x));
					//將紀錄清空，因為下次不管點到哪個都肯定是昇冪
					_sortedIndex = -1;
				}
				//其餘的就一律升冪排序
				else
				{
					_data.Sort((x, y) => func(x, y));
					//紀錄這次昇冪排列的資料行
					_sortedIndex = e.ColumnIndex;
				}
				//將整理好的_data丟到dataGridView裡面
				dataGridView_Main.DataSource = _data.Select(dto => dto.ToVM()).ToArray();
			}
		}


		//methods
		public void Display()
		{
			try
			{
				_data = new OrderListService(_repo)
					.Search(null, _orderID).ToList();

				_data.Sort((prev, next) => prev.OrderListID.CompareTo(next.OrderListID));

				dataGridView_Main.DataSource = _data.Select(dto => dto.ToVM()).ToArray();
			}
			catch (Exception ex)
			{
				MessageBox.Show("資料查詢失敗，可能原因：" + ex.Message);
			}
		}

	}
}
