using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	//使用反轉注入
	public interface IMerchandiseRepository
	{
		MerchandiseDto GetByMerchandiseID(int merchandiseId);
		MerchandiseDto GetByMerchandiseName(string merchandisename);
		MerchandiseDto GetByCategoryID(int? categoryId);
		List<MerchandiseSearchDto> Search(int? merchandiseId, string s_name, int? s_categoryid);
		int Update(MerchandiseDto dto);
		int Create(MerchandiseDto dto);
		int Delete(int merchandiseId);
	}
}
