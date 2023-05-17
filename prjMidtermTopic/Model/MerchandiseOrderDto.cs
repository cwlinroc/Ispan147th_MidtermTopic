using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.Model
{
	public class MerchandiseOrderDto
	{
		public int orderID { get; set; }
        public string customerID { get; set; }
        public int paymentMethod { get; set; }
		public bool payed { get; set; }
	}
}
