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
			//驗證分類名稱是否重複
			var repo = new MerchandiseRepository();
			var dtoInDb = repo.GetByMerchandiseName(dto.MerchandiseName);
			if (dtoInDb != null) { throw new Exception("此分類名稱已存在，請重新命名");}

			int newId = repo.Create(dto);

			return newId;
		}
		public int Update(MerchandiseDto dto)
		{
			var repo = new MerchandiseRepository();
			var dtoInDb = repo.GetByMerchandiseName(dto.MerchandiseName);
			if (dtoInDb != null && dtoInDb.MerchandiseID != dto.MerchandiseID) { throw new Exception("此分類名稱已存在，請重新命名"); }
			
			int rows = repo.Update(dto);

			return rows;
		}

		public List<MerchandiseDto> Search(
			int? merchandiseid = null,
			string merchandisename = null//,
			// todo int? categoryid = null
			)
		{
			return new List<MerchandiseDto> { }; //todo 刪除這行  恢復下面那行
			//return new OrderListRepository().Search(merchandiseid, merchandisename,/* categoryid*/);
		}

		public int Delete(int orderID)
		{
			return new OrderListRepository().Delete(orderID);
		}
	}
}
