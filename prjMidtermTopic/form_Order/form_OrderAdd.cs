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
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Services;

namespace prjMidtermTopic.form_Order
{
	public partial class form_OrderAdd : Form
	{
		public form_OrderAdd()
		{
			InitializeComponent();
		}

		private void btn_commit_Click(object sender, EventArgs e)
		{
			string customerID = txt_CustomerID.Text.Trim();
			int payMethod = comboBox_PayMethod.SelectedIndex;
			int payed = comboBox_Payed.SelectedIndex;
			if (customerID != "" && payMethod != -1 && payed != -1)
			{
				new OrderService().Create(new OrderDto()
				{
					CustomerID = customerID,
					PaymentMethod = comboBox_PayMethod.SelectedIndex,
					Payed = payed == 0
				});
				DisplayGrim.DisplayAll(this, new MessageArgs { Message = "_Order_" });
				this.Close();
			}
			else
			{
				MessageBox.Show($"請輸入正確數值");
			}
		}
	}
}
