using ISpan147.Estore.SqlDataLayer.Builders;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class MerchandiseRepository : IMerchandiseRepository
	{
		/// 透過字串組成SQL語法，取得商品分類記錄
		public MerchandiseDto GetByMerchandiseID(int merchandiseId)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Merchandises WHERE MerchandiseId = {merchandiseId}";
			Func<SqlDataReader, MerchandiseDto> assembler = Assembler.MerchandiseDtoAssembler;
			SqlParameter[] parameters = new SqlParameter[0];

			return SqlDb.Get(connGetter, sql, assembler);
		}

		public MerchandiseDto GetByMerchandiseName(string merchandisename)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Merchandises WHERE MerchandiseName = @MerchandiseName";
			Func<SqlDataReader, MerchandiseDto> assembler = Assembler.MerchandiseDtoAssembler;
			SqlParameter parameters = new SqlParameter("@MerchandiseName", SqlDbType.NVarChar, 30) { Value = merchandisename };

			return SqlDb.Get(connGetter, sql, assembler, parameters);
		}

		public MerchandiseDto GetByCategoryID(int? categoryId)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Merchandises WHERE CategoryId = {categoryId}";
			Func<SqlDataReader, MerchandiseDto> assembler = Assembler.MerchandiseDtoAssembler;
			SqlParameter[] parameters = new SqlParameter[0];

			return SqlDb.Get(connGetter, sql, assembler);
		}

		public List<MerchandiseSearchDto> Search(int? merchandiseId, string s_name, int? s_categoryid)
		{
			#region sql & SqlParameter[]

			string sql = $"SELECT * FROM Merchandises AS m JOIN Categories AS c ON m.CategoryID = c.CategoryID ";

			var builder = new SqlParameterBuilder();

			string where = "";
			if (merchandiseId.HasValue)
			{
				where += $" AND MerchandiseID = @MerchandiseID";
				builder.AddInt("@MerchandiseID", merchandiseId.Value);
			}
			if (string.IsNullOrEmpty(s_name) == false)
			{
				where += $" AND MerchandiseName LIKE '%' + @MerchandiseName + '%'";
				builder.AddNVarchar("@MerchandiseName", 30, s_name);
			}
			if (s_categoryid > 0)
			{
				where += $" AND m.CategoryID = @CategoryID";
				builder.AddInt("@CategoryID", s_categoryid.Value);
			}
			if (string.IsNullOrEmpty(where) == false)
			{
				where = " WHERE " + where.Substring(5);
				sql += where;
			}

			SqlParameter[] parameters = builder.Build();
			#endregion
			Func<SqlDataReader, MerchandiseSearchDto> func = Assembler.MerchandiseSearchDtoAssembler;
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Search(connGetter, sql, func, parameters.ToArray()).ToList();
		}

		public int Update(MerchandiseDto dto)
		{
			string sql = @"UPDATE Merchandises 
                            SET MerchandiseName = @MerchandiseName,
							CategoryId = @CategoryId, Price = @Price, Amount = @Amount, 
							Description = @Description, ImageURL = @ImageURL
                            WHERE MerchandiseId = @MerchandiseId";

			var parameters = new SqlParameterBuilder()
				.AddInt("@MerchandiseId", dto.MerchandiseID)
				.AddNVarchar("@MerchandiseName", 30, dto.MerchandiseName)
				.AddInt("@CategoryId", dto.CategoryID)
				.AddInt("@Price", dto.Price)
				.AddInt("@Amount", dto.Amount)
				.AddNVarchar("@Description", 30, dto.Description)
				.AddNVarchar("@ImageURL", 30, dto.ImageURL)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}

		public int Create(MerchandiseDto dto)
		{
			string sql = @"INSERT INTO Merchandises       
                            (MerchandiseName, CategoryId, Price, Amount, Description, ImageURL)
                            Values
                            (@MerchandiseName, @CategoryId, @Price, @Amount, @Description, @ImageURL)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("@MerchandiseName", 30, dto.MerchandiseName)
				.AddInt("@CategoryId", dto.CategoryID)
				.AddInt("@Price", dto.Price)
				.AddInt("@Amount", dto.Amount)
				.AddNVarchar("@Description", 30, dto.Description)
				.AddNVarchar("@ImageURL", 30, dto.ImageURL)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Create(connGetter, sql, parameters);
		}

		public int Delete(int merchandiseId)
		{
			string sql = @"DELETE FROM Merchandises
                            WHERE MerchandiseId = @MerchandiseId";

			SqlParameter parameter = new SqlParameter("@MerchandiseId", SqlDbType.Int) { Value = merchandiseId };

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameter);
		}
	}
}
