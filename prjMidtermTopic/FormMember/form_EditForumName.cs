using ISpan147.Estore.SqlDataLayer.Services;
using System;
using System.Windows.Forms;

namespace prjMidtermTopic.FormMember
{
	public partial class form_EditForumName : Form
	{		
		private int _forumID;
		public form_EditForumName(int forumID)
		{
			InitializeComponent();
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
				MessageBox.Show("取得稱呼失敗,原因:" + ex.Message);
			}
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtForumName.Text))
			{
				MessageBox.Show("請輸入稱呼!");
				return;
			}

			try
			{
				var service = new ForumAccountService();
				int forumID = service.UpdateForumAccount(_forumID, txtForumName.Text);

				if (forumID <= 0)
				{
					throw new Exception("未成功取得論壇編號");
				}

				MessageBox.Show("修改成功");

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗,原因:" + ex.Message);
			}
		}
	}
}
