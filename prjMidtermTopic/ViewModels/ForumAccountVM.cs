using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prjMidtermTopic.ViewModels
{
	public class ForumAccountVM
	{		
		[Display(Name = "論壇帳戶編號")]
		public int ForumAccountID { get; set; }

		[Display(Name = "論壇帳戶稱呼")]
		[MaxLength(30, ErrorMessage = "{0}長度不可多於{1}")]
		public string ForumAccountName { get; set; }		
	}

	static public class ForumAccounts
	{
		static public ForumAccountDto ToDto(this ForumAccountVM vm)
		{
			return new ForumAccountDto
			{				
				ForumAccountID = vm.ForumAccountID,
				ForumAccountName = vm.ForumAccountName			
			};
		}

		static public ForumAccountVM ToVM(this ForumAccountDto dto)
		{
			return new ForumAccountVM
			{				
				ForumAccountID = dto.ForumAccountID,
				ForumAccountName = dto.ForumAccountName			
			};
		}
	}
}
