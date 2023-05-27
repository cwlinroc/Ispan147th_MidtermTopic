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

namespace prjMidtermTopic.form_Order
{
	public partial class form_Orders : Form
	{

		private List<OrderGridDto> _data;
		private int _row = -1;
		public form_Orders()
		{
			InitializeComponent();
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
		private void btn_Edit_Click(object sender, EventArgs e)
		{
			if (_row < 0) return;
			new form_OrderEdit(_data[_row]).ShowDialog();
		}
		private void btn_Add_Click(object sender, EventArgs e)
		{
			new form_OrderAdd().ShowDialog();
		}

		//double click
		private void dataGridView_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			_row = e.RowIndex;
			if (_row < 0) return;
			var frm = new form_OrderList(_data[_row].OrderID);
			frm.Owner = this;
			frm.ShowDialog();
		}


		//methods
		private void Display()
		{
			try
			{
				var sDto = new OrderSearchDto();

				if (txt_OrderID.Text.Trim().Length > 0
					&& int.TryParse(txt_OrderID.Text.Trim(), out int _orderID))
				{
					sDto.OrderID = _orderID;
				}
				if (txt_OrderID.Text.Trim().Length > 0
					&& int.TryParse(txt_OrderID.Text.Trim(), out int _memberID))
				{
					sDto.MemberID = _memberID;
				}

				var gridDtoList = new OrderService().Search(sDto);

				_data = gridDtoList.OrderBy(o=> o.OrderID).ToList();

				dataGridView_Main.DataSource = _data.Select(dto => dto.ToVM()).ToArray();
			}
			catch (Exception ex)
			{
				MessageBox.Show("資料查詢失敗，可能原因：" + ex.Message);
			}

		}

		private void AutoDisplay(object sender, EventArgs e)
		{
			string message = (e as MessageArgs).Message;
			if (!string.IsNullOrEmpty(message) && !message.Contains("_Order_")) return;

			Display();
		}
	}
}
