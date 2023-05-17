using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.Model
{
	public class MerchandiseOrderManager
	{
		private List<MerchandiseOrderDto> _orders = new List<MerchandiseOrderDto>();
		public void load()
		{
			_orders.Clear();
			_orders.Add(new MerchandiseOrderDto()
			{
				orderID = 10001,
				customerID = "56421",
				paymentMethod = 1,
				payed = true
			});
			_orders.Add(new MerchandiseOrderDto()
			{
				orderID = 10002,
				customerID = "46521",
				paymentMethod = 1,
				payed = true
			});
			_orders.Add(new MerchandiseOrderDto()
			{
				orderID = 10003,
				customerID = "94267",
				paymentMethod = 2,
				payed = true
			});
			_orders.Add(new MerchandiseOrderDto()
			{
				orderID = 10004,
				customerID = "46521",
				paymentMethod = 3,
				payed = true
			});
			_orders.Add(new MerchandiseOrderDto()
			{
				orderID = 10005,
				customerID = "46521",
				paymentMethod = 2,
				payed = false
			});
		}

		public List<MerchandiseOrderDto> search(int? orderID = null, string customerID = null)
		{
			var suborders = new List<MerchandiseOrderDto>(_orders);
			if (orderID.HasValue)
			{
				suborders = suborders.FindAll(o => o.orderID == orderID.Value);
			}
			if (!string.IsNullOrEmpty(customerID))
			{
				suborders = suborders.FindAll(o => o.customerID == customerID);
			}
			return suborders;
		}

		public void delete(int orderID)
		{
			var order = _orders.FirstOrDefault(o => o.orderID == orderID);
			if (order != null) _orders.Remove(order);
		}

		public void add(MerchandiseOrderDto dto)
		{
			_orders.Add(dto);
		}

		public void update(MerchandiseOrderDto dto)
		{
			var order = _orders.FirstOrDefault(o => o.orderID == dto.orderID);
			if (order != null)
			{
				order.customerID = dto.customerID;
				order.paymentMethod = dto.paymentMethod;
				order.payed = dto.payed;
			}
		}
	}
}
