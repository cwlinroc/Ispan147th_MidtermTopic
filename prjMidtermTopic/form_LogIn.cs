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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
			try
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
			catch(Exception ex)
			{
				MessageBox.Show($"登入失敗，原因：{ex.Message}");
			}
			
			
		}		

		private void btn_Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
		public const int WM_SYSCOMMAND = 0x0112;
		public const int SC_MOVE = 0xF010;
		public const int HTCAPTION = 0x0002;
		/// <summary>
		/// 為了主介面能夠移動
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void form_LogIn_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
		}
	}



}
