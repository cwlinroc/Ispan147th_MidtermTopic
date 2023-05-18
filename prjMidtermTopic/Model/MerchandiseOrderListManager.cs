using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.Model
{
	public class MerchandiseOrderListManager
	{
		private List<MerchandiseOrderListDto> _orderLists = new List<MerchandiseOrderListDto>();

		public void load()
		{
			_orderLists.Clear();
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderListID = 1,
				orderID = 10001,
				merchadiseID = "976",
				quantity = 1
			});
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderListID = 2,
				orderID = 10002,
				merchadiseID = "656",
				quantity = 1
			});
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderListID = 3,
				orderID = 10002,
				merchadiseID = "946",
				quantity = 3
			});
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderListID = 4,
				orderID = 10003,
				merchadiseID = "348",
				quantity = 10
			});
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderListID = 5,
				orderID = 10003,
				merchadiseID = "455",
				quantity = 5
			});
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderListID = 6,
				orderID = 10004,
				merchadiseID = "134",
				quantity = 2,
			});
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderListID = 7,
				orderID = 10005,
				merchadiseID = "656",
				quantity = 1,
			});
		}

		public List<MerchandiseOrderListDto> search(int? orderListID = null, int? orderID = null, string merchandiseID = null)
		{
			var sublists = new List<MerchandiseOrderListDto>(_orderLists);
			if (orderListID.HasValue)
			{
				sublists = sublists.FindAll(o => o.orderID == orderListID.Value);
			}
			if (orderID.HasValue)
			{
				sublists = sublists.FindAll(o => o.orderID == orderID.Value);
			}
			if (!string.IsNullOrEmpty(merchandiseID))
			{
				sublists = sublists.FindAll(o => o.merchadiseID == merchandiseID);
			}
			return sublists;
		}

		public void delete(int orderListID)
		{
			var order = _orderLists.FirstOrDefault(o => o.orderListID == orderListID);
			if (order != null) _orderLists.Remove(order);
		}

		public void add(MerchandiseOrderListDto dto)
		{
			_orderLists.Add(dto);
		}

		public void update(MerchandiseOrderListDto dto)
		{
			var list = _orderLists.FirstOrDefault(o => o.orderListID == dto.orderListID);
			if (list != null)
			{
				list.orderID = dto.orderID;
				list.merchadiseID = dto.merchadiseID;
				list.quantity = dto.quantity;
			}
		}
	}
}
