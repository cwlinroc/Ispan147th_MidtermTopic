using ISpan147.Estore.SqlDataLayer;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.ExtMethods;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
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
	public partial class Form_ThemeCommemt : Form, IGridComment
	{
		private  int _themeId;
		private int _commentId;
		QAService _service;
		public Form_ThemeCommemt(int themeId)
		{
			InitializeComponent();
			_themeId = themeId;
			_service = new QAService();

			Modifier.ModGridView(dataGridViewComment);
		}
		private void Form_ThemeCommemt_Load(object sender, EventArgs e)
		{
			CommentDisplay();
			Func<SqlDataReader, QADto.Theme> func = (reader) =>
			new QADto.Theme
			{
				ForumAccountName = reader.GetString(reader.GetOrdinal("ForumAccountName")),
				ThemeDateTime = reader.GetDateTime(reader.GetOrdinal("ThemeDateTime")),
				ThemeContext = reader.GetString(reader.GetOrdinal("ThemeContext"))
			};
			
			List<QADto.Theme> themes = _service.GetThemeList(_themeId);
			if (themes.Count > 0)
			{
				QADto.Theme theme = themes[0];
				labelThemeRole.Text = $"發言者：{theme.ForumAccountName}";
				labelThemeDatetime.Text = theme.ThemeDateTime.ToString();
				richTextBoxTheme.Text = theme.ThemeContext;
			}
			//labelThemeRole.Text = $"({Authentication.ForumAccountID.ToString()}) {forumAccountName}";

			if (Authentication.Permission > 3)
			{
				buttonDeleteTheme.Enabled = false;
			}
		}

		private void buttonDeleteTheme_Click(object sender, EventArgs e)
		{
			var repo = new QARepository();
			repo.DeleteTheme(_themeId);

			richTextBoxTheme.Clear();
			MessageBox.Show("刪除成功");

			IGrid parent = this.Owner as IGrid;
			parent.Display();
			this.Close();
		}
		private void buttonCreateCommon_Click(object sender, EventArgs e)
		{
			from_CommentCreate commentCreate = new from_CommentCreate(_themeId);
			commentCreate.Owner = this;
			commentCreate.ShowDialog();
		}

		public void CommentDisplay()
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

		private List<Comment> selectedComments = new List<Comment>();
		private void dataGridViewComment_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewComment.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
			{
				DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridViewComment.Rows[e.RowIndex].Cells[e.ColumnIndex];

				var data = _service.GetCommentList(_commentId);
				// 判斷 CheckBox 狀態
				if (checkBoxCell.Value == null || (bool)checkBoxCell.Value == false)
				{
					checkBoxCell.Value = true;
					
					
					// 獲取勾選資料
					//Comment selectedComment = data[e.RowIndex];
					Comment selectedComment = dataGridViewComment.Rows[e.RowIndex].DataBoundItem as Comment;
					selectedComments.Add(selectedComment);
				}
				else
				{
					checkBoxCell.Value = false;
					Comment deselectedComment = dataGridViewComment.Rows[e.RowIndex].DataBoundItem as Comment;
					selectedComments.Remove(deselectedComment);
				}
			}


		}

		private void buttonDeleteComment_Click(object sender, EventArgs e)
		{
			//var commentId = selectComments.SelectedValue;
			//var repo = new QARepository();
			//repo.DeleteComment(selectComment);


			IGridComment parent = this as IGridComment;
			parent.CommentDisplay();
			MessageBox.Show("刪除成功");
		}
	}
}
