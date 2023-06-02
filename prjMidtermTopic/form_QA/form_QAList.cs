using ISpan147.Estore.SqlDataLayer.Repositories;
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
using System.Xml.Linq;
using static ISpan147.Estore.SqlDataLayer.Dtos.QADto;

namespace prjMidtermTopic
{
    public partial class form_QAList : Form
    {
		List<Theme> _data;
		//private List<SqlParameter> _parameters = new List<SqlParameter>();
		public form_QAList()
		{
            InitializeComponent();
        }

		private void form_QAList_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
			//var keyword = $"%{textBoxSearch.Text}%";

			//string cmdStr = $" SELECT * FROM THEMES WHERE THEMECONTEXT LIKE @keyword ORDER BY THEMEID";

			//string connStr = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
			////connStr = @"data source =.\SQLEXPRESS; initial catalog = ISpan147MidTopic; User Id = sa6; Password = sa6; integrated security = True; MultipleActiveResultSets = True;";
			//SqlConnection conn = new SqlConnection(connStr);
			//conn.Open();
			//List<SqlParameter> parameters = new List<SqlParameter>();

			//parameters.Add(new SqlParameter("@keyword", SqlDbType.NVarChar)
			//{
			//	Value = keyword,
			//	Direction = ParameterDirection.Input
			//});

			//SqlCommand cmd = conn.CreateCommand();
			//cmd.CommandText = cmdStr;
			//cmd.Parameters.AddRange(parameters.ToArray());
			//var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

			//// 將撈取的資料放入dataGridView
			//List<Theme> result = new List<Theme>();
			//while (reader.Read() == true)
			//{
			//	int id = Convert.ToInt32(reader["ThemeId"]);
			//	string context = reader["ThemeContext"].ToString();
			//	DateTime createDateTime = Convert.ToDateTime(reader["ThemeDateTime"]);

			//	var dto = new Theme
			//	{
			//		ThemeId = id,
			//		ThemeContext = context.Length > 15 ? context.Substring(0, 15) + "..." : context,
			//		ThemeDateTime = createDateTime
			//	};
			//	result.Add(dto);
			//}
			//dataGridView1.DataSource = result;
			//this.dataGridView1.Columns["MemberId"].Visible = false;
			//this.dataGridView1.Columns["MemberName"].Visible = false;
			//conn.Close();
			//conn.Dispose();

		}


		private void Display()
		{
			string keyword = this.textBoxSearch.Text;

			// 叫用Search(),取得符合的記錄
			var repo = new QARepository();
			_data = repo.SearchTheme(keyword);

			// 繫結到DataGridView
			this.dataGridView1.DataSource = _data;
		}


		

		//methods
		
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			var themeId = this._data[e.RowIndex].ThemeId;
			var selectedThemeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["themeId"].Value);


			var frm = new Form_ThemeCommemt(themeId);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void buttonCreateTheme_Click_1(object sender, EventArgs e)
		{
			from_ThemeCreate qaCreate = new from_ThemeCreate();
			qaCreate.Owner = this;
			qaCreate.ShowDialog();
		}










	}
}
