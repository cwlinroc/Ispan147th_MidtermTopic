using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MemberClassLibrary.Dtos
{
	public class Assembler
	{
		//public static Func<SqlDataReader, MemberDto> MemberDtoAssembler
		//{
		//	get
		//	{
		//		Func<SqlDataReader, MemberDto> func = (reader) =>
		//		{
		//			int id = reader.GetInt("id");
		//			string name = reader.GetString("name");
		//			DateTime Dateofbirth = ;

		//			return new MemberDto
		//			{
		//				Id = id,
		//				Name = name,
		//				Dateofbirth = birth,
		//				Gender = gender,
		//				Account = account,
		//				Password = pwd,
		//				Phone = phone,
		//				Address = address,
		//				Email = email
		//			};
		//		};
		//		return func;

		//	}
		//}
	}
}
