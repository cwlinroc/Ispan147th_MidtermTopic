using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class CategoryService
	{
		private ICategoryRepository _repo;

		public CategoryService(ICategoryRepository repo)
		{
			this._repo = repo;
		}
		public int Create(CategoryDto dto)
		{
			//var repo = new CategoryRepository();
			//驗證分類名稱是否重複
			var dtoInDb = _repo.GetByCategoryName(dto.CategoryName);
			if (dtoInDb != null) { throw new Exception("此分類名稱已存在，請重新命名"); }

			int newId = _repo.Create(dto);

			return newId;
		}
		public int Update(CategoryDto dto)
		{
			//var repo = new CategoryRepository();
			//驗證分類名稱是否重複
			var dtoInDb = _repo.GetByCategoryName(dto.CategoryName);
			if (dtoInDb != null && dtoInDb.CategoryId != dto.CategoryId) { throw new Exception("此分類名稱已存在，請重新命名"); }

			int rows = _repo.Update(dto);

			return rows;
		}

		public List<CategoryDto> Search(
			int? categoryid = null,
			string categoryname = null
			)
		{
			return _repo.Search(categoryid, categoryname);
		}

		public int Delete(int categoryId)
		{
			return _repo.Delete(categoryId);
		}
	}
}
