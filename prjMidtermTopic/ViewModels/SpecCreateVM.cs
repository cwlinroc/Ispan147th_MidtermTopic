using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prjMidtermTopic.ViewModels
{
	public class SpecCreateVM
	{
		[Display(Name = "規格名稱")]
		[Required(ErrorMessage = "{0}為必填")]
		[MaxLength(30, ErrorMessage = "{0}長度不可超過{1}字")]
		public string SpecName { get; set; }

		[Display(Name = "價格")]
		[Required(ErrorMessage = "{0}為必填")]
		[Range(1, int.MaxValue, ErrorMessage = "{0}必須為大於0的數字")]
		public int Price { get; set; }

		[Display(Name = "庫存數量")]
		[Required(ErrorMessage = "{0}為必填")]
		[Range(0, int.MaxValue, ErrorMessage = "{0}必須是至少為0的數字")]
		public int Amount { get; set; }
	}
}
