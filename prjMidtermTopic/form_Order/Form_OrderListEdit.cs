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
		private Action<OrderListGridDto> _func;
		private OrderListGridDto _dto;

		public Form_OrderListEdit(Action<OrderListGridDto> func, OrderListGridDto dto)
		{
			InitializeComponent();
			_func = func;
			_dto = dto;
		}

		private void Form_OrderListEdit_Load(object sender, EventArgs e)
		{
			txt_OrderID.Text = _dto.OrderID.ToString();
			txt_MerchandiseID.Text = _dto.MerchadiseID;
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

			var dto = new OrderListGridDto
			{
				ID = _dto.ID,
				OrderID = orderID,
				MerchadiseID = txt_MerchandiseID.Text,
				Quantity = quantity
			};

			_func(dto);

			if (Owner != null)
			{
				IGrid parent = Owner as IGrid;
				parent.Display();
			}

			this.Close();
		}
	}
}
