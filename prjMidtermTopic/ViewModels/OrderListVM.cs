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
		[Display(Name = "訂單詳情編號")]
		[Required(ErrorMessage = "{0}必填")]
		public int OrderListID { get; set; }

		[Display(Name = "訂單編號")]
		[Required(ErrorMessage = "{0}必填")]
		[RegularExpression(@"^\d+$", ErrorMessage = "{0}請輸入正整數")]
		public string OrderID { get; set; }

		[Display(Name = "商品編號")]
		[Required(ErrorMessage = "{0}必填")]
		[RegularExpression(@"^\d+$", ErrorMessage = "{0}請輸入正整數")]
		public string MerchandiseID { get; set; }

		[Display(Name = "商品名稱")]
		[Required(ErrorMessage = "{0}必填")]
		public string MerchandiseName { get; set; }

		[Display(Name = "數量")]
		[Required(ErrorMessage = "{0}必填")]
		[RegularExpression(@"^\d+$", ErrorMessage = "{0}請輸入正整數")]
		public string Quantity { get; set; }

	}

	static public class OrderLists
	{
		static public OrderListDto ToDto(this OrderListVM vm)
		{
			return new OrderListDto
			{
				OrderListID = vm.OrderListID,
				OrderID = int.Parse(vm.OrderID),
				MerchandiseID = int.Parse(vm.MerchandiseID),
				Quantity = int.Parse(vm.Quantity)
			};
		}

		static public OrderListVM ToVM(this OrderListDto dto)
		{
			return new OrderListVM
			{
				OrderListID = dto.OrderListID,
				OrderID = dto.OrderID.ToString(),
				MerchandiseID = dto.MerchandiseID.ToString(),
				Quantity = dto.Quantity.ToString(),
			};
		}
		//OrderListGridDtotatic
		static public OrderListVM ToVM(this OrderListGridDto dto)
		{
			return new OrderListVM
			{
				OrderListID = dto.OrderListID,
				OrderID = dto.OrderID.ToString(),
				MerchandiseID = dto.MerchandiseID.ToString(),
				MerchandiseName = dto.MerchandiseName,
				Quantity = dto.Quantity.ToString(),
			};
		}

	}

}
