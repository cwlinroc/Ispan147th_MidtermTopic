using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class ForumAccountRepository : IForumAccountRepo
	{	
		public ForumAccountDto GetById(int forumAccountId)
		{
			var db = new AppDbContext();
			var obj = db.ForumAccounts.Where(o => o.ForumAccountID == forumAccountId).FirstOrDefault();
			if (db == null) return null;
			return obj.ToDto();
		}

		public ForumAccountDto GetByName(string forumAccountName)
		{
			var db = new AppDbContext();
			var obj = db.ForumAccounts.Where(o => o.ForumAccountName == forumAccountName).FirstOrDefault();
			if (db == null) return null;
			return obj.ToDto();
		}

		public int Create(ForumAccountDto dto)
		{
			if (dto == null) throw new ArgumentNullException(nameof(dto));
			var db = new AppDbContext();
			var obj = dto.ToEF();
			db.ForumAccounts.Add(obj);
			db.SaveChanges();
			return obj.ForumAccountID.Value;
		}		

		public string Update(ForumAccountDto dto)
		{
			var db = new AppDbContext();
			var obj = db.ForumAccounts.Where(o => o.ForumAccountID == dto.ForumAccountID).FirstOrDefault();
			if (obj == null) return null;
			obj.ChangeByDto(dto);
			db.SaveChanges();
			return obj.ForumAccountName;
		}
	}
}
