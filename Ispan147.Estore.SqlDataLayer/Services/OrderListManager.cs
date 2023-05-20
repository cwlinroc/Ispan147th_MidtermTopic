using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan147.Estore.SqlDataLayer.Dtos;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class OrderListManager
	{
		private List<OrderListGridDto> _orderLists = new List<OrderListGridDto>();
		private int _orderListIDCount;
		public void Load()
		{
			_orderLists.Clear();
			_orderLists.Add(new OrderListGridDto
			{
				ID = 1,
				OrderID = 10001,
				MerchadiseID = "976",
				Quantity = 1
			});
			_orderLists.Add(new OrderListGridDto
			{
				ID = 2,
				OrderID = 10002,
				MerchadiseID = "656",
				Quantity = 1
			});
			_orderLists.Add(new OrderListGridDto
			{
				ID = 3,
				OrderID = 10002,
				MerchadiseID = "946",
				Quantity = 3
			});
			_orderLists.Add(new OrderListGridDto
			{
				ID = 4,
				OrderID = 10003,
				MerchadiseID = "348",
				Quantity = 10
			});
			_orderLists.Add(new OrderListGridDto
			{
				ID = 5,
				OrderID = 10003,
				MerchadiseID = "455",
				Quantity = 5
			});
			_orderLists.Add(new OrderListGridDto
			{
				ID = 6,
				OrderID = 10004,
				MerchadiseID = "134",
				Quantity = 2,
			});
			_orderLists.Add(new OrderListGridDto
			{
				ID = 7,
				OrderID = 10005,
				MerchadiseID = "656",
				Quantity = 1,
			});
			_orderListIDCount = 8;
		}

		public List<OrderListGridDto> Search(int? orderListID = null, int? orderID = null, string merchandiseID = null)
		{
			var sublists = new List<OrderListGridDto>(_orderLists);
			if (orderListID.HasValue)
			{
				sublists = sublists.FindAll(o => o.OrderID == orderListID.Value);
			}
			if (orderID.HasValue)
			{
				sublists = sublists.FindAll(o => o.OrderID == orderID.Value);
			}
			if (!string.IsNullOrEmpty(merchandiseID))
			{
				sublists = sublists.FindAll(o => o.MerchadiseID == merchandiseID);
			}
			return sublists;
		}

		public void Delete(int orderListID)
		{
			var order = _orderLists.FirstOrDefault(o => o.ID == orderListID);
			if (order != null) _orderLists.Remove(order);
		}

		public void Add(OrderListGridDto dto)
		{
			dto.ID = _orderListIDCount;
			_orderListIDCount++;
			_orderLists.Add(dto);
		}

		public void Update(OrderListGridDto dto)
		{
			var list = _orderLists.FirstOrDefault(o => o.ID == dto.ID);
			if (list != null)
			{
				list.OrderID = dto.OrderID;
				list.MerchadiseID = dto.MerchadiseID;
				list.Quantity = dto.Quantity;
			}
		}
	}
}
