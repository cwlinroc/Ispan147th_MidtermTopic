using MemberClassLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberClassLibrary.Services
{
	public class MemberService
	{
		public int Create(MemberDto dto)
		{
			var repo = new MemberRepository();
			var dtoInDb = repo.GetByName(dto.Name);
			if (dtoInDb != null)
			{
				throw new Exception("此分類名稱已存在,無法新增");
			}
			//建立一筆新紀錄			
			int newId = repo.Create(dto);

			return newId;
		}

		public int Update(MemberDto dto)
		{
			var repo = new MemberRepository();
			var dtoInDb = repo.GetByName(dto.Name);
			if (dtoInDb != null && dtoInDb.Id != dto.Id)
			{
				throw new Exception("此分類名稱已存在,無法更新");
			}
			//更新紀錄			
			int rows = repo.Update(dto);

			return rows;
		}

		public int Load(MemberDto dto) 
		{
			dto.Id = ;
		}
	}
}
