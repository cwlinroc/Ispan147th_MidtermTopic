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
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;

namespace prjMidtermTopic.form_Order
{
	public partial class form_OrderListAdd : Form
	{

		private IOrderListRepositoy _repo;
		public form_OrderListAdd(int orderId)
		{
			InitializeComponent();
			txt_OrderID.Text = orderId.ToString();

			_repo = new OrderListRepositoryLinq();
		}

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

				var map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase) {
					{ "OrderID" , txt_OrderID },
					{ "MerchandiseID" , txt_MerchandiseID },
					{ "Quantity" , txt_Quantity }
				};

				bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, map);

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
				MessageBox.Show("新增失敗，可能原因：" + ex.Message);
			}

		}


	}
}
