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
using ISpan147.Estore.SqlDataLayer.Services;
using ISpan147.Estore.SqlDataLayer.Dtos;

namespace prjMidtermTopic
{
	public partial class form_OrderEdit : Form
	{
		private Action<OrderGridDto> func;
		public form_OrderEdit(Action<OrderGridDto> func, OrderGridDto dto)
		{
			InitializeComponent();
			this.func = func;

			txt_OrderID.Text = dto.ID.ToString();
			txt_CustomerID.Text = dto.CustomerID.ToString();
			comboBox_PayMethod.SelectedItem = dto.PaymentMethod;
			comboBox_Payed.SelectedIndex = (dto.Payed) ? 0 : 1;
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
				func(new OrderGridDto()
				{
					ID = orderID,
					CustomerID = customerID,
					PaymentMethod = comboBox_PayMethod.SelectedItem.ToString(),
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
