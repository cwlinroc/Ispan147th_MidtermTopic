using ISpan147.Estore.SqlDataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.Form_Employee
{
	public partial class form_EmployeeForumAccountEdit : Form
	{
		private string _account;
		private int _forumID;
		public form_EmployeeForumAccountEdit(string account, int forumID)
		{
			InitializeComponent();
			_account = account;
			_forumID = forumID;
			Load += Form_EmployeeForumAccountEdit_Load;
		}

		private void Form_EmployeeForumAccountEdit_Load(object sender, EventArgs e)
		{
			try
			{
				txt_ForumName.Text = new EmployeeServices().GetForumAccountName(_forumID);
			}
			catch (Exception ex)
			{
				MessageBox.Show("取得ForumName失敗，可能原因：" + ex.Message);
			}
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
				int forumID = service.UpdateForumAccount(_forumID, txt_ForumName.Text);

				if (forumID <= 0)
				{
					throw new Exception("未成功取得ForumAccountID");
				}

				MessageBox.Show("修改成功");

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗，可能原因：" + ex.Message);
			}
		}
	}
}
