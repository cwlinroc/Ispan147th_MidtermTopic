using ISpan147.Estore.SqlDataLayer.Builders;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class EmployeeRepositoy
	{
		public EmployeeDto Get(string account)
		{
			if (string.IsNullOrEmpty(account)) return null;
			var db = new AppDbContext();
			var obj = db.Employees.Where(o => o.EmployeeAccount == account).FirstOrDefault();
			if (db == null) return null;
			return obj.ToDto();
		}


		public int Update(EmployeeDto dto)
		{
			if (dto == null) return 0;

			var db = new AppDbContext();
			var obj = db.Employees.Where(o => o.EmployeeID == dto.EmployeeID).FirstOrDefault();
			if (obj == null) return 0;
			obj.ChangeByDto(dto);
			db.SaveChanges();
			return obj.EmployeeID;
		}

		public List<EmployeeDto> GetAll()
		{
			var db = new AppDbContext();
			var query = db.Employees.ToList();
			return query.Select(o => o.ToDto()).ToList();
		}

		public int Create(EmployeeDto dto)
		{
			if (dto == null) throw new ArgumentNullException(nameof(dto));
			var db = new AppDbContext();
			var obj = dto.ToEF();
			db.Employees.Add(obj);
			db.SaveChanges();
			return obj.EmployeeID;
		}

		public int Delete(string account)
		{
			var db = new AppDbContext();
			var obj = db.Employees.Where(o => o.EmployeeAccount == account).FirstOrDefault();
			if (obj == null) return 0;
			db.Employees.Remove(obj);
			db.SaveChanges();
			return obj.EmployeeID;
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

			if(obj == null) return null;

			return obj.ForumAccountName;

		}

	}
}
