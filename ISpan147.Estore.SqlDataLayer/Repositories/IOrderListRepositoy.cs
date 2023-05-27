using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public interface IOrderListRepositoy
	{
		OrderListDto Get(int id);
		List<OrderListGridDto> Search(
			int? id = null,
			int? orderID = null,
			int? merchandiseID = null,
			int? quantity = null);

		int Update(OrderListDto dto);

		int Create(OrderListDto dto);

		int Delete(int orderID);
	}
}
