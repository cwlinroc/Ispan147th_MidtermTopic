using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class EmployeeDto
	{
		public string EmployeeAccount { get; set; }
		public string EmployeePassword { get; set; }
		public int Permission { get; set; }
	}
}
