using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class Authentication
	{
		static private EmployeeDto _employee = new EmployeeDto
		{
			EmployeeID = -1,
			EmployeeName = "Default",
			ForumAccountID = 5,
			Permission = 2,
		};

		static public int? ForumAccountID
		{
			get => _employee.ForumAccountID;
		}

		static public int Permission
		{
			get => _employee.Permission;
		}

		static public string EmployeeName
		{
			get => _employee.EmployeeName;
		}

		static public int EmployeeID
		{
			get => _employee.EmployeeID;
		}

		static public void LogIn(EmployeeDto employee)
		{
			_employee = employee;
		}

	}

}
