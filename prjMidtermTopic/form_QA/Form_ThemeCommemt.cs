using ISpan147.Estore.SqlDataLayer.Dtos;
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
	public partial class Form_ThemeCommemt : Form
	{
		private readonly int _themeId;
		public Form_ThemeCommemt(int themeId)
		{
			_themeId = themeId;
			InitializeComponent();
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
			Form_ThemeCommemt commentCreate = new Form_ThemeCommemt(1);
			commentCreate.ShowDialog();
		}
	}
}
