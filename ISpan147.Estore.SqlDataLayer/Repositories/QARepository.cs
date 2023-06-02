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
using static ISpan147.Estore.SqlDataLayer.Dtos.QADto;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class QARepository
	{
		public QADto.Theme GetTheme(int id)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $@"SELECT ForumAccountName, ThemeContext, ThemeDateTime FROM Themes AS T JOIN ForumAccounts AS F 
                            ON T.ForumAccountID = F.ForumAccountID WHERE ThemeID ={id}";
			Func<SqlDataReader, QADto.Theme> assember = Assembler.ThemeDtoAssembler;

			return SqlDb.Get(connGetter, sql, assember);
		}

		public List<QADto.Theme> SearchTheme(string themeContext = null)
		{
			
			string sql = @" SELECT ForumAccountName , ThemeContext , ThemeDateTime FROM THEMES AS T JOIN ForumAccounts AS F 
                            ON T.ForumAccountID = F.ForumAccountID ";

			var parameterBuilder = new SqlParameterBuilder();

			string where = "";

			if (!string.IsNullOrEmpty(themeContext))
			{
				where += " WHERE ThemeContext LIKE @keyword ORDER BY ThemeID";
				parameterBuilder.AddNVarchar("keyword", 2, themeContext);                //模糊比對??
			}
			if (where != "")
			{
				where = " WHERE " + where.Substring(5);
				sql += where;
			}
			var parameters = parameterBuilder.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, QADto.Theme> assembler = Assembler.ThemeDtoAssembler;
			return SqlDb.Search(connGetter, sql, assembler, parameters).ToList();
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

			var parameters = new SqlParameterBuilder()
				.AddInt("@themeId", themeId)
				.Build();
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}


		public QADto.Comment GetComment(int id)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $@"SELECT ForumAccountName , CommentContext , CommentTime 
							FROM Comments AS C JOIN ForumAccounts AS F ON C.ForumAccountID = F.ForumAccountID 
							WHERE CommentID = {id}";
			Func<SqlDataReader, QADto.Comment> assember = Assembler.CommentDtoAssembler;

			return SqlDb.Get(connGetter, sql, assember);
		}

		public List<QADto.Comment> SearchComment(string commentContext = null)
		{

			string sql = @" SELECT ForumAccountName, CommentContext, CommentTime
							FROM Comments AS C JOIN ForumAccounts AS F ON C.ForumAccountID = F.ForumAccountID";
			
			var parameterBuilder = new SqlParameterBuilder();

			string where = "";

			if (!string.IsNullOrEmpty(commentContext))
			{
				where += " WHERE CommentContext LIKE @keyword ORDER BY CommentID";
				parameterBuilder.AddNVarchar("keyword", 2, commentContext);                //模糊比對??
			}
			if (where != "")
			{
				where = " WHERE " + where.Substring(5);
				sql += where;
			}
			var parameters = parameterBuilder.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, QADto.Comment> assembler = Assembler.CommentDtoAssembler;
			return SqlDb.Search(connGetter, sql, assembler, parameters).ToList();
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

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			return SqlDb.Create(connGetter, sql, parameters);
		}

		public int DeleteComment(int themeId)
		{
			string sql = " DELETE FROM Comments WHERE THEMEID = @THEMEID ";
			
			var parameters = new SqlParameterBuilder()
				.AddInt("@THEMEID", themeId)
				.Build();
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}
	}
}
