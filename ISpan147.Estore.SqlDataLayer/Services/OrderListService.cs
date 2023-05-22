using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class OrderListService
	{
		public int Create(OrderListDto dto)
		{
			return new OrderListRepository().Create(dto);
		}

		public OrderListDto Get(int id)
		{
			return new OrderListRepository().Get(id);
		}

		public List<OrderListDto> Search(
			int? id = null,
			int? orderID = null,
			int? merchandiseID = null,
			int? quantity = null)
		{
			return new OrderListRepository().Search(id, orderID, merchandiseID, quantity);
		}


		public int Update(OrderListDto dto)
		{
			return new OrderListRepository().Update(dto);
		}

		public int Delete(int orderID)
		{
			return new OrderListRepository().Delete(orderID);
		}

	}
}
