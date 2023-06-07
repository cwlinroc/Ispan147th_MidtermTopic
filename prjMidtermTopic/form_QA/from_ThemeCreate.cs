using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	public partial class from_ThemeCreate : Form
	{
		QAService _service;
		public from_ThemeCreate()
		{
			InitializeComponent();
			_service = new QAService();
		}
		private void buttonConfirmTheme_Click(object sender, EventArgs e)
		{
			QADto.Theme themeDto = new QADto.Theme();
			themeDto.ForumAccountId = Convert.ToInt32(labelThemeRoleID.Text);
			themeDto.ForumAccountName = labelThemeRole.Text;
			themeDto.ThemeContext = richTextBoxTheme.Text;
			themeDto.ThemeDateTime = DateTime.Now;

			var result = _service.CreateTheme(themeDto);

			MessageBox.Show(result);
			IGrid parent = this.Owner as IGrid;
			parent.Display();
			this.Close();
		}

		private void from_ThemeCreate_Load(object sender, EventArgs e)
		{
			ForumAccountService forumAccountService = new ForumAccountService();
			var forumAccountName = forumAccountService.GetForumAccountName((int)Authentication.ForumAccountID);

			// 顯示要留言人資訊
			labelThemeRoleID.Text = Authentication.ForumAccountID.ToString();
			labelThemeRoleID.Visible = false;
			labelThemeRole.Text = $"({Authentication.ForumAccountID.ToString()}) {forumAccountName}";
		}
	}
}
