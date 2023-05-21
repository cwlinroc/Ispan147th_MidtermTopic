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

namespace prjMidtermTopic.form_Order
{
	public partial class Form_OrderListEdit : Form
	{
		private OrderListDto _dto;

		public Form_OrderListEdit(OrderListDto dto)
		{
			InitializeComponent();
			_dto = dto;
		}

		private void Form_OrderListEdit_Load(object sender, EventArgs e)
		{
			txt_OrderID.Text = _dto.OrderID.ToString();
			txt_MerchandiseID.Text = _dto.MerchandiseID;
			txt_Quantity.Text = _dto.Quantity.ToString();
		}

		private void btn_commit_Click(object sender, EventArgs e)
		{
			if (txt_MerchandiseID.Text == "" 
				|| !int.TryParse(txt_OrderID.Text, out int orderID)
				|| !int.TryParse(txt_Quantity.Text, out int quantity))
			{
				return;
			}

			new OrderListService().Update(new OrderListDto
			{
				ID = _dto.ID,
				OrderID = orderID,
				MerchandiseID = txt_MerchandiseID.Text,
				Quantity = quantity
			});

			if (Owner != null)
			{
				IGrid parent = Owner as IGrid;
				parent.Display();
			}

			this.Close();
		}
	}
}
