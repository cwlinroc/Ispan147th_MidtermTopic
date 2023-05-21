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
using ISpan147.Estore.SqlDataLayer.Services;
using ISpan147.Estore.SqlDataLayer.Dtos;
using prjMidtermTopic.ViewModels;

namespace prjMidtermTopic.form_Order
{
	public partial class form_OrderEdit : Form
	{
		public form_OrderEdit(OrderDto dto)
		{
			InitializeComponent();

			comboBox_PayMethod.Items.AddRange(OrderVM.GetPayMethods().ToArray());
			comboBox_Payed.Items.AddRange(OrderVM.GetPayed().ToArray());

			txt_OrderID.Text = dto.ID.ToString();
			txt_CustomerID.Text = dto.CustomerID.ToString();
			comboBox_PayMethod.SelectedIndex = dto.PaymentMethod;
			comboBox_Payed.SelectedIndex = (dto.Payed) ? 1 : 0;
		}


		private void btn_commit_Click(object sender, EventArgs e)
		{
			try
			{
				var vm = new OrderVM()
				{
					ID = int.Parse(txt_OrderID.Text.Trim()),
					CustomerID = txt_CustomerID.Text.Trim(),
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

				DisplayGrim.DisplayAll(this, new MessageArgs { Message = "_Order_" });

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗，可能原因：" + ex.Message);
			}
			
		}

		
	}
}
