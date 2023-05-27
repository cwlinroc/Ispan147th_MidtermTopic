using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public interface IOrderRepository
	{
		OrderDto Get(int id);
		IEnumerable<OrderGridDto> Search(OrderSearchDto sDto);
		int Update(OrderDto dto);
		int Create(OrderDto dto);
		int Delete(int OrderID);
	}
}
