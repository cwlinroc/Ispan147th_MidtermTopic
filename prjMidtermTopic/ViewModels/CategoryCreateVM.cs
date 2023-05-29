using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prjMidtermTopic.ViewModels
{
	public class CategoryCreateVM
	{
		[Display(Name = "類別編號")]
		public int CategoryId { get; set; }

		[Display(Name = "類別名稱")]
		[Required(ErrorMessage = "{0}為必填")]
		[MaxLength(30, ErrorMessage = "{0}長度不可超過{1}字")]
		public string CategoryName { get; set; }
	}
}
