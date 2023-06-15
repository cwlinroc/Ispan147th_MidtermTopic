using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class BrandService
	{
		private IBrandRepository _repo;

		public BrandService(IBrandRepository repo)
		{
			this._repo = repo;
		}

		public int Create(BrandDto dto)
		{
			var dtoInDb = _repo.GetByBrandName(dto.BrandName);
			if(dtoInDb != null) { throw new Exception("此品牌名稱已存在，請重新命名"); }

			int newId = _repo.Create(dto);

			return newId;
		}

		public int Update(BrandDto dto)
		{
			var dtoInDb = _repo.GetByBrandName(dto.BrandName);
			if(dtoInDb != null && dtoInDb.BrandId != dto.BrandId) { throw new Exception("此品牌名稱已存在，請重新命名"); }

			int rows = _repo.Update(dto);

			return rows;
		}

		public List<BrandDto> Search(
			int? brandid = null,
			string brandname =null
			)
		{
			return _repo.Search(brandid, brandname);
		}

		public int Delete(int brandId)
		{
			return _repo.Delete(brandId);
		}
	}
}
