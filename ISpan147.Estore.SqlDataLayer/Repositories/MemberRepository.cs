using Ispan147.Estore.SqlDataLayer.Dtos;
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

namespace Ispan147.Estore.SqlDataLayer.Repositories
{
	public class MemberRepository
	{
		List<MemberDto> _list = new List<MemberDto>();

		public List<MemberDto> LoadData(int? mId, string mName)
		{
			MemberDto dto = new MemberDto
			{
				Id = 1,
				Name = "Marco",
				DateOfBirth = new DateTime(2000, 6, 10),
				Gender = MemberDto.GenderType.Male,
				Account = "marco6541",
				Password = "co6541mar",
				Phone = "0933654125",
				Address = "Taipei",
				Email = "marco@gmail.com",
				Avatar = "iconMarco.jpg"
			};
			_list.Add(dto);

			dto = new MemberDto
			{
				Id = 2,
				Name = "Selina",
				DateOfBirth = new DateTime(1990, 4, 20),
				Gender = MemberDto.GenderType.Female,
				Account = "selina9665",
				Password = "ina96sel",
				Phone = "0966541258",
				Address = "NewTaipei",
				Email = "selina@gmail.com",
				Avatar = "iconSelina.jpg"
			};
			_list.Add(dto);

			dto = new MemberDto
			{
				Id = 3,
				Name = "Antony",
				DateOfBirth = new DateTime(1995, 8, 8),
				Gender = MemberDto.GenderType.Male,
				Account = "3244Antony",
				Password = "Ant44ony",
				Phone = "0932448559",
				Address = "TaiChung",
				Email = "antony@hotmail.com",
				Avatar = "iconAntony.jpg"
			};
			_list.Add(dto);

			dto = new MemberDto
			{
				Id = 4,
				Name = "Caroline",
				DateOfBirth = new DateTime(1985, 11, 22),
				Gender = MemberDto.GenderType.Female,
				Account = "carol6548",
				Password = "rol96ca",
				Phone = "0912654893",
				Address = "Taoyuan",
				Email = "carol@gmail.com",
				Avatar = "iconCarol.jpg"
			};
			_list.Add(dto);

			dto = new MemberDto
			{
				Id = 5,
				Name = "Janet",
				DateOfBirth = new DateTime(2005, 2, 15),
				Gender = MemberDto.GenderType.Female,
				Account = "Janet6588",
				Password = "8452Janet",
				Phone = "0965884523",
				Address = "Kaohsiung",
				Email = "Janet@gmail.com",
				Avatar = "iconJanet.jpg"
			};
			_list.Add(dto);

			return _list;
		}

		//public MemberDto GetByName(string name)
		//{
		//	MemberDto dto = new MemberDto();
		//	if (dto.Name == name)
		//	{
				
		//	}
		//}

	}

}

	//public MemberDto GetById(int memberId)
	//{
	//	string sql = $"SELECT * FROM Categories WHERE Id={memberId}";
	//	Func<SqlDataReader, MemberDto> func = Assembler.MemberDtoAssembler;
	//	SqlParameter[] parameters = new SqlParameter[0];
	//	Func<SqlConnection> connGetter = SqlDb.GetConnection;

	//	return SqlDb.Get(connGetter, sql, func);
	//}

	//public MemberDto GetByName(string name)
	//{
	//	string sql = $"SELECT * FROM Categories WHERE Name=@Name";
	//	Func<SqlDataReader, MemberDto> func = Assembler.MemberDtoAssembler;

	//	SqlParameter parameter = new SqlParameter("@Name", SqlDbType.NVarChar, 30) 
	//	{ Value = name };

	//	Func<SqlConnection> connGetter = SqlDb.GetConnection;

	//	return SqlDb.Get(connGetter, sql, func, parameter);
	//}

	//public List<MemberDto> Search(int? memberId, string s_name)
	//{
	//	#region sql and SqlParameter[]
	//	string sql = $"SELECT * FROM Categories";

	//	#region 建立條件式
	//	var builder = new SqlParameterBuilder();

	//	string where = string.Empty;
	//	if (memberId.HasValue)
	//	{
	//		where += $" AND Id=@Id";
	//		builder.AddInt("@Id", memberId.Value);
	//	}

	//	if (string.IsNullOrEmpty(s_name) == false)
	//	{
	//		where += $" AND Name LIKE '%' + @Name + '%'";
	//		builder.AddNVarchar("@Name", 30, s_name);
	//	}

	//	if (string.IsNullOrEmpty(where) == false)
	//	{
	//		where = " WHERE " + where.Substring(5);
	//		sql += where;
	//	}

	//	var parameters = builder.Build().ToArray();
	//	#endregion

	//	sql += " ORDER BY DisplayOrder";
	//	#endregion
	//	Func<SqlConnection> connGetter = SqlDb.GetConnection;
	//	Func<SqlDataReader, MemberDto> func = Assembler.MemberDtoAssembler;

	//	return SqlDb.Search(connGetter, sql, func, parameters).ToList();
	//}

	//public int Update(MemberDto dto)
	//{
	//	string sql = "UPDATE Members SET Name=@Name WHERE Id=@Id";

	//	var parameters = new SqlParameterBuilder()
	//		.AddInt("@Id", dto.Id)
	//		.AddNVarchar("@Name", 30, dto.Name)

	//		.Build();
	//	Func<SqlConnection> connGetter = SqlDb.GetConnection;

	//	return SqlDb.UpdateOrDelete(connGetter, sql, parameters);

	//}

	//public int Create(MemberDto dto)
	//{
	//	string sql = @"INSERT INTO Categories
	//				(Name, DisplayOrder)
	//				VALUES
	//				(@Name, @DisplayOrder)";

	//	var parameters = new SqlParameterBuilder()
	//		.AddNVarchar("@Name", 30, dto.Name)

	//		.Build();

	//	return SqlDb.Create(SqlDb.GetConnection, sql, parameters);
	//}

	//public int Delete(int memberId)
	//{
	//	string sql = "DELETE FROM Members WHERE Id=@Id";

	//	SqlParameter parameter = new SqlParameter("@Id", SqlDbType.Int) 
	//	{ Value = memberId };
	//	Func<SqlConnection> connGetter = SqlDb.GetConnection;

	//	return SqlDb.UpdateOrDelete(connGetter, sql, parameter);

	//}


