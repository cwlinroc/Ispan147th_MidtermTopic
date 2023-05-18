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

namespace prjMidtermTopic
{
	public partial class form_MerchandiseOrder : Form
	{
		private MerchandiseOrderManager _manager = new MerchandiseOrderManager();
		private MerchandiseOrderListManager _listManager = new MerchandiseOrderListManager();
		private List<MerchandiseOrderDto> _data;
		private int _row = 0;
		private readonly string[] _payment = new string[] { "會員點數", "信用卡", "LinePay", "Bitcoin" };
		public form_MerchandiseOrder()
		{
			InitializeComponent();
		}
		private void form_MerchandiseOrder_Load(object sender, EventArgs e)
		{
			_manager.load();
			_listManager.load();
			display();
			DisplayGrim.Handler += autoDisplay;
		}

		private void form_MerchandiseOrder_FormClosed(object sender, FormClosedEventArgs e)
		{
			DisplayGrim.Handler -= autoDisplay;
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			display();
		}


		private void dataGridView_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			_row = e.RowIndex;
			if (_row < 0) return;
			var frm = new form_OrderList(_listManager, _data[_row].orderID, _manager);
			frm.Owner = this;
			frm.ShowDialog();
		}
		private void btn_Edit_Click(object sender, EventArgs e)
		{
			if (_row < 0) return;
			new form_OrderEditOrder(_manager.update, _data[_row]).ShowDialog();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			new form_OrderAddOrder(_manager.add).ShowDialog();
		}

		private void dataGridView_Main_SelectionChanged(object sender, EventArgs e)
		{
			_row = dataGridView_Main.CurrentCell.RowIndex;
		}

		private void display()
		{
			int? orderID = null;
			if (txt_OrderID.Text.Trim().Length > 0
				&& int.TryParse(txt_OrderID.Text.Trim(), out int result))
			{
				orderID = result;
			}
			_data = _manager.search(orderID, txt_CustomerID.Text.Trim());

			var converteddata = _data
				.Select(o => new
				{
					OrderId = o.orderID,
					CustomerID = o.customerID,
					Paymethod = _payment[o.paymentMethod],
					Payed = o.payed
				})
				.ToList();
			dataGridView_Main.DataSource = converteddata;
		}

		private void autoDisplay(object sender, EventArgs e)
		{
			string message = (e as MessageArgs).Message;
			if (!string.IsNullOrEmpty(message)) MessageBox.Show(message);

			display();
		}

		
	}
}
