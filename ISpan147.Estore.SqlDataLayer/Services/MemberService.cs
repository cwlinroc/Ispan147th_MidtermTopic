using Ispan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using ISpan147.Estore.SqlDataLayer.Repositories;
using prjMidtermTopic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ispan147.Estore.SqlDataLayer.Services
{
	public class MemberService
	{
		private readonly IMemberRepo _repo;

		public MemberService(IMemberRepo repo)
		{
			_repo = repo;
		}

		public int Create(MemberDto dto)
		{
			
			var dtoInDb = _repo.GetByName(dto.MemberName);
			if (dtoInDb != null)
			{
				throw new Exception("此姓名已存在,無法新增");
			}
			//建立一筆新紀錄			
			int newID = _repo.Create(dto);

			return newID;
		}

		public int Update(MemberDto dto)
		{			
			var dtoInDb = _repo.GetByName(dto.MemberName);
			if (dtoInDb != null && dtoInDb.MemberID != dto.MemberID)
			{
				throw new Exception("此姓名已存在,無法更新");
			}
			//更新紀錄			
			int rows = _repo.Update(dto);

			return rows;
		}

		public int Delete(int MemberID)
		{
			return _repo.Delete(MemberID);
		}

		public IEnumerable<MemberDto> Search(MemberSearchDto sDto)
		{
			return new MemberRepository().Search(sDto);
		}
	}
}
