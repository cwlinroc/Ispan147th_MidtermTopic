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

		public List<SpecDto> Search(int? specId, string s_name)
		{
			#region sql & SqlParameter[]
			string sql = $"SELECT * FROM Specs ";

			var builder = new SqlParameterBuilder();

			string where = "";
			if (specId.HasValue)
			{
				where += $" AND SpecID = @SpecID";
				builder.AddInt("@SpecID", specId.Value);
			}
			if (!string.IsNullOrEmpty(s_name))
			{
				where += $" AND SpecName LIKE '%' + @SpecName + '%'";
				builder.AddNVarchar("@SpecName", 30, s_name);
			}
			// todo 其他搜尋條件(參考Merchandise)
			if (!string.IsNullOrEmpty(where))
			{
				where = " WHERE " + where.Substring(5);
				sql += where;
			}

			SqlParameter[] parameters = builder.Build();
			#endregion
			Func<SqlDataReader, SpecDto> func = Assembler.SpecDtoAssembler;
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Search(connGetter, sql, func, parameters.ToArray()).ToList();
		}

		public int Update(SpecDto dto)
		{
			// todo 其他條件(參考Merchandise)
			string sql = @"UPDATE Specs
							SET SpecName = @SpecName
							WHERE SpecId = @SpecId";

			var parameters = new SqlParameterBuilder()
				.AddInt("@SpecId", dto.SpecId)
				.AddNVarchar(@"SpecName", 30, dto.SpecName)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}

		public int Create(SpecDto dto)
		{
			// todo 其他條件(參考Merchandise)
			string sql = @"INSERT INTO Specs
							(SpecName)
							VALUES
							(@SpecName)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar(@"SpecName", 30, dto.SpecName)
				.Build();

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
