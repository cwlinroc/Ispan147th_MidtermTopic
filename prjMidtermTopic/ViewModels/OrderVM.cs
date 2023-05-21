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
		private readonly string[] _payment = new string[] { "會員點數", "信用卡", "LinePay", "Bitcoin" };

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
		public bool Payed { get; set; }


		public OrderVM() { }
		public OrderVM(OrderDto dto)
		{
			ID = dto.ID; 
			CustomerID = dto.CustomerID;
			PaymentMethod = _payment[dto.PaymentMethod];
			Payed = dto.Payed;
		}

		public OrderDto ToDto()
		{
			return new OrderDto { 
				ID = this.ID,
				CustomerID = this.CustomerID,
				PaymentMethod = Array.IndexOf(_payment,this.PaymentMethod),
				Payed = this.Payed
			};
		}
	}
}
