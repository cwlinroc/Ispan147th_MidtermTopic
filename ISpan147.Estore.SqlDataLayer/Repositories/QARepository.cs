using ISpan147.Estore.SqlDataLayer.Builders;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ISpan147.Estore.SqlDataLayer.Dtos.QADto;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class QARepository
	{
		/// <summary>
		/// 取得特定ID的主題
		/// </summary>
		/// <param name="themeid">主題ID</param>
		/// <returns></returns>
		public List<QADto.Theme> GetTheme(int? themeId = null)
		{
			StringBuilder sql = new StringBuilder();
			sql.AppendLine("SELECT ThemeID, ThemeContext, ThemeDateTime ");
			sql.AppendLine("FROM Themes AS T ");
			sql.AppendLine("JOIN ForumAccounts AS F ON T.ForumAccountID = F.ForumAccountID ");
			sql.AppendLine("WHERE 1 = 1 ");

			var parameter = new SqlParameterBuilder();
			if (themeId.HasValue)
			{
				sql.AppendLine("AND ThemeID = @ThemeID ");
				parameter.AddInt("ThemeID", themeId.Value);
			}
			var parameters = parameter.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, QADto.Theme> func = Assembler.ThemeDtoAssembler;

			return SqlDb.Search(connGetter, sql.ToString(), func, parameters).ToList();
		}


		public List<QADto.Theme> SearchTheme(string themeContext = null)
		{
			StringBuilder sql = new StringBuilder();
			sql.AppendLine("SELECT ThemeID, ThemeContext, ThemeDateTime ");
			sql.AppendLine("FROM THEMES AS T ");
			sql.AppendLine("JOIN ForumAccounts AS F ON T.ForumAccountID = F.ForumAccountID ");
			sql.AppendLine("WHERE 1 = 1 ");
	
			var parameter = new SqlParameterBuilder();
			if (!string.IsNullOrEmpty(themeContext))
			{
				themeContext = $"%{themeContext}%";
				sql.AppendLine("AND ThemeContext LIKE @keyword ");
				parameter.AddNVarchar("keyword", 500, themeContext);
			}
			sql.AppendLine("ORDER BY ThemeID ");
			var parameters = parameter.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, QADto.Theme> func = Assembler.ThemeDtoAssembler;

			return SqlDb.Search(connGetter, sql.ToString(), func, parameters).ToList();
		}

		public int CreateTheme(QADto.Theme themeDto)
		{
			StringBuilder sql = new StringBuilder();
			sql.AppendLine("INSERT INTO Themes(ForumAccountID, ThemeDateTime, ThemeContext) ");
			sql.AppendLine("VALUES (@ForumAccountID, @ThemeDateTime, @ThemeContext) ");
		
			var parameter = new SqlParameterBuilder()
				.AddInt("ForumAccountID", themeDto.ForumAccountId)
				.AddDateTime("ThemeDateTime", themeDto.ThemeDateTime)
				.AddNVarchar("ThemeContext", 500, themeDto.ThemeContext)
				.Build();
		
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			return SqlDb.Create(connGetter, sql.ToString(), parameter);
		}

		public int DeleteTheme(int themeId)
		{
			StringBuilder sql = new StringBuilder();
			sql.AppendLine("DELETE FROM Comments WHERE ThemeID = @themeId ");
			sql.AppendLine("DELETE FROM Themes WHERE ThemeID = @themeId ");

			SqlParameter parameter = new SqlParameter("@themeId", SqlDbType.Int) { Value = themeId };
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			return SqlDb.UpdateOrDelete(connGetter, sql.ToString(), parameter);
		}


		public QADto.Comment GetComment(int? themeId = null)     //顯示ThemeID = dataGridViewTheme_CellClick的
		{
			
			StringBuilder sql = new StringBuilder();
			sql.AppendLine("SELECT ThemeID , CommentContext , CommentTime ");
			sql.AppendLine("FROM Comments AS C ");
			sql.AppendLine("JOIN ForumAccounts AS F ON C.ForumAccountID = F.ForumAccountID ");
			sql.AppendLine("WHERE 1 = 1 ");

			var parameter = new SqlParameterBuilder();
			if (themeId.HasValue)
			{
				sql.AppendLine("AND ThemeID = @ThemeID ");
				parameter.AddInt("ThemeID", themeId.Value);
			}
			var parameters = parameter.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, QADto.Comment> func = Assembler.CommentDtoAssembler;
					
			return SqlDb.Search(connGetter, sql.ToString(), func, parameters).ToList();
		}

		public List<QADto.Comment> SearchComment(string commentContext = null)
		{
			StringBuilder sql = new StringBuilder();
			sql.AppendLine("SELECT CommentID, CommentContext, CommentTime ");
			sql.AppendLine("FROM Comments AS C ");
			sql.AppendLine("JOIN ForumAccounts AS F ON C.ForumAccountID = F.ForumAccountID");
			sql.AppendLine("WHERE 1 = 1 ");

			var parameter = new SqlParameterBuilder();			
			if (!string.IsNullOrEmpty(commentContext))
			{
				commentContext = $"%{commentContext}%";
				sql.AppendLine("AND CommentContext LIKE @keyword ");
				parameter.AddNVarchar("keyword", 500, commentContext);                
			}
			sql.AppendLine("ORDER BY CommentID ");
			var parameters = parameter.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, QADto.Comment> func = Assembler.CommentDtoAssembler;
			return SqlDb.Search(connGetter, sql.ToString(), func, parameters).ToList();
		}

		public int CreateComment(QADto.Comment commentDto)
		{
			StringBuilder sql = new StringBuilder();
			sql.AppendLine("INSERT INTO Comments(ForumAccountID, CommentTime, CommentContext, ThemeID) ");
			sql.AppendLine("VALUES ( @ForumAccountID, @CommentTime, @CommentContext, @ThemeID) ");
			
			var parameters = new SqlParameterBuilder()
				.AddInt("ForumAccountID", commentDto.ForumAccountId)
				.AddDateTime("CommentTime", commentDto.CommentDateTime)
				.AddNVarchar("CommentContext", 500, commentDto.CommentContext)
				.AddInt("ThemeID", commentDto.ThemeId)
				.Build();

			return SqlDb.Create(SqlDb.GetConnection, sql.ToString(), parameters);
		}

		public int DeleteComment(int themeId)
		{
			string sql = " DELETE FROM Comments WHERE THEMEID = @THEMEID ";

			SqlParameter parameter = new SqlParameter("@themeId", SqlDbType.Int) { Value = themeId };
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			return SqlDb.UpdateOrDelete(connGetter, sql, parameter);
		}
	}
}
