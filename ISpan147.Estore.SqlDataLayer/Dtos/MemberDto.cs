using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan147.Estore.SqlDataLayer.Dtos
{
	public class MemberDto
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public DateTime DateOfBirth { get; set; }		
		public bool Gender { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public string Avatar { get; set; }
	}
}
