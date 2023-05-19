using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberClassLibrary.Dtos
{
	public class MemberDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime Dateofbirth { get; set; }
		public bool Gender { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
	}
}
