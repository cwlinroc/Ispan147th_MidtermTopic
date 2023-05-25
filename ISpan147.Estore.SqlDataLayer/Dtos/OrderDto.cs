using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class OrderDto
	{
		public int OrderID { get; set; }
        public int MemberID { get; set; }
        public int PaymentMethod { get; set; }
		public bool Payed { get; set; }
	}
}
