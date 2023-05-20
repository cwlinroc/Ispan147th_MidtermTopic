using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ISpan147.Estore.SqlDataLayer.Dtos;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class OrderManager
	{
		private List<OrderDto> _orders = new List<OrderDto>();
		private readonly string[] _payment = new string[] { "會員點數", "信用卡", "LinePay", "Bitcoin" };

		public void Load()
		{
			_orders.Clear();
			_orders.Add(new OrderDto()
			{
				ID = 10001,
				CustomerID = "56421",
				PaymentMethod = 1,
				Payed = true
			});
			_orders.Add(new OrderDto()
			{
				ID = 10002,
				CustomerID = "46521",
				PaymentMethod = 1,
				Payed = true
			});
			_orders.Add(new OrderDto()
			{
				ID = 10003,
				CustomerID = "94267",
				PaymentMethod = 2,
				Payed = true
			});
			_orders.Add(new OrderDto()
			{
				ID = 10004,
				CustomerID = "46521",
				PaymentMethod = 3,
				Payed = true
			});
			_orders.Add(new OrderDto()
			{
				ID = 10005,
				CustomerID = "46521",
				PaymentMethod = 2,
				Payed = false
			});
		}

		public List<OrderGridDto> Search(int? orderID = null, string customerID = null)
		{
			var suborders = new List<OrderDto>(_orders);
			if (orderID.HasValue)
			{
				suborders = suborders.FindAll(o => o.ID == orderID.Value);
			}
			if (!string.IsNullOrEmpty(customerID))
			{
				suborders = suborders.FindAll(o => o.CustomerID == customerID);
			}
			return suborders.Select(o => OriginToGrid(o)).ToList();			
		}

		public void Delete(int orderID)
		{
			var order = _orders.FirstOrDefault(o => o.ID == orderID);
			if (order != null) _orders.Remove(order);
		}

		public void Add(OrderGridDto dto)
		{
			_orders.Add(GridToOrigin(dto));
		}

		public void Update(OrderGridDto gridDto)
		{
			OrderDto order = _orders.FirstOrDefault(o => o.ID == gridDto.ID);
			OrderDto dto = GridToOrigin(gridDto);
			if (order != null)
			{
				order.CustomerID = dto.CustomerID;
				order.PaymentMethod = dto.PaymentMethod;
				order.Payed = dto.Payed;
			}
		}

		private OrderDto GridToOrigin (OrderGridDto gridDto)
		{
			return new OrderDto
			{
				ID = gridDto.ID,
				CustomerID = gridDto.CustomerID,
				PaymentMethod = Array.IndexOf(_payment, gridDto.PaymentMethod),
				Payed = gridDto.Payed
			};
		}
		private OrderGridDto OriginToGrid(OrderDto originDto)
		{
			return new OrderGridDto
			{
				ID = originDto.ID,
				CustomerID = originDto.CustomerID,
				PaymentMethod = _payment[originDto.PaymentMethod],
				Payed = originDto.Payed
			};
		}

	}
}
