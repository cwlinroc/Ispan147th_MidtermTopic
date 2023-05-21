﻿using System;
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
	public partial class form_OrderListAdd : Form
	{
		
		private int _orderID;
		public form_OrderListAdd(int orderId)
		{
			InitializeComponent();
			_orderID = orderId;
			txt_OrderID.Text = orderId.ToString();
		}
		
		private void btn_commit_Click(object sender, EventArgs e)
		{
			if (txt_MerchandiseID.Text == "" || !int.TryParse(txt_OrderID.Text, out int orderID)
				|| !int.TryParse(txt_Quantity.Text, out int quantity))
			{
				return;
			}

			new OrderListService().Create( new OrderListDto
			{
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
