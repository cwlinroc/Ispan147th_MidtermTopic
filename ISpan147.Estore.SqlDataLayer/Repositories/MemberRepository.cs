﻿
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using ISpan147.Estore.SqlDataLayer.Builders;

namespace Ispan147.Estore.SqlDataLayer.Repositories
{
	public class MemberRepository
	{
		public MemberDto GetById(int memberId)
		{
			string sql = $"SELECT * FROM Members WHERE MemberID={memberId}";
			Func<SqlDataReader, MemberDto> func = Assembler.MemberDtoAssembler;
			SqlParameter[] parameters = new SqlParameter[0];
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Get(connGetter, sql, func, parameters);
		}

		public MemberDto GetByName(string name)
		{
			string sql = $"SELECT * FROM Members WHERE MemberName = @MemberName";
			Func<SqlDataReader, MemberDto> func = Assembler.MemberDtoAssembler;

			SqlParameter parameter = new SqlParameter("@MemberName", SqlDbType.NVarChar, 30)
			{ Value = name };

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Get(connGetter, sql, func, parameter);
		}

		public List<MemberDto> Search(int? memberId, string s_name)
		{
			#region sql and SqlParameter[]
			string sql = $"SELECT * FROM Members";

			#region 建立條件式
			var builder = new SqlParameterBuilder();

			string where = string.Empty;
			if (memberId.HasValue)
			{
				where += $" AND MemberID = @MemberID";
				builder.AddInt(" @MemberID ", memberId.Value);
			}

			if (string.IsNullOrEmpty(s_name) == false)
			{
				where += $" AND MemberName LIKE '%' + @MemberName + '%'";
				builder.AddNVarchar("@MemberName", 30, s_name);
			}

			if (string.IsNullOrEmpty(where) == false)
			{
				where = " WHERE " + where.Substring(5);
				sql += where;
			}

			var parameters = builder.Build().ToArray();
			#endregion

			//sql += " ORDER BY DisplayOrder";
			#endregion
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, MemberDto> func = Assembler.MemberDtoAssembler;

			return SqlDb.Search(connGetter, sql, func, parameters).ToList();
		}

		public int Update(MemberDto dto)
		{
			string sql = "UPDATE Members SET MemberName = @MemberName WHERE MemberID = @MemberID";

			var parameters = new SqlParameterBuilder()
				.AddInt("@MemberID", dto.MemberID)
				.AddNVarchar("@MemberName", 30, dto.MemberName)

				.Build();
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);

		}

		public int Create(MemberDto dto)
		{
			string sql = @"INSERT INTO Members
						(MemberName, )
						VALUES
						(@MemberName, )";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("@MemberName", 30, dto.MemberName)

				.Build();

			return SqlDb.Create(SqlDb.GetConnection, sql, parameters);
		}

		public int Delete(int memberId)
		{
			string sql = "DELETE FROM Members WHERE MemberID = @MemberID";

			SqlParameter parameter = new SqlParameter("@MemberID", SqlDbType.Int)
			{ Value = memberId };
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameter);

		}

	}

}





