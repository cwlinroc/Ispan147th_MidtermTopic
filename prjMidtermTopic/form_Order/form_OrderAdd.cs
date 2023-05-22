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
using prjMidtermTopic.ViewModels;

namespace prjMidtermTopic.form_Order
{
	public partial class form_OrderAdd : Form
	{
		public form_OrderAdd()
		{
			InitializeComponent();
			comboBox_PayMethod.Items.AddRange(Orders.paymentOptions);
			comboBox_Payed.Items.AddRange(Orders.payedOptions);
		}

		private void btn_commit_Click(object sender, EventArgs e)
		{
			try
			{
				var vm = new OrderVM()
				{
					CustomerID = txt_CustomerID.Text.Trim(),
					PaymentMethod = comboBox_PayMethod.SelectedItem?.ToString(),
					Payed = comboBox_Payed.SelectedItem?.ToString(),
				};

				var map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase) {
					{ "ID" , txt_OrderID },
					{ "CustomerID" , txt_CustomerID },
					{ "PaymentMethod" , comboBox_PayMethod },
					{ "Payed" , comboBox_Payed }
				};

				bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, map);

				if (hasError) return;

				int newId = new OrderService().Create(vm.ToDto());

				MessageBox.Show($"輸入成功，ID為{newId}");

				DisplayGrim.DisplayAll(this, new MessageArgs { Message = "_Order_" });

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，可能原因：" + ex.Message);
			}
		}
	}
}
