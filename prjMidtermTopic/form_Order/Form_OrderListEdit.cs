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
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;

namespace prjMidtermTopic.form_Order
{
	public partial class Form_OrderListEdit : Form
	{

		private int _orderListID;
		public Form_OrderListEdit(OrderListDto dto)
		{
			InitializeComponent();

			_orderListID = dto.ID;
			txt_OrderID.Text = dto.OrderID.ToString();
			txt_MerchandiseID.Text = dto.MerchandiseID;
			txt_Quantity.Text = dto.Quantity.ToString();
		}

		private void btn_commit_Click(object sender, EventArgs e)
		{
			try
			{
				var vm = new OrderListVM
				{
					ID = _orderListID,
					OrderID = txt_OrderID.Text.Trim(),
					MerchandiseID = txt_MerchandiseID.Text.Trim(),
					Quantity = txt_Quantity.Text.Trim(),
				};

				var map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase) {
					{ "OrderID" , txt_OrderID },
					{ "MerchandiseID" , txt_MerchandiseID },
					{ "Quantity" , txt_Quantity }
				};

				bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, map);

				if (hasError) return;

				int editRows = new OrderListService().Update(vm.ToDto());

				if (editRows > 0)
				{
					MessageBox.Show("更改成功");
				}
				else
				{
					throw new Exception("資料庫回傳值為0");
				}

				if (Owner != null)
				{
					IGrid parent = Owner as IGrid;
					parent.Display();
				}

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗，可能原因：" + ex.Message);
			}

		}
	}
}
