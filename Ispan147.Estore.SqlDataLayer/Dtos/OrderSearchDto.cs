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

		[Table("Orders")]
		public int? MemberID { get; set; }

		[Condition(ConditionState.StringContains)]
		public string MemberName { get; set; }
		public int? PaymentMethod { get; set; }
		public bool? Payed { get; set; }
		public DateTime? PurchaseTime { get; set; }
		public int? PaymentAmount { get; set; }
	}


	

}
