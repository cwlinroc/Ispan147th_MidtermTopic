using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Ispan147.Estore.SqlDataLayer.Dtos.MemberDto;

namespace prjMidtermTopic.ViewModels
{
	public class MemberCreateVM
	{
		[Display(Name = "編號")]
		public int Id { get; set; }

		[Display(Name = "姓名")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(30, ErrorMessage = "{0}長度不可多於{1}")]
		public string Name { get; set; }

		[Display(Name = "生日")]
		public DateTime DateOfBirth { get; set; }

		[Display(Name = "性別")]
		public GenderType Gender { get; set; }

		[Display(Name = "帳號")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(15, ErrorMessage = "{0}長度不可多於{1}")]
		public string Account { get; set; }

		[Display(Name = "密碼")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(65, ErrorMessage = "{0}長度不可多於{1}")]
		public string Password { get; set; }

		[Display(Name = "手機號碼")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(10, ErrorMessage = "{0}長度不可多於{1}")]
		public string Phone { get; set; }

		[Display(Name = "地址")]		
		public string Address { get; set; }

		[Display(Name = "Email")]
		[Required(ErrorMessage = "{0}必填")]
		public string Email { get; set; }

		[Display(Name = "頭像")]
		public string Avatar { get; set; }
	}
}
