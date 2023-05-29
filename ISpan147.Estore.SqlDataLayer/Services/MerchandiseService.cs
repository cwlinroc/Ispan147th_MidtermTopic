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
		public int Create(MerchandiseDto dto)
		{
			var repo = new MerchandiseRepository();
			//驗證分類名稱是否重複
			var dtoInDb = repo.GetByMerchandiseName(dto.MerchandiseName);
			if (dtoInDb != null) { throw new Exception("此分類名稱已存在，請重新命名"); }
			//驗證是否選擇商品類別
			var dtoInDb2 = repo.GetByCategoryID(dto.CategoryID);
			if (dtoInDb2 == null) { throw new Exception("未選擇商品類別"); }

			int newId = repo.Create(dto);

			return newId;
		}
		public int Update(MerchandiseDto dto)
		{
			var repo = new MerchandiseRepository();
			//驗證分類名稱是否重複
			var dtoInDb = repo.GetByMerchandiseName(dto.MerchandiseName);
			if (dtoInDb != null && dtoInDb.MerchandiseID != dto.MerchandiseID) { throw new Exception("此商品名稱已存在，請重新命名"); }
			//驗證是否選到預設值(預設值不存在於資料庫)
			var dtoInDb2 = repo.GetByCategoryID(dto.CategoryID);
			if (dtoInDb2 == null) { throw new Exception("未選擇商品類別"); }

			int rows = repo.Update(dto);

			return rows;
		}

		public List<MerchandiseSearchDto> Search
			(
			int? merchandiseid = null,
			string merchandisename = null,
			int? categoryid = null
			)
		{
			return new List<MerchandiseSearchDto> { };
			return new MerchandiseRepository().Search(merchandiseid, merchandisename, categoryid);
		}

		public int Delete(int merchandiseID)
		{
			return new MerchandiseRepository().Delete(merchandiseID);
		}
	}
}
