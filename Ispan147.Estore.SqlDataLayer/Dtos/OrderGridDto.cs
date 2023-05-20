using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class OrderGridDto
	{
		public int ID { get; set; }
		public string CustomerID { get; set; }
		public string PaymentMethod { get; set; }
		public bool Payed { get; set; }
	}
}
