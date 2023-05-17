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
		private MerchandiseOrderManager _manager= new MerchandiseOrderManager();
		private MerchandiseOrderListManager _listManager = new MerchandiseOrderListManager();
		private List<MerchandiseOrderDto> _data;
		private readonly string[] _payment = new string[] { "會員點數", "信用卡", "LinePay", "Bitcoin" };
		public form_MerchandiseOrder()
		{
			InitializeComponent();
		}
		private void form_MerchandiseOrder_Load(object sender, EventArgs e)
		{
			_manager.load();
			_listManager.load();
			displayOrders(_manager.search());
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			int? orderID = null;
			if (txt_OrderID.Text.Trim().Length > 0
				&& int.TryParse(txt_OrderID.Text.Trim(), out int result))
			{
				orderID = result;
			}
			List<MerchandiseOrderDto> dtoList = _manager
				.search(orderID, txt_CustomerID.Text.Trim());
			displayOrders(dtoList);
		}

		

		private void dataGridView_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int row = e.RowIndex; 
			if (row < 0) return;
			var frm = new form_OrderList(_listManager, _data[row].orderID);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			new form_OrderAddOrder(_manager.add).ShowDialog();
		}

		

		private void displayOrders(List<MerchandiseOrderDto> dtoList)
		{
			_data = dtoList;
			var converteddata = dtoList
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

		
	}
}
