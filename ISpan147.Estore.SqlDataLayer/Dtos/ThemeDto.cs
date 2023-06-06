using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class ThemeDto
	{
        public int ThemeID { get; set; }
        public DateTime ThemeDateTime { get; set; }
        public string ThemeContext { get; set; }
		public int ForumAccountID { get; set; }
	}
}
