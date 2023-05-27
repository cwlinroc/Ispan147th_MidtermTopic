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
		private IOrderListRepositoy reop;

		public OrderListService(IOrderListRepositoy reop)
		{
			this.reop = reop;
		}

		public int Create(OrderListDto dto)
		{
			return new OrderListRepositoryAdoNet().Create(dto);
		}

		public OrderListDto Get(int id)
		{
			return new OrderListRepositoryAdoNet().Get(id);
		}

		public List<OrderListGridDto> Search(
			int? id = null,
			int? orderID = null,
			int? merchandiseID = null,
			int? quantity = null)
		{
			return new OrderListRepositoryAdoNet().Search(id, orderID, merchandiseID, quantity);
		}


		public int Update(OrderListDto dto)
		{
			return new OrderListRepositoryAdoNet().Update(dto);
		}

		public int Delete(int orderID)
		{
			return new OrderListRepositoryAdoNet().Delete(orderID);
		}

	}
}
