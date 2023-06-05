using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class ForumAccountService
	{
		private ForumAccountRepository _repo;

		public ForumAccountService()
		{
			_repo = new ForumAccountRepository();
		}

		public ForumAccountService(ForumAccountRepository repo)
		{
			_repo = repo;
		}

		public ForumAccountDto Get(int id)
		{
			return _repo.Get(id);
		}

		public int Create(ForumAccountDto dto)
		{
			return _repo.Create(dto);
		}

		public string Update(ForumAccountDto dto) 
		{  
			return _repo.Update(dto); 
		}

		public string GetForumAccountName(int forumID)
		{
			return _repo.GetForumAccountName(forumID);
		}

		public int CreateForumAccount(int memberId, string forumName)
		{
			var dto = Get(memberId);

			if (dto == null) return 0;

			int forumAccountID = _repo.CreateForumAccount(forumName);

			dto.ForumAccountID = forumAccountID;

			Update(dto);

			return forumAccountID;

		}

		public int UpdateForumAccount(int forumAccountID, string forumName)
		{
			return _repo.UpdateForumAccount(new ForumAccountDto
			{
				ForumAccountID = forumAccountID,
				ForumAccountName = forumName
			});

		}
	}

	
}
