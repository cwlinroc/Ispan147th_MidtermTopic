
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ISpan147.Estore.SqlDataLayer.Builders;
using prjMidtermTopic.Interfaces;
using Dapper;
using ISpan147.Estore.SqlDataLayer.EFModel;

namespace Ispan147.Estore.SqlDataLayer.Repositories
{
	public class MemberRepository : IMemberRepo
	{
		public MemberDto GetById(int memberID)
		{
			string sql = $"SELECT * FROM Members WHERE MemberID={memberID}";
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

		public IEnumerable<MemberDto> Search(MemberSearchDto sDto)
		{
			if (sDto == null) { return null; }

			string top = string.Empty;
			if (sDto.MaxQueryNumber.HasValue)
			{
				top = "TOP (" + sDto.MaxQueryNumber + ") ";
			}
			else
			{
				top = string.Empty;
			}
			
			string sql = $@"SELECT {top}MemberID, MemberName, ForumAccountID, NickName, " +
				$"DateOfBirth, Gender, Account, Password, Phone, Address, Email, Avatar " +
				$" FROM Members";

			#region 建立條件式
			//var builder = new SqlParameterBuilder();

			string where = string.Empty;
			if (sDto.MemberID.HasValue)
			{
				where += $" AND MemberID = @MemberID";
				//builder.AddInt("MemberID", sDto.MemberID.Value);
			}

			if (!string.IsNullOrEmpty(sDto.MemberName))
			{
				where += $" AND MemberName LIKE '%' + @MemberName + '%'";
				//builder.AddNVarchar("MemberName", 30, sDto.MemberName);
			}

			if (!string.IsNullOrEmpty(where))
			{
				where = " WHERE " + where.Substring(5);				
			}

			//var parameters = builder.Build().ToArray();
			#endregion

			//Func<SqlConnection> connGetter = SqlDb.GetConnection;
			//Func<SqlDataReader, MemberDto> func = Assembler.MemberDtoAssembler;

			//return SqlDb.Search(connGetter, sql, func, parameters).ToList();

			string assembleSQL = sql + where;

			using (var conn = SqlDb.GetConnection())
			{
				return conn.Query<MemberDto>(assembleSQL, sDto);
			}
		}

		public int Create(MemberDto dto)
		{
			string sql = @"INSERT INTO Members
						(MemberName, ForumAccountID, NickName, DateOfBirth, Gender, 
						Account, Password, Phone, Address, Email, Avatar)
						VALUES
						(@MemberName, @ForumAccountID, @NickName, @DateOfBirth, @Gender, 
						@Account, @Password, @Phone, @Address, @Email, @Avatar)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("@MemberName", 30, dto.MemberName)
				.AddNullableInt("@ForumAccountID",dto.ForumAccountID)
				.AddNVarchar("@NickName", 30, dto.NickName)
				.AddDateTime("@DateOfBirth", dto.DateOfBirth)
				.AddBit("@Gender", dto.Gender)
				.AddNchar("@Account", 15, dto.Account)
				.AddNchar("@Password", 65, dto.Password)
				.AddNchar("@Phone", 20, dto.Phone)
				.AddNVarchar("@Address", 30, dto.Address)
				.AddNchar("@Email", 30, dto.Email)
				.AddNVarchar("@Avatar", 50, dto.Avatar)
				.Build();

			return SqlDb.Create(SqlDb.GetConnection, sql, parameters);
		}

		public int Update(MemberDto dto)
		{
			var builder = new SqlParameterBuilder()
				.AddInt("@MemberID", dto.MemberID)
				.AddNVarchar("@MemberName", 30, dto.MemberName)
				.AddNVarchar("@NickName", 30, dto.NickName)
				.AddDateTime("@DateOfBirth", dto.DateOfBirth)
				.AddBit("@Gender", dto.Gender)
				.AddNchar("@Account", 15, dto.Account)
				.AddNchar("@Phone", 20, dto.Phone)
				.AddNVarchar("@Address", 30, dto.Address)
				.AddNchar("@Email", 30, dto.Email);

			string forumAccountID ="";
			string avatar = "";

			if (dto.ForumAccountID != null)
			{
				builder = builder.AddNullableInt("@ForumAccountID", dto.ForumAccountID);
				forumAccountID = ", ForumAccountID = @ForumAccountID ";
			}
			if (dto.Avatar != null)
			{
				builder = builder.AddNVarchar("@Avatar", 50, dto.Avatar);
				avatar = ", Avatar = @Avatar ";
			}
			var parameters = builder.Build();

			string sql = "UPDATE Members SET MemberName = @MemberName, " +
				"NickName = @NickName, DateOfBirth = @DateOfBirth, Gender = @Gender, " +
				"Account = @Account, Phone = @Phone, Address = @Address, Email = @Email" +
				$"{forumAccountID}{avatar}WHERE MemberID = @MemberID";

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);

		}

		public int Delete(int memberID)
		{
			string sql = "DELETE FROM Members WHERE MemberID = @MemberID";

			SqlParameter parameter = new SqlParameter("@MemberID", SqlDbType.Int)
			{ Value = memberID };
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameter);

		}

	}

}





