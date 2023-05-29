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
using prjMidtermTopic.ViewModels;

namespace prjMidtermTopic.Form_Order
{
	public partial class form_OrdersEdit : Form
	{
		private readonly Dictionary<string, Control> _validateMap;
		public form_OrdersEdit(OrderGridDto dto)
		{
			InitializeComponent();

			comboBox_PayMethod.Items.AddRange(Orders.paymentOptions);
			comboBox_Payed.Items.AddRange(Orders.payedOptions);
			
			txt_OrderID.Text = dto.OrderID.ToString();
			txt_MemberID.Text = dto.MemberID.ToString();
			comboBox_PayMethod.SelectedIndex = dto.PaymentMethod;
			comboBox_Payed.SelectedIndex = (dto.Payed) ? 1 : 0;
			dateTimePicker_PurchaseTime.Value = dto.PurchaseTime.Value;
			txt_PaymentAmount.Text = dto.PaymentAmount?.ToString();

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
					OrderID = int.Parse(txt_OrderID.Text.Trim()),
					MemberID = txt_MemberID.Text.Trim(),
					PaymentMethod = comboBox_PayMethod.SelectedItem?.ToString(),
					Payed = comboBox_Payed.SelectedItem?.ToString(),
					PurchaseTime = dateTimePicker_PurchaseTime.Value,
					PaymentAmount = txt_PaymentAmount.Text.Trim(),
				};
								
				bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, _validateMap);

				if (hasError) return;

				int editRows = new OrderService().Update(vm.ToDto());

				if (editRows > 0)
				{
					MessageBox.Show("更改成功");
				}
				else
				{
					throw new Exception("資料庫回傳值為0");
				}

				DisplayGrid.DisplayAll(this, new MessageArgs { Message = "_Order_" });

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗，可能原因：" + ex.Message);
			}

		}


	}
}
