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
		private IForumAccountRepo _repo;

		public ForumAccountService(IForumAccountRepo repo)
		{
			_repo = repo;
		}

		public ForumAccountDto GetById(int id)
		{
			return _repo.GetById(id);
		}

		public int Create(ForumAccountDto dto)
		{
			return _repo.Create(dto);
		}

		public string Update(ForumAccountDto dto) 
		{  
			return _repo.Update(dto); 
		}
	}

	
}
