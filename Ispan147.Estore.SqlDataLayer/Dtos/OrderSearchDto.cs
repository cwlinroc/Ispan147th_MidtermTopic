using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class OrderSearchDto
	{
		public int? OrderID { get; set; }
		public int? MemberID { get; set; }
		public string MemberName { get; set; }
		public int? MinPaymentAmount { get; set; }
		public int? MaxPaymentAmount { get; set; }
		public bool? Payed { get; set; }
		public DateTime? PurchaseTime { get; set; }
		public int? PaymentMethod { get; set; }
		public int? MaxQueryNumber { get; set; }
		public string OrderBy { get; set; }
		public bool Descending { get; set; }
	}




}
