using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class MerchandiseSearchDto
	{
		public int MerchandiseId { get; set; }
		public string MerchandiseName { get; set; }
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public int BrandId { get; set; }
		public string BrandName { get; set; }
		//public int Price { get; set; }
		//public int Amount { get; set; }
		public string Description { get; set; }
		public string ImageURL { get; set; }
	}
}
