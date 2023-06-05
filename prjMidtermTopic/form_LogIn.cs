using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.ExtMethods;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UClass.View.Login;

namespace prjMidtermTopic
{
	//todo [君韋] 新增employee管理
	public partial class form_LogIn : Form
	{
		public form_LogIn()
		{
			InitializeComponent();

			Beautify.SetFormRoundRectRgn(this, 20);
		}

		private void btn_LogIn_Click(object sender, EventArgs e)
		{
			var repo = new EmployeeRepositoy();
			var dto = repo.Get(txt_Account.Text);

			if (dto == null || txt_Password.Text.GetSaltedSha256() != dto.EmployeePassword)
			{
				MessageBox.Show("帳號密碼錯誤");
				return;
			}

			Authentication.LogIn(dto);
			var frm = new form_Main();
			frm.Owner = this;
			this.Hide();
			frm.Show();
		}		

		private void btn_Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}



}
