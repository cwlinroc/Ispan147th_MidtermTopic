using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.form_QA
{
	
	public partial class from_CommentCreate : Form
	{
		QAService _service;
		private readonly int _themeId;

		public from_CommentCreate()
		{
			InitializeComponent();
		}

		public from_CommentCreate(int themeId)
		{
			InitializeComponent();
			_themeId = themeId;
			_service = new QAService();
		}

		private void buttonConfirmComment_Click(object sender, EventArgs e)
		{
			string commentContext = richTextBoxComment.Text;

			if (string.IsNullOrWhiteSpace(commentContext))
			{
				MessageBox.Show("您輸入的留言為空，請調整!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			QADto.Comment commentDto = new QADto.Comment();
			commentDto.ForumAccountId = Convert.ToInt32(labelCommentRoleID.Text);
			commentDto.ForumAccountName = labelCommentRole.Text;
			commentDto.CommentContext = richTextBoxComment.Text;
			commentDto.CommentTime = DateTime.Now;
			commentDto.ThemeId = this._themeId;
					
			var result = _service.CreateComment(commentDto);

			MessageBox.Show(result);
			IGridComment parent = this.Owner as IGridComment;
			parent.CommentDisplay();
			this.Close();
			
			
		}

		private void from_CommentCreate_Load(object sender, EventArgs e)
		{
			ForumAccountService forumAccountService = new ForumAccountService();
			var forumAccountName = forumAccountService.GetForumAccountName((int)Authentication.ForumAccountID);

			
			// 顯示要留言人資訊
			labelCommentRoleID.Text = Authentication.ForumAccountID.ToString();
			labelCommentRoleID.Visible = false; //介面不顯示編號
			labelCommentRole.Text = $"({Authentication.ForumAccountID.ToString()}) {forumAccountName}";
		}
	}
}
