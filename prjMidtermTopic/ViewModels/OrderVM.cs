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

	public class OrderVM
	{
		[Display(Name = "編號")]
		[Required(ErrorMessage = "{0}必填")]
		public int ID { get; set; }

		[Display(Name = "顧客編號")]
		[Required(ErrorMessage = "{0}必填")]
		public string CustomerID { get; set; }

		[Display(Name = "付款方式")]
		[Required(ErrorMessage = "{0}必填")]
		public string PaymentMethod { get; set; }

		[Display(Name = "付款完畢")]
		[Required(ErrorMessage = "{0}必填")]
		public string Payed { get; set; }
	}

	static public class Orders
	{
		static public readonly string[] paymentOptions = new string[] { "會員點數", "信用卡", "LinePay", "Bitcoin" };
		static public readonly string[] payedOptions = new string[] { "尚未付款", "已付款" };
		static public OrderDto ToDto(this OrderVM vm)
		{
			return new OrderDto
			{
				ID = vm.ID,
				CustomerID = vm.CustomerID,
				PaymentMethod = Array.IndexOf(paymentOptions, vm.PaymentMethod),
				Payed = vm.Payed == "已付款"
			};
		}

		static public OrderVM ToVM(this OrderDto dto)
		{
			return new OrderVM
			{
				ID = dto.ID,
				CustomerID = dto.CustomerID,
				PaymentMethod = paymentOptions[dto.PaymentMethod],
				Payed = dto.Payed ? "已付款" : "尚未付款"
			};
		}

	}

}
