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
	public partial class form_OrderAddOrder : Form
	{
		private Action<int, string, int, bool> func;
		public form_OrderAddOrder(Action<int, string, int, bool> func)
		{
			InitializeComponent();
			this.func = func;
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
				func(orderID, customerID, payMethod, payed == 0);
				this.Close();
			}
			else
			{
				MessageBox.Show($"請輸入正確數值");
			}
		}
	}
}
