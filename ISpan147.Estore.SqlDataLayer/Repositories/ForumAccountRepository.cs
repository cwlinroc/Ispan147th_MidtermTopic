using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using System;
using System.Linq;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class ForumAccountRepository
	{	
		public MemberDto Get(int memberId)
		{
			var db = new AppDbContext();
			var obj = db.Members.Where(o => o.MemberID == memberId).FirstOrDefault();
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

		public string Update(MemberDto dto)
		{
			var db = new AppDbContext();
			var obj = db.Members.Where(o => o.MemberID == dto.MemberID).FirstOrDefault();
			if (obj == null) return null;
			obj.ChangeByDto(dto);
			db.SaveChanges();
			return obj.ForumAccountID.ToString();
		}

		public int CreateForumAccount(string forumName)
		{
			if (string.IsNullOrEmpty(forumName)) return -1;

			var db = new AppDbContext();
			var obj = new ForumAccount
			{
				ForumAccountName = forumName,
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
