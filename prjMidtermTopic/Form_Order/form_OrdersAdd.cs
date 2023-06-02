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

namespace prjMidtermTopic.Form_Order
{
	public partial class form_OrdersAdd : Form
	{
		private readonly Dictionary<string, Control> _validateMap;
		public form_OrdersAdd()
		{
			InitializeComponent();

			comboBox_PayMethod.Items.AddRange(Orders.paymentOptions);
			comboBox_Payed.Items.AddRange(Orders.payedOptions);
			dateTimePicker_PurchaseTime.Value = DateTime.Now;

			_validateMap = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase) {
					{ "OrderID" , txt_OrderID },
					{ "MemberID" , txt_MemberID },
					{ "PaymentMethod" , comboBox_PayMethod },
					{ "Payed" , comboBox_Payed },
					{ "PurchaseTime", dateTimePicker_PurchaseTime },
					{ "PaymentAmount", txt_PaymentAmount }
				};
		}

		//button
		private void btn_commit_Click(object sender, EventArgs e)
		{
			try
			{
				var vm = new OrderVM()
				{
					MemberID = txt_MemberID.Text.Trim(),
					PaymentMethod = comboBox_PayMethod.SelectedItem?.ToString(),
					Payed = comboBox_Payed.SelectedItem?.ToString(),
					PurchaseTime = dateTimePicker_PurchaseTime.Value,
					PaymentAmount = txt_PaymentAmount.Text.Trim(),
				};

				bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, _validateMap);

				if (hasError) return;

				int newId = new OrderService().Create(vm.ToDto());

				MessageBox.Show($"輸入成功，ID為{newId}");

				DisplayGrid.DisplayAll(this, new MessageArgs { Message = "_Order_" });

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，可能原因：" + ex.Message);
			}
		}


	}
}
