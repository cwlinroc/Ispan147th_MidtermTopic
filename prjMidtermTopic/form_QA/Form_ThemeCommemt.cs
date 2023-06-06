using ISpan147.Estore.SqlDataLayer;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.ExtMethods;
using ISpan147.Estore.SqlDataLayer.Repositories;
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
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ISpan147.Estore.SqlDataLayer.Dtos.QADto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjMidtermTopic.form_QA
{
	public partial class Form_ThemeCommemt : Form//,IGrid
	{
		private  int _themeId;
		QAService _service;
		public Form_ThemeCommemt(int themeId)
		{
			InitializeComponent();
			_themeId = themeId;
			_service = new QAService();
		}
		private void Form_ThemeCommemt_Load(object sender, EventArgs e)
		{
			Display();
			string sql = $"SELECT * FROM COMMENTS WHERE THEMEID={_themeId}";
			Func<SqlDataReader, QADto.Theme> func = (reader) =>
			new QADto.Theme
			{
				ForumAccountName = "留言測試者",
				ThemeDateTime = reader.GetDateTime(reader.GetOrdinal("ThemeDateTime")),
				ThemeContext = reader.GetString(reader.GetOrdinal("ThemeContext"))
			};
			
			List<QADto.Theme> themes = _service.GetThemeList(_themeId);
			if (themes.Count > 0)
			{
				QADto.Theme theme = themes[0];
				labelThemeRole.Text = theme.ForumAccountName;
				labelThemeDatetime.Text = theme.ThemeDateTime.ToString();
				richTextBoxTheme.Text = theme.ThemeContext;
			}
		}

		private void buttonDeleteTheme_Click(object sender, EventArgs e)
		{
			var repo = new QARepository();
			repo.DeleteTheme(_themeId);

			richTextBoxTheme.Clear();
			MessageBox.Show("刪除成功");

			//IGrid parent = this.Owner as IGrid;
			//parent.
			Display();
			
		}

		private void buttonCreateCommon_Click(object sender, EventArgs e)
		{
			from_CommentCreate commentCreate = new from_CommentCreate(_themeId);
			commentCreate.ShowDialog();
		}

		public void Display()
		{
			// 叫用Search(),取得符合的記錄
			var data = _service.GetCommentList(_themeId);
			// 繫結到DataGridView
			DataGridViewCommentShow(data);
		}

		private void DataGridViewCommentShow(List<Comment> data)
		{			
			this.dataGridViewComment.DataSource = data;
			this.dataGridViewComment.Columns["ThemeId"].Visible = false;
			this.dataGridViewComment.Columns["ForumAccountId"].Visible = false;
			this.dataGridViewComment.Columns["ForumAccountName"].Visible = false;
		}
	}
}
