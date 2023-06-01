using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public interface ICategoryRepository
	{
		CategoryDto GetByCategoryID(int categoryId);
		CategoryDto GetByCategoryName(string categoryname);
		List<CategoryDto> Search(int? categoryId, string s_name);
		int Update(CategoryDto dto);
		int Create(CategoryDto dto);
		int Delete(int categoryId);
	}
}
