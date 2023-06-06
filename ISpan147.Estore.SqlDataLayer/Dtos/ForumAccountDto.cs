using ISpan147.Estore.SqlDataLayer.EFModel;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class ForumAccountDto
	{		
		public int ForumAccountID { get; set; }
		public string ForumAccountName { get; set; }		
	}

	static public class ForumAccountDtoEF
	{
		static public ForumAccount ToEF(this ForumAccountDto dto)
		{
			return new ForumAccount
			{	
				ForumAccountID = dto.ForumAccountID,
				ForumAccountName = dto.ForumAccountName
			};
		}

		static public ForumAccountDto ToDto(this ForumAccount ef)
		{
			return new ForumAccountDto
			{
				ForumAccountID = ef.ForumAccountID,
				ForumAccountName = ef.ForumAccountName		
			};
		}

		static public void ChangeByDto(this ForumAccount ef, ForumAccountDto dto)
		{	
			ef.ForumAccountID = dto.ForumAccountID;
			ef.ForumAccountName = dto.ForumAccountName;			
		}
	}
}
