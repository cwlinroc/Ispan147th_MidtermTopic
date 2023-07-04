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
	public class BrandRepository : IBrandRepository
	{
		public BrandDto GetByBrandId(int brandId)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Brands WHERE BrandId = {brandId}";
			Func<SqlDataReader, BrandDto> assembler = Assembler.BrandDtoAssembler;
			SqlParameter[] parameters = new SqlParameter[0];

			return SqlDb.Get(connGetter, sql, assembler);
		}

		public BrandDto GetByBrandName(string brandname)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Brands WHERE BrandName = @BrandName";
			Func<SqlDataReader, BrandDto> assembler = Assembler.BrandDtoAssembler;
			SqlParameter parameters = new SqlParameter("@BrandName", SqlDbType.NVarChar, 30) { Value = brandname };

			return SqlDb.Get(connGetter, sql, assembler, parameters);
		}

		public List<BrandDto> Search(int? brandId, string s_name)
		{
			#region sql & SqlParameter[]
			string sql = $"SELECT * FROM Brands ";

			var builder = new SqlParameterBuilder();

			string where = "";
			if (brandId.HasValue)
			{
				where += $" AND BrandId = @BrandId";
				builder.AddInt("@BrandId", brandId.Value);
			}
			if(!string.IsNullOrEmpty(s_name))
			{
				where += $" AND BrandName LIKE '%' + @BrandName + '%'";
				builder.AddNVarchar("@BrandName", 30, s_name);
			}
			if(!string.IsNullOrEmpty(where))
			{
				where = " WHERE " + where.Substring(5);
				sql += where;
			}

			SqlParameter[] parameters = builder.Build();
			#endregion
			Func<SqlDataReader, BrandDto> func = Assembler.BrandDtoAssembler;
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Search(connGetter, sql, func, parameters.ToArray()).ToList();
		}

		public int Update(BrandDto dto)
		{
			string sql = @"UPDATE Brands
							SET BrandName = @BrandName
							WHERE BrandId = @BrandId";

			var parameters = new SqlParameterBuilder()
				.AddInt("@BrandId", dto.BrandId)
				.AddNVarchar(@"BrandName", 30, dto.BrandName)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}

		public int Create(BrandDto dto)
		{
			string sql = @"INSERT INTO Brands
							(BrandName)
							VALUES
							(@BrandName)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("@BrandName", 30, dto.BrandName)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Create(connGetter, sql, parameters);
		}

		public int Delete(int brandId)
		{
			string sql = @"DELETE FROM Brands
							WHERE BrandId = @BrandId";

			SqlParameter parameters = new SqlParameter("@BrandId", SqlDbType.Int) { Value = brandId };

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}
	}
}
