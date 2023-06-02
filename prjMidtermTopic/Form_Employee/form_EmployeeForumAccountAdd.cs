using ISpan147.Estore.SqlDataLayer.Services;
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
	public partial class form_EmployeeForumAccountAdd : Form
	{
		private string _account;
		public form_EmployeeForumAccountAdd(string account)
		{
			InitializeComponent();
			_account = account;
		}

		private void btn_Confirm_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txt_ForumName.Text.Trim()))
			{
				MessageBox.Show("名稱不可以是空白!");
				return;
			}

			try
			{
				var service = new EmployeeServices();
				int forumID = service.CreateForumAccount(_account, txt_ForumName.Text);

				if (forumID <= 0)
				{
					throw new Exception("未成功取得ForumAccountID");
				}

				Authentication.ForumAccountID = forumID;

				MessageBox.Show("新增成功");

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，可能原因：" + ex.Message);
			}
		}
	}
}
