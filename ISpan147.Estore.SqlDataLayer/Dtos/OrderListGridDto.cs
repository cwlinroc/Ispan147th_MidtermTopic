using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class OrderListGridDto
	{
        public int ID { get; set; }
		public int OrderID { get; set; }
		public string MerchandiseID { get; set; }
		public string MerchandiseNAme { get; set; }
		public int Quantity { get; set; }

	}
}
