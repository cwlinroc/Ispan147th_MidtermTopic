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

namespace prjMidtermTopic
{
	public partial class form_OrderList : Form
	{
		private MerchandiseOrderListManager _listManager;
		private MerchandiseOrderManager _manager;
		private int _orderID;
		private List<MerchandiseOrderListDto> _data;
		private int _row = 0;
		public form_OrderList(MerchandiseOrderListManager listManager, int orderId, MerchandiseOrderManager manager)
		{
			InitializeComponent();
			_listManager = listManager;
			_orderID = orderId;
			_manager = manager;
		}

		private void form_OrderList_Load(object sender, EventArgs e)
		{
			display();
		}

		private void dataGridView_Main_SelectionChanged(object sender, EventArgs e)
		{
			_row = dataGridView_Main.CurrentCell.RowIndex;
		}

		private void btn_EditListItem_Click(object sender, EventArgs e)
		{
			MerchandiseOrderListDto dto = new MerchandiseOrderListDto
			{
				orderListID = int.Parse(dataGridView_Main.Rows[_row].Cells[0].Value.ToString()),
				orderID = int.Parse(dataGridView_Main.Rows[_row].Cells[1].Value.ToString()),
				merchadiseID = dataGridView_Main.Rows[_row].Cells[2].Value.ToString(),
				quantity = int.Parse(dataGridView_Main.Rows[_row].Cells[3].Value.ToString())
			};
			_listManager.update(dto);

			display();
		}

		private void btn_AddListItem_Click(object sender, EventArgs e)
		{
			MerchandiseOrderListDto dto = new MerchandiseOrderListDto
			{
				orderListID = -1,
				orderID = _orderID,
				merchadiseID = "0",
				quantity = 0
			};
			_listManager.add(dto);

			display();
		}

		private void btn_DelteListItem_Click(object sender, EventArgs e)
		{
			int orderListID = int.Parse(dataGridView_Main.Rows[_row].Cells[0].Value.ToString());
			_listManager.delete(orderListID);

			display();
		}

		private void btn_DeleteOrder_Click(object sender, EventArgs e)
		{
			if (_data != null)
			{
				MessageBox.Show("仍然有關連清單，訂單刪除失敗");
			}
			else
			{
				_manager.delete(_orderID);
				DisplayGrim.DisplayAll(this, new MessageArgs());
				this.Close();
			}
		}

		private void dataGridView_Main_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			
			_row = e.RowIndex;
			MerchandiseOrderListDto dto = new MerchandiseOrderListDto{
				orderListID = int.Parse(dataGridView_Main.Rows[_row].Cells[0].Value.ToString()),
				orderID = int.Parse(dataGridView_Main.Rows[_row].Cells[1].Value.ToString()),
				merchadiseID= dataGridView_Main.Rows[_row].Cells[2].Value.ToString(),
				quantity = int.Parse(dataGridView_Main.Rows[_row].Cells[3].Value.ToString())
			};
			_listManager.update(dto);

			display();
		}

		private void display()
		{
			dataGridView_Main.DataSource = null;
			_data = _listManager.search(_orderID);
			dataGridView_Main.DataSource = _data;
		}
	}
}
