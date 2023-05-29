using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.ExtMethods;
using ISpan147.Estore.SqlDataLayer.Repositories;
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
	public partial class form_EmployeeResetPassword : Form
	{
		private EmployeeDto _dto;
		public form_EmployeeResetPassword(EmployeeDto dto)
		{
			InitializeComponent();
			txt_EmployeeName.Text = dto.EmployeeName;
			txt_EmployeeAccount.Text = dto.EmployeeAccount;

			_dto = dto;
		}


		private void btn_ChangePassword_Click(object sender, EventArgs e)
		{
			string password = txt_OldPassword.Text.GetSaltedSha256();

			if (_dto.EmployeePassword != password)
			{
				MessageBox.Show("密碼錯誤!!");
				return;
			}

			password = txt_EmployeePassword.Text;

			if (txt_ConfirmPassword.Text != password)
			{
				MessageBox.Show("新設定的密碼不一致!!");
				return;
			}

			_dto.EmployeePassword = password.GetSaltedSha256();

			new EmployeeRepositoy().Update(_dto);

			MessageBox.Show("密碼更新成功。");

			this.Close();
		}
	}
}
