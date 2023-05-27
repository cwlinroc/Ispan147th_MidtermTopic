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

namespace prjMidtermTopic.form_Order
{
	public partial class form_OrderList : Form, IGrid
	{
		private int _orderID;
		private List<OrderListGridDto> _data;
		private int _row = -1;
		private int _sortedIndex = 0;
		private Dictionary<string, Func<OrderListGridDto, OrderListGridDto, int>> _sortMap =
			new Dictionary<string, Func<OrderListGridDto, OrderListGridDto, int>>
			{
				{ "OrderListID", (prev, next) => prev.OrderListID.CompareTo(next.OrderListID) },
				{ "MerchandiseID", (prev, next) => prev.MerchandiseID.CompareTo(next.MerchandiseID) },
				{ "MerchandiseName", (prev, next) => prev.MerchandiseName.Length.CompareTo(next.MerchandiseName.Length) },
				{ "OrderID", (prev, next) => prev.OrderID.CompareTo(next.OrderID) },
				{ "Quantity", (prev, next) => prev.Quantity.CompareTo(next.Quantity) }
			};
		public form_OrderList(int orderId)
		{
			InitializeComponent();
			_orderID = orderId;
		}

		//load
		private void form_OrderList_Load(object sender, EventArgs e)
		{
			Display();
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

			var frm = new Form_OrderListEdit(_data[_row]);
			frm.Owner = this;
			frm.ShowDialog();
		}
		private void btn_AddListItem_Click(object sender, EventArgs e)
		{
			var frm = new form_OrderListAdd(_orderID);
			frm.Owner = this;
			frm.ShowDialog();
		}
		private void btn_DelteListItem_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("確定篩除該項目？", "確認刪除", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.No) return;

			try
			{
				int orderListID = int.Parse(dataGridView_Main.Rows[_row]
								.Cells[0].Value.ToString());
				new OrderListService(new OrderListRepositoryAdoNet()).Delete(orderListID);

				Display();
			}
			catch (Exception ex)
			{
				MessageBox.Show("刪除失敗，可能原因為：" + ex.Message);
			}
		}
		private void btn_DeleteOrder_Click(object sender, EventArgs e)
		{
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
		//todo [君韋] 註解datagridview 排序
		private void dataGridView_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 || e.ColumnIndex < 0) return;

			string colProp = dataGridView_Main.Columns[e.ColumnIndex].DataPropertyName;

			if (_sortMap.TryGetValue(colProp, out Func<OrderListGridDto, OrderListGridDto, int> func))
			{
				if (_sortedIndex == e.ColumnIndex)
				{
					_data.Sort((x, y) => func(y, x));
					_sortedIndex = -1;
				}
				else
				{
					_data.Sort((x, y) => func(x, y));
					_sortedIndex = e.ColumnIndex;
				}

				dataGridView_Main.DataSource = _data.Select(dto => dto.ToVM()).ToArray();				
			}
		}


		//methods
		public void Display()
		{
			try
			{
				dataGridView_Main.DataSource = null;
				_data = new OrderListService(new OrderListRepositoryAdoNet())
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
