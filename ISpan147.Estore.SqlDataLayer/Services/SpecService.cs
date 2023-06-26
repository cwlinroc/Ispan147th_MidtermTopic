using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class SpecService
	{
		private ISpecRepository _repo;

		public SpecService(ISpecRepository repo)
		{
			this._repo = repo;
		}

		public int Create(SpecDto dto)
		{
			var dtoInDb = _repo.GetBySpecName(dto.SpecName);
			if (dtoInDb != null) { throw new Exception("此規格名稱已存在，請重新命名"); }

			int newId = _repo.Create(dto);

			return newId;
		}

		public int Update(SpecDto dto)
		{
			var dtoInDb = _repo.GetBySpecName(dto.SpecName);
			if (dtoInDb != null && dtoInDb.SpecId != dto.SpecId) { throw new Exception("此規格名稱已存在，請重新命名"); }

			int rows = _repo.Update(dto);

			return rows;
		}

		public List<SpecDto> Search(
			// todo 確認搜尋條件
			int? specid = null,
		string specname = null
			)
		{
			return _repo.Search(specid, specname);
		}

		public int Delete(int specId)
		{
			return _repo.Delete(specId);
		}
	}
}
