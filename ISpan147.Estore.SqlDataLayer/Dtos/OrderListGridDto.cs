using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class OrderListGridDto
	{
        public int OrderListID { get; set; }
		public int OrderID { get; set; }
		public int MerchandiseID { get; set; }
		public string MerchandiseName { get; set; }
		public int Quantity { get; set; }

	}
}
