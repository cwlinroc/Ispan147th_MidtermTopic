using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class SpecDto
	{
		public string MerchandiseName { get; set; }
		public int MerchandiseId { get; set; }
		public int SpecId { get; set; }
		public string SpecName { get; set; }
		public int Price { get; set; }
		public int Amount { get; set; }
	}
}
