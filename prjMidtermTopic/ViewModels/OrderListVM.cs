using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prjMidtermTopic.ViewModels
{
	public class OrderListVM
	{
		[Display(Name = "編號")]
		[Required(ErrorMessage = "{0}必填")]
		public int ID { get; set; }

		[Display(Name = "訂單編號")]
		[Required(ErrorMessage = "{0}必填")]
		public int OrderID { get; set; }

		[Display(Name = "商品編號")]
		[Required(ErrorMessage = "{0}必填")]
		public string MerchandiseID { get; set; }

		[Display(Name = "數量")]
		[Required(ErrorMessage = "{0}必填")]
		public int Quantity { get; set; }

		public OrderListVM() { }

		public OrderListVM(OrderListDto dto)
		{
			ID = dto.ID;
			OrderID = dto.OrderID;
			MerchandiseID = dto.MerchandiseID;
			Quantity = dto.Quantity;
		}

		public OrderListDto ToDto()
		{
			return new OrderListDto
			{
				ID = this.ID,
				OrderID = this.OrderID,
				MerchandiseID = this.MerchandiseID,
				Quantity = this.Quantity
			};
		}
	}
		
}
