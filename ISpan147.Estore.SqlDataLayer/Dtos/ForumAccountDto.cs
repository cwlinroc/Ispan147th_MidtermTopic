using ISpan147.Estore.SqlDataLayer.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class ForumAccountDto
	{		
		public string MemberName { get; set; }
		public int? ForumAccountID { get; set; }
		public string ForumAccountName { get; set; }
		public string NickName { get; set; }
	}

	static public class ForumAccountDtoEF
	{
		static public ForumAccount ToEF(this ForumAccountDto dto)
		{
			return new ForumAccount
			{	
				ForumAccountID = dto.ForumAccountID,
				ForumAccountName = string.IsNullOrEmpty(dto.NickName)? 
									dto.MemberName: dto.NickName				
			};
		}

		static public ForumAccountDto ToDto(this ForumAccount ef)
		{
			return new ForumAccountDto
			{
				ForumAccountID = ef.ForumAccountID,
				ForumAccountName = string.IsNullOrEmpty(ef.NickName) ? 
									ef.MemberName : ef.NickName				
			};
		}

		static public void ChangeByDto(this ForumAccount ef, ForumAccountDto dto)
		{	
			ef.ForumAccountID = dto.ForumAccountID;
			ef.ForumAccountName = dto.ForumAccountName;			
		}
	}
}
