using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Services;
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
using static ISpan147.Estore.SqlDataLayer.Dtos.QADto;

namespace prjMidtermTopic.form_QA
{
	public partial class Form_ThemeCommemt : Form
	{
		private readonly int _themeId;
		QAService _service;
		public Form_ThemeCommemt(int themeId)
		{
			InitializeComponent();
			_themeId = themeId;
			_service = new QAService();
		}

		private void Form_ThemeCommemt_Load(object sender, EventArgs e)
		{
			var dto = new QADto.Theme();

			string sql = $"SELECT * FROM THEMES WHERE THEMEID={_themeId}";

			string connStr = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
			SqlConnection conn = new SqlConnection(connStr);
			conn.Open();

			SqlCommand cmd = new SqlCommand(sql, conn);
			SqlDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				int id = Convert.ToInt32(reader["ThemeId"]);
				string context = reader["Themecontext"].ToString();
				DateTime themeDateTime = Convert.ToDateTime(reader["themeDateTime"]);

				labelThemeRole.Text = "111";
				labelThemeDatetime.Text = themeDateTime.ToString();
				richTextBoxTheme.Text = context;
			}
		}

		private void buttonDeleteTheme_Click(object sender, EventArgs e)
		{
			string cmdStr = $" DELETE FROM THEMES WHERE THEMEID = @THEMEID ";

			string connStr = ConfigurationManager.ConnectionStrings["ISpan147"].ConnectionString;
			SqlConnection conn = new SqlConnection(connStr);
			conn.Open();


			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@THEMEID", SqlDbType.Int)
			{
				Value = _themeId,
				Direction = ParameterDirection.Input,
			});

			SqlCommand cmd = new SqlCommand(cmdStr, conn);
			cmd.Parameters.AddRange(parameters.ToArray());
			cmd.ExecuteNonQuery();
			conn.Close();
			conn.Dispose();
			richTextBoxTheme.Clear();
			MessageBox.Show("刪除成功");
		}

		private void buttonCreateCommon_Click(object sender, EventArgs e)
		{
			from_CommentCreate commentCreate = new from_CommentCreate(1);
			commentCreate.ShowDialog();
		}

		private void dataGridViewComment_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Display()
		{
			// 叫用Search(),取得符合的記錄
			var data = _service.GetCommentList(null);
			// 繫結到DataGridView
			DataGridViewCommentShow(data);
		}

		private void DataGridViewCommentShow(List<Comment> data)
		{
			this.dataGridViewComment.DataSource = data;
			this.dataGridViewComment.Columns["ForumAccountId"].Visible = false;
			this.dataGridViewComment.Columns["ForumAccountName"].Visible = false;
		}
	}
}
