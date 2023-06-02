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
	public partial class form_EmployeeEdit : Form
	{
		private EmployeeDto _dto;
		public form_EmployeeEdit(EmployeeDto dto)
		{
			InitializeComponent();
			txt_EmployeeName.Text = dto.EmployeeName;
			txt_EmployeeAccount.Text = dto.EmployeeAccount;

			_dto = dto;
		}


		private void btn_ChangePassword_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txt_EmployeeName.Text) || string.IsNullOrEmpty(txt_EmployeeAccount.Text) )
			{
				MessageBox.Show("姓名和帳號欄位不可為空");
				return;
			}

			_dto.EmployeeName = txt_EmployeeName.Text;

			_dto.EmployeeAccount = txt_EmployeeAccount.Text;

			if (checkBox_ChangePassWord.Checked)
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
			}			

			new EmployeeRepositoy().Update(_dto);

			MessageBox.Show("資料更新成功。");

			this.Close();
		}
	}
}
