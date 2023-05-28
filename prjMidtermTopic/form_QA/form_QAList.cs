using prjMidtermTopic.form_QA;
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

namespace prjMidtermTopic
{
    public partial class form_QAList : Form
    {
        public form_QAList()
        {
            InitializeComponent();
        }


		private void buttonCreateTheme_Click_1(object sender, EventArgs e)
		{
            from_QACreate qaCreate = new from_QACreate();
            qaCreate.ShowDialog();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			{
				var keyword = $"%{textBoxSearch.Text}%";

				string cmdStr = $" SELECT * FROM THEMES WHERE THEMECONTEXT LIKE @keyword ORDER BY THEMEID";

				string connStr = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
				//connStr = @"data source =.\SQLEXPRESS; initial catalog = ISpan147MidTopic; User Id = sa6; Password = sa6; integrated security = True; MultipleActiveResultSets = True;";
				SqlConnection conn = new SqlConnection(connStr);
				conn.Open();
				List<SqlParameter> parameters = new List<SqlParameter>();

				parameters.Add(new SqlParameter("@keyword", SqlDbType.NVarChar)
				{
					Value = keyword,
					Direction = ParameterDirection.Input
				});

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = cmdStr;
				cmd.Parameters.AddRange(parameters.ToArray());
				var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

				// 將撈取的資料放入dataGridView
				List<Theme> result = new List<Theme>();
				while (reader.Read() == true)
				{
					int id = Convert.ToInt32(reader["ThemeId"]);
					string context = reader["ThemeContext"].ToString();
					DateTime createDateTime = Convert.ToDateTime(reader["ThemeDateTime"]);

					var dto = new Theme
					{
						ThemeId = id,
						ThemeContext = context.Length > 15 ? context.Substring(0, 15) + "..." : context,
						ThemeDateTime = createDateTime
					};
					result.Add(dto);
				}
				dataGridView1.DataSource = result;
				this.dataGridView1.Columns["MemberId"].Visible = false;
				this.dataGridView1.Columns["MemberName"].Visible = false;
				conn.Close();
				conn.Dispose();
			}
		}
	}
}
