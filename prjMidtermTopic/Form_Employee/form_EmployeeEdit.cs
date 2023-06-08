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

		private void checkBox_ChangepassWord_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_ChangepassWord.Checked)
			{
				txt_OldPassword.Enabled = true;
				txt_EmployeePassword.Enabled = true;
				txt_ConfirmPassword.Enabled = true;
			}
			else
			{
				txt_OldPassword.Enabled = false;
				txt_EmployeePassword.Enabled = false;
				txt_ConfirmPassword.Enabled = false;
			}
		}
		private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_ShowPassword.Checked)
			{
				txt_OldPassword.PasswordChar = (char)0;
				txt_EmployeePassword.PasswordChar = (char)0;
				txt_ConfirmPassword.PasswordChar = (char)0;
			}
			else
			{
				txt_OldPassword.PasswordChar = '*';
				txt_EmployeePassword.PasswordChar = '*';
				txt_ConfirmPassword.PasswordChar = '*';
			}
		}

		private void btn_ChangePassword_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txt_EmployeeName.Text) || string.IsNullOrEmpty(txt_EmployeeAccount.Text))
			{
				MessageBox.Show("姓名和帳號欄位不可為空");
				return;
			}

			_dto.EmployeeName = txt_EmployeeName.Text;

			_dto.EmployeeAccount = txt_EmployeeAccount.Text;

			if (checkBox_ChangepassWord.Checked)
			{
				if (txt_ConfirmPassword.Text != txt_EmployeePassword.Text)
				{
					MessageBox.Show("新設定的密碼不一致!!");
					return;
				}

				string password = txt_OldPassword.Text.GetSaltedSha256();

				if (_dto.EmployeePassword != password)
				{
					MessageBox.Show("密碼錯誤!!");
					return;
				}

				_dto.EmployeePassword = txt_EmployeePassword.Text.GetSaltedSha256();
			}

			new EmployeeRepositoy().Update(_dto);

			MessageBox.Show("資料更新成功。");

			var parent = Owner as IGrid;

			if (parent != null) parent.Display();

			this.Close();
		}


	}
}
