using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class MerchandiseConditionSearchDto
	{
		public int? MerchandiseId { get; set; }
		public string MerchandiseName { get; set; }
		public int? CategoryId { get; set; }
		public string BrandName { get; set; }
		//public int? MaxPrice { get; set; }
		//public int? MinPrice { get; set; }
		public int? MaxQueryNumber { get; set; }
		public string OrderBy { get; set; }
		public bool Descending { get; set; }
	}
}
