﻿using prjMidtermTopic.Model;
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
	public partial class form_OrderEditOrder : Form
	{
		private Action<MerchandiseOrderDto> func;
		public form_OrderEditOrder(Action<MerchandiseOrderDto> func, MerchandiseOrderDto dto)
		{
			InitializeComponent();
			this.func = func;
			txt_OrderID.Text = dto.orderID.ToString();
			txt_CustomerID.Text = dto.customerID.ToString();
			comboBox_PayMethod.SelectedIndex = dto.paymentMethod;
			comboBox_Payed.SelectedIndex = (dto.payed) ? 0 : 1;
		}

		private void btn_commit_Click(object sender, EventArgs e)
		{
			string orderIDstr = txt_OrderID.Text.Trim();
			string customerID = txt_CustomerID.Text.Trim();
			int payMethod = comboBox_PayMethod.SelectedIndex;
			int payed = comboBox_Payed.SelectedIndex;
			if (int.TryParse(orderIDstr, out int orderID) && customerID != ""
				&& payMethod != -1 && payed != -1)
			{
				func(new MerchandiseOrderDto()
				{
					orderID = orderID,
					customerID = customerID,
					paymentMethod = payMethod,
					payed = payed == 0
				});
				DisplayGrim.DisplayAll(this, new MessageArgs());
				this.Close();
			}
			else
			{
				MessageBox.Show($"請輸入正確數值");
			}
		}
	}
}
