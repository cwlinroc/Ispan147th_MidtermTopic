using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prjMidtermTopic.ViewModels
{
	public class QAVM
	{
		[Display(Name = "主題內容")]
		[Required(ErrorMessage = "{0}必填")]
		public string ThemeContext { get; set; }

		[Display(Name = "回覆內容")]
		[Required(ErrorMessage = "{0}必填")]
		public string CommentContext { get; set; }

	}
}
