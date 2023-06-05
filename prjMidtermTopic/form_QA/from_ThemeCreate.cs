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
		public from_ThemeCreate()
		{
			InitializeComponent();
		}

		private void buttonConfirmTheme_Click(object sender, EventArgs e)
		{
			try
			{
				var forumAccountId = 01; 
				var theme = richTextBoxTheme.Text;
				string connStringHome = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
				

				string cmdStr3 = @" INSERT INTO THEMES (THEMENAME, THEMEDATETIME, THEMECONTEXT)  
                              VALUES (@THEMENAME, @THEMEDATETIME, @THEMECONTEXT) ";

				SqlConnection conn = new SqlConnection(connStringHome);  //連線資訊
				conn.Open();  //開啟
				List<SqlParameter> parameters = new List<SqlParameter>();

				parameters.Add(new SqlParameter("@THEMENAME", SqlDbType.NVarChar)
				{
					Value = forumAccountId,
					Direction = ParameterDirection.Input
				});
				parameters.Add(new SqlParameter("@THEMEDATETIME", SqlDbType.DateTime)
				{
					Value = DateTime.Now,
					Direction = ParameterDirection.Input
				});
				parameters.Add(new SqlParameter("@THEMECONTEXT", SqlDbType.NVarChar, size: 500)
				{
					Value = theme,
					Direction = ParameterDirection.Input

				});

				SqlCommand cmd = conn.CreateCommand();
				cmd.Parameters.AddRange(parameters.ToArray());
				cmd.CommandText = cmdStr3;
				cmd.ExecuteNonQuery(); //執行不查詢
									   // cmd.ExecuteReader(); 查詢使用
				conn.Close();
				conn.Dispose();
				MessageBox.Show("新增成功");
				this.Close();
			}
			catch (Exception ex)
			{
				throw new Exception("連線失敗" + ex);
			}

		}
	}
}
