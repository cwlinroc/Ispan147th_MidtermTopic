using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class CommentDto
	{
        public int CommentID { get; set; }
        public DateTime CommentTime { get; set; }
        public string CommentContext { get; set; }
        public int ThemeID { get; set; }
		public int ForumAccountID { get; set; }

	}
}
