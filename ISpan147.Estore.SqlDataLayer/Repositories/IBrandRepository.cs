using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public interface IBrandRepository
	{
		BrandDto GetByBrandID(int brandId);
		BrandDto GetByBrandName(string brandname);
		List<BrandDto> Search(int? brandId, string s_name);
		int Update(BrandDto dto);
		int Create(BrandDto dto);
		int Delete(int brandId);
	}
}
