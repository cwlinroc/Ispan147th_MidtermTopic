using ISpan147.Estore.SqlDataLayer.Builders;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class QARepository
	{
		public QADto.Theme GetTheme(int themeid)
		{
			string sql = $@"SELECT ForumAccountName, ThemeContext, ThemeDateTime FROM Themes AS T JOIN ForumAccounts AS F 
                            ON T.ForumAccountID = F.ForumAccountID WHERE ThemeID ={themeid}";
			Func<SqlDataReader, QADto.Theme> func = Assembler.ThemeDtoAssembler;
			//SqlParameter[] parameters = new SqlParameter[0];
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Get(connGetter, sql, func);
		}

		public List<QADto.Theme> SearchTheme(string themeContext = null)
		{
			
			string sql = @" SELECT ForumAccountName , ThemeContext , ThemeDateTime FROM THEMES AS T JOIN ForumAccounts AS F 
                            ON T.ForumAccountID = F.ForumAccountID ";

			var builder = new SqlParameterBuilder();

			string where = "";

			if (!string.IsNullOrEmpty(themeContext))
			{
				where += $" ThemeContext LIKE '%' + @keyword + '%'";
				builder.AddNVarchar("keyword", 2, themeContext);                
			}
			if (where != "")
			{
				where = " WHERE " + where.Substring(5);
				sql += where;
			}
			var parameters = builder.Build();
			sql += "  ORDER BY ThemeID";

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, QADto.Theme> func = Assembler.ThemeDtoAssembler;
			return SqlDb.Search(connGetter, sql, func, parameters).ToList();
		}

		public int CreateTheme(QADto.Theme themeDto)
		{
			string sql = @" INSERT INTO Themes(ForumAccountID, ThemeDateTime, ThemeContext)  
							VALUES (@ForumAccountID, @ThemeDateTime, @ThemeContext) ";

			var parameters = new SqlParameterBuilder()
				.AddInt("ForumAccountID",themeDto.UserId)
				.AddDateTime("ThemeDateTime", themeDto.ThemeDateTime)
				.AddNVarchar("ThemeContext", 500, themeDto.ThemeContext)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			return SqlDb.Create(connGetter, sql, parameters);
		}

		public int DeleteTheme(int themeId)
		{
			string sql = @" DELETE FROM Comments WHERE ThemeID = @themeId 
							DELETE FROM Themes WHERE ThemeID = @themeId ";

			SqlParameter parameter = new SqlParameter("@themeId", SqlDbType.Int) { Value = themeId };
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			return SqlDb.UpdateOrDelete(connGetter, sql, parameter);
		}


		public QADto.Comment GetComment(int id)
		{
			string sql = $@"SELECT ForumAccountName , CommentContext , CommentTime 
							FROM Comments AS C JOIN ForumAccounts AS F ON C.ForumAccountID = F.ForumAccountID 
							WHERE CommentID = {id}";
			Func<SqlDataReader, QADto.Comment> func = Assembler.CommentDtoAssembler;
			//SqlParameter[] parameters = new SqlParameter[0];
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			return SqlDb.Get(connGetter, sql, func);
		}

		public List<QADto.Comment> SearchComment(string commentContext = null)
		{

			string sql = @" SELECT ForumAccountName, CommentContext, CommentTime
							FROM Comments AS C JOIN ForumAccounts AS F ON C.ForumAccountID = F.ForumAccountID";
			
			var builder = new SqlParameterBuilder();

			string where = "";

			if (!string.IsNullOrEmpty(commentContext))
			{
				where += " WHERE CommentContext LIKE '%' + @keyword + '%'";
				builder.AddNVarchar("keyword", 2, commentContext);                //模糊比對??
			}
			if (where != "")
			{
				where = " WHERE " + where.Substring(5);
				sql += where;
			}
			var parameters = builder.Build();
			sql += "ORDER BY CommentID";

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, QADto.Comment> func = Assembler.CommentDtoAssembler;
			return SqlDb.Search(connGetter, sql, func, parameters).ToList();
		}

		public int CreateComment(QADto.Comment commentDto)
		{
			string sql = @" INSERT INTO Comments(ForumAccountID, CommentTime, CommentContext, ThemeID) 
							VALUES ( @ForumAccountID, @CommentTime, @CommentContext, @ThemeID) ";
			
			var parameters = new SqlParameterBuilder()
				.AddInt("ForumAccountID", commentDto.UserId)
				.AddDateTime("CommentTime", commentDto.CommentDateTime)
				.AddNVarchar("CommentContext", 500, commentDto.CommentContext)
				.AddInt("ThemeID", commentDto.ThemeId)
				.Build();
			
			return SqlDb.Create(SqlDb.GetConnection, sql, parameters);
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
