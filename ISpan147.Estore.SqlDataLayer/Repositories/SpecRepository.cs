using ISpan147.Estore.SqlDataLayer.Builders;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class SpecRepository : ISpecRepository
	{
		public SpecDto GetBySpecID(int specId)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Specs WHERE SpecId = {specId}";
			Func<SqlDataReader, SpecDto> assembler = Assembler.SpecDtoAssembler;
			SqlParameter[] parameters = new SqlParameter[0];

			return SqlDb.Get(connGetter, sql, assembler);
		}

		public SpecDto GetBySpecName(string specname)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Specs WHERE SpecName = @SpecName";
			Func<SqlDataReader, SpecDto> assembler = Assembler.SpecDtoAssembler;
			SqlParameter parameters = new SqlParameter("@SpecName", SqlDbType.NVarChar, 30) { Value = specname };

			return SqlDb.Get(connGetter, sql, assembler, parameters);
		}

		// todo 規格是否需要搜尋?
		public List<SpecDto> Search(int merchandiseId, int? specId, string s_name)
		{
			#region sql & SqlParameter[]
			string sql = $@"SELECT MerchandiseId, MerchandiseName, CategoryName, BrandName, SpecName, Price, Amount, Description, ImageURL 
							FROM Merchandises AS m
							JOIN Categories AS c
							ON m.CategoryId = c.CategoryId
							JOIN Brands AS b
							ON m.BrandId = b.BrandId
							JOIN Specs AS s
							ON m.SpecId = s.SpecId ";
			var builder = new SqlParameterBuilder();

			string where = " WHERE m.MerchandiseId = @MerchandiseId";
			builder.AddInt("@MerchandiseId", merchandiseId);

			if (specId.HasValue)
			{
				where += $" AND s.SpecId = @SpecId";
				builder.AddInt("@SpecId", specId.Value);
			}
			if (!string.IsNullOrEmpty(s_name))
			{
				where += $" AND s.SpecName LIKE '%' + @SpecName + '%'";
				builder.AddNVarchar("@SpecName", 30, s_name);
			}

			sql += where;

			SqlParameter[] parameters = builder.Build();
			#endregion
			Func<SqlDataReader, SpecDto> func = Assembler.SpecDtoAssembler;
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Search(connGetter, sql, func, parameters.ToArray()).ToList();
		}
		public List<SpecDto> ShowSpecs(int merchandiseId)
		{
			#region sql & SqlParameter[]
			string sql = $@"SELECT m.MerchandiseId, MerchandiseName, SpecId, SpecName, Price, Amount 
							FROM Merchandises AS m							
							JOIN Specs AS s
							ON m.SpecId = s.SpecId";
			
			var builder = new SqlParameterBuilder();

			string where = " WHERE m.MerchandiseId = @MerchandiseId";
			builder.AddInt("@MerchandiseId", merchandiseId);

			sql += where;

			SqlParameter[] parameters = builder.Build();
			#endregion
			Func<SqlDataReader, SpecDto> func = Assembler.SpecDtoAssembler;
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Search(connGetter, sql, func, parameters.ToArray()).ToList();
		}

		public int Update(SpecDto dto)
		{
			var parameters = new SqlParameterBuilder()
				.AddInt("@SpecId", dto.SpecId)
				.AddNVarchar(@"SpecName", 30, dto.SpecName)
				.AddInt("@Price", dto.Price)
				.AddInt("@Amount", dto.Amount)
				.Build();

			string sql = @"UPDATE Specs
							SET SpecName = @SpecName, Price = @Price, Amount = @Amount 
							WHERE SpecId = @SpecId";

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}

		public int Create(SpecDto dto)
		{
			var parameters = new SqlParameterBuilder()
				.AddNVarchar(@"SpecName", 30, dto.SpecName)
				.AddInt(@"MerchandiseId", dto.MerchandiseId)
				.AddInt("@Price", dto.Price)
				.AddInt("@Amount", dto.Amount)
				.Build();

			string sql = @"INSERT INTO Specs
							(SpecName, MerchandiseId, Price, Amount)
							VALUES
							(@SpecName, @MerchandiseId, @Price, @Amount)";

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Create(connGetter, sql, parameters);
		}

		public int Delete(int specId)
		{
			string sql = @"DELETE FROM Specs
							WHERE SpecId = @SpecId";

			SqlParameter parameters = new SqlParameter("@SpecId", SqlDbType.Int) { Value = specId };

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}
	}
}
