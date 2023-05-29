using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.ExtMethods;
using ISpan147.Estore.SqlDataLayer.Repositories;
using prjMidtermTopic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.Form_Employee
{
	public partial class form_EmployeeAdd : Form
	{
		public form_EmployeeAdd()
		{
			InitializeComponent();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txt_EmployeeName.Text.Trim())
					&& string.IsNullOrEmpty(txt_EmployeeAccount.Text.Trim())
					&& string.IsNullOrEmpty(txt_EmployeePassword.Text.Trim())
					&& !int.TryParse(txt_Permission.Text.Trim(), out int result)
					)
				{
					throw new Exception("欄位輸入錯誤");
				}

				var repo = new EmployeeRepositoy();

				var dto = new EmployeeDto
				{
					EmployeeName = txt_EmployeeName.Text.Trim(),
					EmployeeAccount = txt_EmployeeAccount.Text.Trim(),
					EmployeePassword = txt_EmployeePassword.Text.Trim().GetSaltedSha256(),
					Permission = int.Parse(txt_Permission.Text.Trim()),
				};

				int id = repo.Create(dto);

				MessageBox.Show($"輸入成功，編號為{id}");

				var parent = Owner as IGrid;

				if (parent != null) parent.Display();

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("輸入失敗，可能原因" + ex.Message);
			}
		}
	}
}
