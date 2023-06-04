using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.EFModel
{
	public partial class ForumAccount
	{
		[Required]
		[StringLength(30)]
		public string MemberName { get; set; }

		public int? ForumAccountID { get; set; }

		[StringLength(30)]
		public string ForumAccountName { get; set; }

		[StringLength(30)]
		public string NickName { get; set; }
		
	}
}
