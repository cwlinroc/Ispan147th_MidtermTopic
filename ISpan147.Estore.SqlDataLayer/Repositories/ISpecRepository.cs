using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public interface ISpecRepository
	{
		SpecDto GetBySpecID(int specId);
		SpecDto GetBySpecName(string specname);
		List<SpecDto> Search(int merchandiseId, int? specId, string s_name);
		List<SpecDto> ShowSpecs(int merchandiseId);
		int Update(SpecDto dto);
		int Create(SpecDto dto);
		int Delete(int specId);
	}
}
