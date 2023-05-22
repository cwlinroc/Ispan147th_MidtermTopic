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
			string sql = $"SELECT * FROM Employee WHERE EmployeeAccount = @EmployeeAccount";
			Func<SqlDataReader, EmployeeDto> assembler = Assembler.EmployeeDtoAssembler;
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("@EmployeeAccount", 20, account).Build();

			return SqlDb.Get(connGetter, sql, assembler, parameters);
		}


		public int Update(EmployeeDto dto)
		{
			if (dto == null) return 0;

			string sql = "UPDATE Employee SET EmployeePassword = @EmployeePassword"
				+ ", Permission = @Permission "
				+ " WHERE EmployeeAccount = @EmployeeAccount ";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("EmployeePassword", 65, dto.Password)
				.AddInt("Permission", dto.Permission)
				.AddNVarchar("EmployeeAccount", 20, dto.Account)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}

		public void Create(EmployeeDto dto)
		{
			string sql = "INSERT INTO Employee (EmployeeAccount, EmployeePassword, Permission)"
				+ " VALUES (@EmployeeAccount, @EmployeePassword, @Permission) ";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("EmployeeAccount", 20, dto.Account)
				.AddNVarchar("EmployeePassword", 65, dto.Password)
				.AddInt("Permission", dto.Permission)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			SqlDb.CreateWithoutScope(connGetter, sql, parameters);
		}

		public int Delete(string account)
		{
			string sql = "DELETE Employee WHERE EmployeeAccount = @EmployeeAccount";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("EmployeeAccount", 20, account)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}
	}
}
