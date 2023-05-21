using ISpan147.Estore.SqlDataLayer.Builders;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class EmployeeRepositoy
	{
		public EmployeeDto Get(string account)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Employee WHERE Account = @Account";
			Func<SqlDataReader, EmployeeDto> assembler = Assembler.EmployeeDtoAssembler;
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("@Account", 20, account).Build();

			return SqlDb.Get(connGetter, sql, assembler, parameters);
		}


		public int Update(EmployeeDto dto)
		{
			if (dto == null) return 0;

			string sql = "UPDATE Employee SET Password = @Password"
				+ ", Permission = @Permission "
				+ " WHERE Account = @Account ";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Password", 65, dto.Password)
				.AddInt("Permission", dto.Permission)
				.AddNVarchar("Account", 20, dto.Account)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}

		public void Create(EmployeeDto dto)
		{
			string sql = "INSERT INTO Employee (Account, Password, Permission)"
				+ " VALUES (@Account, @Password, @Permission) ";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 20, dto.Account)
				.AddNVarchar("Password", 65, dto.Password)
				.AddInt("Permission", dto.Permission)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			SqlDb.CreateWithoutScope(connGetter, sql, parameters);
		}

		public int Delete(string account)
		{
			string sql = "DELETE Employee WHERE Account = @Account";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 20, account)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}
	}
}
