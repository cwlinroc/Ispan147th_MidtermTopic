using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class BrandRepository // todo : IBrandRepository
	{
		public BrandDto GetByBrandID(int brandId)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Brands WHERE BrandId = {brandId}";
			Func<SqlDataReader, BrandDto> assembler = Assembler.BreedDtoAssembler;
			SqlParameter[] parameters = new SqlParameter[0];

			return SqlDb.Get(connGetter, sql, assembler);
		}
	}
}
