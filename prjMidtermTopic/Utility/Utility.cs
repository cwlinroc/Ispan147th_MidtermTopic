﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Utility
{
	public static class Utility
	{
		public static int? ToNullableInt(this string s)
		{
			int i;
			if (int.TryParse(s, out i)) return i;
			return null;
		}
	}
}
