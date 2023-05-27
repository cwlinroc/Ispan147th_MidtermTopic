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
		private IOrderListRepositoy _repo;

		public OrderListService(IOrderListRepositoy repo)
		{
			this._repo = repo;
		}

		public int Create(OrderListDto dto)
		{
			return _repo.Create(dto);
		}

		public OrderListDto Get(int id)
		{
			return _repo.Get(id);
		}

		public List<OrderListGridDto> Search(
			int? id = null,
			int? orderID = null,
			int? merchandiseID = null,
			int? quantity = null)
		{
			return _repo.Search(id, orderID, merchandiseID, quantity);
		}


		public int Update(OrderListDto dto)
		{
			return _repo.Update(dto);
		}

		public int Delete(int orderID)
		{
			return _repo.Delete(orderID);
		}

	}
}
