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

namespace prjMidtermTopic.FormMember
{
	public partial class form_EditForumName : Form
	{
		private string _account;
		private int _forumID;
		public form_EditForumName(string account, int forumID)
		{
			InitializeComponent();
			_account = account;
			_forumID = forumID;
			Load += form_EditForumName_Load;
		}

		private void form_EditForumName_Load(object sender, EventArgs e)
		{
			try
			{
				txtForumName.Text = new ForumAccountService().GetForumAccountName(_forumID);
			}
			catch (Exception ex)
			{
				MessageBox.Show("取得ForumName失敗，可能原因：" + ex.Message);
			}
		}
	}
}
