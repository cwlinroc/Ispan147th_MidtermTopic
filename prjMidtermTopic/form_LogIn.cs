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

namespace prjMidtermTopic
{
	//todo [君韋] 新增employee管理
	public partial class form_LogIn : Form
	{
		public form_LogIn()
		{
			InitializeComponent();
		}

		private void btn_LogIn_Click(object sender, EventArgs e)
		{
			var repo = new EmployeeRepositoy();
			var dto = repo.Get(txt_Account.Text);
			
			if(dto == null || txt_Password.Text.GetSaltedSha256() != dto.EmployeePassword)
			{
				MessageBox.Show("帳號密碼錯誤");
				return;
			}

			var frm = new form_Main();
			frm.Owner = this;
			this.Hide();
			frm.Show();
		}
	}
}
