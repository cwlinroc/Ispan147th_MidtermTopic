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

namespace prjMidtermTopic
{
	public partial class form_MerchandiseOrder : Form
	{
		private OrderManager _manager = new OrderManager();
		private OrderListManager _listManager = new OrderListManager();
		private List<OrderGridDto> _data;
		private int _row = 0;
		public form_MerchandiseOrder()
		{
			InitializeComponent();
		}

		//load
		private void form_MerchandiseOrder_Load(object sender, EventArgs e)
		{
			_manager.Load();
			_listManager.Load();
			Display();
			DisplayGrim.Handler += AutoDisplay;
		}

		//closed
		private void form_MerchandiseOrder_FormClosed(object sender, FormClosedEventArgs e)
		{
			DisplayGrim.Handler -= AutoDisplay;
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
		private void btn_Edit_Click(object sender, EventArgs e)
		{
			if (_row < 0) return;
			new form_OrderEdit(_manager.Update, _data[_row]).ShowDialog();
		}
		private void btn_Add_Click(object sender, EventArgs e)
		{
			new form_OrderAdd(_manager.Add).ShowDialog();
		}

		//double click
		private void dataGridView_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			_row = e.RowIndex;
			if (_row < 0) return;
			var frm = new form_OrderList(_listManager, _data[_row].ID, _manager);
			frm.Owner = this;
			frm.ShowDialog();
		}
		

		//methods
		private void Display()
		{
			int? orderID = null;
			if (txt_OrderID.Text.Trim().Length > 0
				&& int.TryParse(txt_OrderID.Text.Trim(), out int result))
			{
				orderID = result;
			}
			_data = _manager.Search(orderID, txt_CustomerID.Text.Trim());
			
			dataGridView_Main.DataSource = _data;
		}

		private void AutoDisplay(object sender, EventArgs e)
		{
			string message = (e as MessageArgs).Message;
			if (!string.IsNullOrEmpty(message)&&!message.Contains("_Order_")) return;

			Display();
		}
	}
}
