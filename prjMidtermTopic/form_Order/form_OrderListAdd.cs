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
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;

namespace prjMidtermTopic.Form_Order
{
	public partial class form_OrderListAdd : Form
	{

		private IOrderListRepositoy _repo;
		private readonly Dictionary<string, Control> _validateMap;

		public form_OrderListAdd(int orderId)
		{
			InitializeComponent();

			txt_OrderID.Text = orderId.ToString();

			_repo = new OrderListRepositoryDapper();

			_validateMap = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase) {
					{ "OrderID" , txt_OrderID },
					{ "MerchandiseID" , txt_MerchandiseID },
					{ "Quantity" , txt_Quantity }
				};
		}

		//button
		private void btn_commit_Click(object sender, EventArgs e)
		{
			try
			{
				var vm = new OrderListVM
				{
					OrderID = txt_OrderID.Text.Trim(),
					MerchandiseID = txt_MerchandiseID.Text.Trim(),
					Quantity = txt_Quantity.Text.Trim()
				};				

				bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, _validateMap);

				if (hasError) return;

				int newId = new OrderListService(_repo)
					.Create(vm.ToDto());

				MessageBox.Show($"輸入成功，ID為{newId}");

				if (Owner != null)
				{
					IGrid parent = Owner as IGrid;
					parent.Display();
				}

				this.Close();
			}
			catch (Exception ex)
			{
				//todo 改為尋找對應ID存不存在
				if (ex.Message.Contains("FK"))
				{
					MessageBox.Show("輸入ID不存在，請再進行確認。");
				}
				else
				{
					MessageBox.Show("新增失敗，可能原因：" + ex.Message);
				}
			}

		}


	}
}
