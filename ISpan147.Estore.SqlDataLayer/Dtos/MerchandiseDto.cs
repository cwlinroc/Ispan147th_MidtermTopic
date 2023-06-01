using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class MerchandiseDto
	{
        public int MerchandiseID { get; set; }
        public string MerchandiseName { get; set; }
		public int CategoryID { get; set; }
		public int Price { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
	}
}
