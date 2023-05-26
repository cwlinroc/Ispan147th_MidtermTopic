using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class OrderService
	{
		public int Create(OrderDto dto)
		{
			return new OrderRepository().Create(dto);
		}

		public OrderDto Get(int id)
		{
			return new OrderRepository().Get(id);
		}

		public IEnumerable<OrderGridDto> Search(OrderSearchDto sDto)
		{
			return new OrderRepository().Search(sDto);
		}

		public int Update(OrderDto dto)
		{
			return new OrderRepository().Update(dto);
		}

		public int Delete(int orderID)
		{
			return new OrderRepository().Delete(orderID);
		}

	}
}
