using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public interface IForumAccountRepo
	{
		ForumAccountDto GetById(int id);
		ForumAccountDto GetByName(string name);
		int Create(ForumAccountDto dto);
		string Update(ForumAccountDto dto);
	}
}
