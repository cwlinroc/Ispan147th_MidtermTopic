using ISpan147.Estore.SqlDataLayer.Builders;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class CategoryRepository
	{
		public CategoryDto GetByCategoryID(int categoryId)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Categories WHERE CategoryId = {categoryId}";
			Func<SqlDataReader, CategoryDto> assembler = Assembler.CategoryDtoAssembler;
			SqlParameter[] parameters = new SqlParameter[0];

			return SqlDb.Get(connGetter, sql, assembler);
		}

		public CategoryDto GetByCategoryName(string categoryname)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Categories WHERE CategoryName = @CategoryName";
			Func<SqlDataReader, CategoryDto> assembler = Assembler.CategoryDtoAssembler;
			SqlParameter parameters = new SqlParameter("@CategoryName", SqlDbType.NVarChar, 30) { Value = categoryname };

			return SqlDb.Get(connGetter, sql, assembler, parameters);
		}

		public List<CategoryDto> Search(int? categoryId, string s_name)
		{
			#region sql & SqlParameter[]

			string sql = $"SELECT * FROM Categories ";

			var builder = new SqlParameterBuilder();

			string where = "";
			if (categoryId.HasValue)
			{
				where += $" AND CategoryID = @CategoryID";
				builder.AddInt("@CategoryID", categoryId.Value);
			}
			if (string.IsNullOrEmpty(s_name) == false)
			{
				where += $" AND CategoryName LIKE '%' + @CategoryName + '%'";
				builder.AddNVarchar("@CategoryName", 30, s_name);
			}
			if (string.IsNullOrEmpty(where) == false)
			{
				where = " WHERE " + where.Substring(5);
				sql += where;
			}

			SqlParameter[] parameters = builder.Build();
			#endregion
			Func<SqlDataReader, CategoryDto> func = Assembler.CategoryDtoAssembler;
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Search(connGetter, sql, func, parameters.ToArray()).ToList();
		}

		public int Update(CategoryDto dto)
		{
			string sql = @"UPDATE Categories 
                            SET CategoryName = @CategoryName
                            WHERE CategoryId = @CategoryId";

			var parameters = new SqlParameterBuilder()
				.AddInt("@CategoryId", dto.CategoryId)
				.AddNVarchar("@CategoryName", 30, dto.CategoryName)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}

		public int Create(CategoryDto dto)
		{
			string sql = @"INSERT INTO Categories       
                            (CategoryName)
                            Values
                            (@CategoryName)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("@CategoryName", 30, dto.CategoryName)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Create(connGetter, sql, parameters);
		}

		public int Delete(int categoryId)
		{
			string sql = @"DELETE FROM Categories
                            WHERE CategoryId = @CategoryId";

			SqlParameter parameter = new SqlParameter("@CategoryId", SqlDbType.Int) { Value = categoryId };

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameter);
		}
	}
}
