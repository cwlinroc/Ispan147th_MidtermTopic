using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class ForumAccountRepository
	{	
		public ForumAccountDto Get(int forumId)
		{
			var db = new AppDbContext();
			var obj = db.ForumAccounts.Where(o => o.ForumAccountID == forumId).FirstOrDefault();
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
			return obj.ForumAccountID;
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

		public int CreateForumAccount(string accountName)
		{
			if (string.IsNullOrEmpty(accountName)) return -1;

			var db = new AppDbContext();
			var obj = new ForumAccount
			{
				ForumAccountName = accountName,
			};
			db.ForumAccounts.Add(obj);
			db.SaveChanges();
			return obj.ForumAccountID;
		}

		public int UpdateForumAccount(ForumAccountDto dto)
		{
			if (string.IsNullOrEmpty(dto.ForumAccountName)) return -1;

			var db = new AppDbContext();
			var obj = db.ForumAccounts.Where(o => o.ForumAccountID == dto.ForumAccountID).FirstOrDefault();

			if (obj == null) return 0;

			obj.ForumAccountName = dto.ForumAccountName;
			db.SaveChanges();
			return obj.ForumAccountID;
		}

		public string GetForumAccountName(int forumID)
		{
			var db = new AppDbContext();
			var obj = db.ForumAccounts.Where(o => o.ForumAccountID == forumID).FirstOrDefault();

			if (obj == null) return null;

			return obj.ForumAccountName;

		}
	}
}
