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

namespace prjMidtermTopic.form_Order
{
	public partial class form_OrderEdit : Form
	{
		public form_OrderEdit(OrderGridDto dto)
		{
			InitializeComponent();

			comboBox_PayMethod.Items.AddRange(Orders.paymentOptions);
			comboBox_Payed.Items.AddRange(Orders.payedOptions);

			txt_OrderID.Text = dto.OrderID.ToString();
			txt_CustomerID.Text = dto.MemberID.ToString();
			comboBox_PayMethod.SelectedIndex = dto.PaymentMethod;
			comboBox_Payed.SelectedIndex = (dto.Payed) ? 1 : 0;
		}


		private void btn_commit_Click(object sender, EventArgs e)
		{
			try
			{
				var vm = new OrderVM()
				{
					OrderID = int.Parse(txt_OrderID.Text.Trim()),
					MemberID = txt_CustomerID.Text.Trim(),
					PaymentMethod = comboBox_PayMethod.SelectedItem?.ToString(),
					Payed = comboBox_Payed.SelectedItem?.ToString()
				};

				var map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase) {
					{ "ID" , txt_OrderID },
					{ "CustomerID" , txt_CustomerID },
					{ "PaymentMethod" , comboBox_PayMethod },
					{ "Payed" , comboBox_Payed }
				};

				bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, map);

				if (hasError) return;

				int editRows = new OrderService().Update(vm.ToDto());

				if(editRows > 0)
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
