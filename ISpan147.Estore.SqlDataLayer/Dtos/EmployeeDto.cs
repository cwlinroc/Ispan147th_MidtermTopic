using ISpan147.Estore.SqlDataLayer.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class EmployeeDto
	{
		public int EmployeeID { get; set; }
		public string EmployeeName { get; set; }
		public string EmployeeAccount { get; set; }
		public string EmployeePassword { get; set; }
		public int Permission { get; set; }
	}

	static public class EmployeeDtoEF
	{
		static public EmployeeDto ToDto(this Employee ef)
		{
			return new EmployeeDto
			{
				EmployeeID = ef.EmployeeID,
				EmployeeName = ef.EmployeeName,
				EmployeeAccount = ef.EmployeeAccount,
				EmployeePassword = ef.EmployeePassword,
				Permission = ef.Permission
			};
		}

		static public Employee ToEF(this EmployeeDto dto)
		{
			return new Employee
			{
				EmployeeID = dto.EmployeeID,
				EmployeeName = dto.EmployeeName,
				EmployeeAccount = dto.EmployeeAccount,
				EmployeePassword = dto.EmployeePassword,
				Permission = dto.Permission
			};
		}

		static public void ChangeByDto(this Employee ef, EmployeeDto dto)
		{
			ef.EmployeeID = dto.EmployeeID;
			ef.EmployeeName = dto.EmployeeName;
			ef.EmployeeAccount = dto.EmployeeAccount;
			ef.EmployeePassword = dto.EmployeePassword;
			ef.Permission = dto.Permission;
		}
	}
}
