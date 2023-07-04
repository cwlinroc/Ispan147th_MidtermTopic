using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class MerchandiseService
	{
		private IMerchandiseRepository _repo;
		public MerchandiseService(IMerchandiseRepository repo)
		{
			this._repo = repo;
		}

		//public List<MerchandiseSearchDto> Search(
		//	//設定未給值時的預設值
		//	int? merchandiseid = null,
		//	string merchandisename = null,
		//	int? categoryid = null		)
		//{
		//	return _repo.Search(merchandiseid, merchandisename, categoryid);
		//}
		public IEnumerable<MerchandiseSearchDto> Search(MerchandiseConditionSearchDto csDto)
		{
			return new MerchandiseRepository().Search(csDto);
		}

		public int Create(MerchandiseDto dto)
		{
			//var repo = new MerchandiseRepository();
			//驗證分類名稱是否重複
			var dtoInDb = _repo.GetByMerchandiseName(dto.MerchandiseName);
			if (dtoInDb != null) { throw new Exception("此分類名稱已存在，請重新命名"); }
			//驗證是否選擇商品類別
			var repoC = new CategoryRepository();
			var dtoInDb2 = repoC.GetByCategoryId(dto.CategoryId);
			if (dtoInDb2 == null) { throw new Exception("未選擇商品類別"); }
			//驗證是否選擇商品品牌
			var repoB = new BrandRepository();
			var dtoInDb3 = repoB.GetByBrandId(dto.BrandId);
			if (dtoInDb3 == null) { throw new Exception("未選擇商品品牌"); }

			int newId = _repo.Create(dto);

			return newId;
		}
		public int Update(MerchandiseDto dto)
		{
			//var repo = new MerchandiseRepository();
			//驗證分類名稱是否重複
			var dtoInDb = _repo.GetByMerchandiseName(dto.MerchandiseName);
			if (dtoInDb != null && dtoInDb.MerchandiseId != dto.MerchandiseId) { throw new Exception("此商品名稱已存在，請重新命名"); }
			//驗證是否選到預設值(預設值不存在於資料庫)
			var repoC = new CategoryRepository();
			var dtoInDb2 = repoC.GetByCategoryId(dto.CategoryId);
			if (dtoInDb2 == null) { throw new Exception("未選擇商品類別"); }

			int rows = _repo.Update(dto);

			return rows;
		}

		public int Delete(int merchandiseID)
		{
			return _repo.Delete(merchandiseID);
		}
	}
}
