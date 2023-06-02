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
		private readonly int _themeId;
		public from_CommentCreate()
		{
			InitializeComponent();
		}
		public from_CommentCreate(int themeId)
		{
			_themeId = themeId;
		}

		private void buttonConfirmComment_Click(object sender, EventArgs e)
		{
			string comment = richTextBoxComment.Text;
			var vm = new QAVM { CommentContext = comment };

			//// 驗證vm是否通過欄位驗證規則
			//(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			////如果有錯, 就顯示它
			//if (validationResult.isValid == false)
			//{
			//	this.errorProvider1.Clear();
			//	DisplayErrors(validationResult.errors);
			//	return;
			//}

			//// 如果通過, 將vm轉型為CategoryDto
			//CategoryDto dto = new CategoryDto { Id = vm.Id, Name = vm.Name, DisplayOrder = vm.DisplayOrder };

			////以下,就全部接軌了


			try
			{
				var themeData = _themeId;
				string userName = "測試者";
				


				string connStr = ConfigurationManager.ConnectionStrings["ISpan147"].ConnectionString;
				SqlConnection conn = new SqlConnection(connStr);
				conn.Open();

				string cmdstr = @" INSERT INTO COMMENTS ( CommentName, CommentTime, CommentContext, ThemeID )  
							   VALUES (@CommentName, @CommentTime ,@CommentContext ,@ThemeID) ";   // ThemeID 未代入

				List<SqlParameter> parameters = new List<SqlParameter>();
				parameters.Add(new SqlParameter("@CommentName", SqlDbType.NChar)
				{
					Value = userName,
					Direction = ParameterDirection.Input
				});
				parameters.Add(new SqlParameter("@CommentTime", SqlDbType.DateTime)
				{
					Value = DateTime.Now,
					Direction = ParameterDirection.Input
				});
				parameters.Add(new SqlParameter("@CommentContext", SqlDbType.NVarChar, size: 500)
				{
					Value = comment,
					Direction = ParameterDirection.Input
				});
				parameters.Add(new SqlParameter("@ThemeID", SqlDbType.Int)
				{
					Value = themeData,
					Direction = ParameterDirection.Input
				});

				SqlCommand cmd = new SqlCommand(cmdstr, conn);
				cmd.Parameters.AddRange(parameters.ToArray());
				cmd.ExecuteNonQuery();

				conn.Close();
				conn.Dispose();

				MessageBox.Show("回覆成功");
				this.Close();
			}
			catch (Exception ex)
			{
				throw new Exception("連顯失敗" + ex);
			}
		}
	}
}
