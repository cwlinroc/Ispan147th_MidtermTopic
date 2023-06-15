using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prjMidtermTopic.ViewModels
{
	public class BrandCreateVM
	{
		[Display(Name = "品牌編號")]
		public int BrandId { get; set; }

		[Display(Name = "品牌名稱")]
		[Required(ErrorMessage = "{0}為必填")]
		[MaxLength(30, ErrorMessage = "{0}長度不可超過{1}字")]
		public string BrandName { get; set; }
	}
}
