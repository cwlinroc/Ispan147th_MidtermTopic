﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class OrderGridDto
	{
		public int OrderID { get; set; }
		public int MemberID { get; set; }
		public string MemberName { get; set; }
		public int PaymentMethod { get; set; }
		public bool Payed { get; set; }
		public DateTime? PurchaseTime { get; set; }
		public int? PaymentAmount { get; set; }
	}
}
