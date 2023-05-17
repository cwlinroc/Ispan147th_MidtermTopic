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
				orderID = 10001,
				merchadiseID = "976",
				quantity = 1
			});
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderID = 10002,
				merchadiseID = "656",
				quantity = 1
			});
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderID = 10002,
				merchadiseID = "946",
				quantity = 3
			});
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderID = 10003,
				merchadiseID = "348",
				quantity = 10
			});
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderID = 10003,
				merchadiseID = "455",
				quantity = 5
			});
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderID = 10004,
				merchadiseID = "134",
				quantity = 2,
			});
			_orderLists.Add(new MerchandiseOrderListDto
			{
				orderID = 10005,
				merchadiseID = "656",
				quantity = 1,
			});
		}

		public List<MerchandiseOrderListDto> search(int? orderID = null, string merchandiseID = null)
		{
			var sublists = new List<MerchandiseOrderListDto>(_orderLists);
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

		public void delete(int orderID, string merchandiseID)
		{
			var order = _orderLists.FirstOrDefault(
				o => o.orderID == orderID && o.merchadiseID == merchandiseID);
			if (order != null) _orderLists.Remove(order);
		}

		public void add(MerchandiseOrderListDto dto)
		{
			_orderLists.Add(dto);
		}

		public void update(MerchandiseOrderListDto dto)
		{
			var list = _orderLists.FirstOrDefault(o => o.orderID == dto.orderID);
			if (list != null)
			{
				list.merchadiseID = dto.merchadiseID;
				list.quantity = dto.quantity;
			}
		}
	}
}
