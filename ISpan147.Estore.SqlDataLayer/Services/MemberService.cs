using Ispan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan147.Estore.SqlDataLayer.Services
{
	public class MemberService
	{
		public int Create(MemberDto dto)
		{
			var repo = new MemberRepository();
			var dtoInDb = repo.GetByName(dto.MemberName);
			if (dtoInDb != null)
			{
				throw new Exception("此姓名已存在,無法新增");
			}
			//建立一筆新紀錄			
			int newID = repo.Create(dto);

			return newID;
		}

		public int Update(MemberDto dto)
		{
			var repo = new MemberRepository();
			var dtoInDb = repo.GetByName(dto.MemberName);
			if (dtoInDb != null && dtoInDb.MemberID != dto.MemberID)
			{
				throw new Exception("此姓名已存在,無法更新");
			}
			//更新紀錄			
			int rows = repo.Update(dto);

			return rows;
		}


	}
}
