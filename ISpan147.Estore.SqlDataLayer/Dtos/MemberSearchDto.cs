﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class MemberSearchDto
	{
		public int? MemberID { get; set; }
		public string MemberName { get; set; }
		public int? MaxQueryNumber { get; set; }
	}
}
