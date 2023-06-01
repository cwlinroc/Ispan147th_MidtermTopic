using System;
using System.ComponentModel.DataAnnotations;

namespace prjMidtermTopic.ViewModels
{
	public class MemberCreateVM
	{
		[Display(Name = "編號")]
		public int MemberID { get; set; }

		[Display(Name = "姓名")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(30, ErrorMessage = "{0}長度不可多於{1}")]
		public string MemberName { get; set; }

		[Display(Name = "暱稱")]
		[MaxLength(30, ErrorMessage = "{0}長度不可多於{1}")]
		public string NickName { get; set; }
				
		[Display(Name = "生日")]
		[Required(ErrorMessage = "{0}必填")]
		[DateTimeRange(100, ErrorMessage = "生日不可早於100年前!")]
		public DateTime DateOfBirth { get; set; }

		[Display(Name = "性別")]
		[Required(ErrorMessage = "{0}必填")]
		public bool? Gender { get; set; }

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
		[MaxLength(20, ErrorMessage = "{0}長度不可多於{1}")]
		public string Phone { get; set; }

		[Display(Name = "地址")]
		[MaxLength(30, ErrorMessage = "{0}長度不可多於{1}")]
		public string Address { get; set; }

		[Display(Name = "Email")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(30, ErrorMessage = "{0}長度不可多於{1}")]
		public string Email { get; set; }

		[Display(Name = "頭像")]
		public string Avatar { get; set; }
	}

	public class DateTimeRangeAttribute : ValidationAttribute
	{
		private readonly DateTime _minDate;

		public DateTimeRangeAttribute(int years)
		{
			_minDate = DateTime.Now.AddYears(-years);
		}

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value is DateTime dateValue)
			{
				if (dateValue < _minDate)
				{
					return new ValidationResult($"生日不可早於 {_minDate:yyyy-MM-dd}", 
						new[] {validationContext.MemberName});
				}
			}
			return ValidationResult.Success;
		}
	}

}
