using ISpan147.Estore.SqlDataLayer.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class OrderListDto
	{
		public int OrderListID { get; set; }
		public int OrderID { get; set; }
		public int MerchandiseID { get; set; }
		public int Quantity { get; set; }
	}

	static public class OrderListDtoEF
	{
		static public OrderList ToEF(this OrderListDto dto)
		{
			return new OrderList
			{
				OrderListID = dto.OrderListID,
				OrderID = dto.OrderID,
				MerchandiseID = dto.MerchandiseID,
				Quantity = dto.Quantity
			};
		}

		static public OrderListDto ToDto(this OrderList ef)
		{
			return new OrderListDto
			{
				OrderListID = ef.OrderListID,
				OrderID = ef.OrderID,
				MerchandiseID = ef.MerchandiseID,
				Quantity = ef.Quantity
			};
		}

		static public void ChangeByDto(this OrderList ef, OrderListDto dto)
		{
			ef.OrderListID = dto.OrderListID;
			ef.OrderID = dto.OrderID;
			ef.MerchandiseID = dto.MerchandiseID;
			ef.Quantity = dto.Quantity;
		}
	}

}
