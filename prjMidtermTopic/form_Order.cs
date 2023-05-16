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
	public partial class form_MerchandiseOrder : Form
	{
		private CMerchandiseOrderManager manager;
		private readonly string[] _payment = new string[] { "會員點數", "信用卡", "LinePay", "Bitcoin" };
		public form_MerchandiseOrder()
		{
			InitializeComponent();
			manager = new CMerchandiseOrderManager();
		}
		private void form_MerchandiseOrder_Load(object sender, EventArgs e)
		{
			manager.load();
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			int? orderID = null;
			if (txt_OrderID.Text.Trim().Length > 0
				&& int.TryParse(txt_OrderID.Text.Trim(), out int result))
			{
				orderID = result;
			}
			List<MerchandisOrderPto> ptoList = manager
				.search(orderID, txt_CustomerID.Text.Trim());
			ShowOrders(ptoList);
		}

		private void btn_ShowList_Click(object sender, EventArgs e)
		{

		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			new form_OrderAddOrder(manager.add).ShowDialog();
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{

		}

		private void ShowOrders(List<MerchandisOrderPto> ptoList)
		{
			listView_Main.Items.Clear();
			foreach (var pto in ptoList)
			{
				var item = new ListViewItem(pto.orderID.ToString());
				item.SubItems.Add(pto.customerID);
				item.SubItems.Add(_payment[pto.paymentMethod]);
				item.SubItems.Add(pto.payed ? "已付款" : "未付款");
				listView_Main.Items.Add(item);
			}
		}

	}
}
