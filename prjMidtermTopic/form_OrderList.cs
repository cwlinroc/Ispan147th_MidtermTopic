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
		private int _orderID;
		private List<MerchandiseOrderListDto> _data;
		public form_OrderList(MerchandiseOrderListManager listManager, int orderId)
		{
			InitializeComponent();
			_listManager = listManager;
			_orderID = orderId;
		}

		private void form_OrderList_Load(object sender, EventArgs e)
		{
			_data = _listManager.search(_orderID);
			dataGridView_Main.DataSource = _data;
		}
	}
}
