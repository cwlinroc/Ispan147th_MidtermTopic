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
		[Display(Name = "訂單編號")]
		[Required(ErrorMessage = "{0}必填")]
		public int OrderID { get; set; }

		[Display(Name = "顧客編號")]
		[Required(ErrorMessage = "{0}必填")]
		public string MemberID { get; set; }

		[Display(Name = "顧客姓名")]
		public string MemberName { get; set; }

		[Display(Name = "付款方式")]
		[Required(ErrorMessage = "{0}必填")]
		public string PaymentMethod { get; set; }

		[Display(Name = "付款完畢")]
		[Required(ErrorMessage = "{0}必填")]
		public string Payed { get; set; }

		[Display(Name = "購買時間")]
		[Required(ErrorMessage = "{0}必填")]
		public DateTime? PurchaseTime { get; set; }

		[Display(Name = "付款金額")]
		public string PaymentAmount { get; set; }
	}

	static public class Orders
	{
		static public readonly string[] paymentOptions = new string[] { "會員點數", "信用卡", "LinePay", "Bitcoin" };
		static public readonly string[] payedOptions = new string[] { "尚未付款", "已付款" };
		static public OrderDto ToDto(this OrderVM vm)
		{
			return new OrderDto
			{
				OrderID = vm.OrderID,
				MemberID = int.Parse(vm.MemberID),
				PaymentMethod = Array.IndexOf(paymentOptions, vm.PaymentMethod),
				Payed = vm.Payed == "已付款"
			};
		}
		
		static public OrderVM ToVM(this OrderDto dto)
		{
			return new OrderVM
			{
				OrderID = dto.OrderID,
				MemberID = dto.MemberID.ToString(),
				PaymentMethod = paymentOptions[dto.PaymentMethod],
				Payed = dto.Payed ? "已付款" : "尚未付款"
			};
		}

		static public OrderVM ToVM(this OrderGridDto dto)
		{
			return new OrderVM
			{
				OrderID = dto.OrderID,
				MemberID = dto.MemberID.ToString(),
				MemberName = dto.MemberName,
				PaymentMethod = paymentOptions[dto.PaymentMethod],
				Payed = dto.Payed ? "已付款" : "尚未付款",
				PurchaseTime = dto.PurchaseTime,
				PaymentAmount = dto.PaymentAmount.ToString(),
			};
		}

	}

}
