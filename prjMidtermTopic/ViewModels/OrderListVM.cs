﻿using ISpan147.Estore.SqlDataLayer.Dtos;
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
		[RegularExpression(@"^\d+$", ErrorMessage = "{0}請輸入正整數")]
		public string OrderID { get; set; }

		[Display(Name = "商品編號")]
		[Required(ErrorMessage = "{0}必填")]
		[RegularExpression(@"^\d+$", ErrorMessage = "{0}請輸入正整數")]
		public string MerchandiseID { get; set; }

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
				ID = vm.ID,
				OrderID = int.Parse(vm.OrderID),
				MerchandiseID =  vm.MerchandiseID,
				Quantity = int.Parse(vm.Quantity)
			};
		}

		static public OrderListVM ToVM(this OrderListDto dto)
		{
			return new OrderListVM
			{
				ID = dto.ID,
				OrderID = dto.OrderID.ToString(),
				MerchandiseID = dto.MerchandiseID,
				Quantity = dto.Quantity.ToString(),
			};
		}
	}
		
}
