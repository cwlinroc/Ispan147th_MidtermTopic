using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.ViewModels
{
	public class PetCreateVM
	{
		[Display(Name = "寵物編號")]
		[Required(ErrorMessage = "{0}為必填")]
		public int PetID { get; set; }

		[Display(Name = "物種編號")]
		[Required(ErrorMessage = "{0}為必填欄位")]
		public string SpeciesID { get; set; }

		[Display(Name = "血統編號")]
		[Required(ErrorMessage = "{0}為必填欄位")]
		public string BreedID { get; set; }

		[Display(Name = "寵物名稱")]
		[Required(ErrorMessage = "{0}為必填欄位")]
		[MaxLength(15,ErrorMessage = "{0}名稱長度不可多於{1}")]
		public string PetName { get; set;}

		[Display(Name = "性別")]
		[Required(ErrorMessage = "{0}為必填欄位")]
		public bool Gender { get; set;}

		[Display(Name = "年齡")]
		[Range(0,50,ErrorMessage = "請確認動物年齡是否超現實，已經活超過半世紀")]
		public string Age {get; set;}

		[Display(Name = "寵物介紹")]
		[MaxLength(500,ErrorMessage ="{0}介紹長度不可多於{1}")]
		public string Description { get; set;}

		[Display(Name = "所在地")]
		[Required(ErrorMessage = "{0}為必填欄位")]
		[MaxLength(30,ErrorMessage ="{0}名稱長度過長")]
		public string Location { get; set;}

		[Display(Name = "寵物照片")]
		[MaxLength(50,ErrorMessage = "{0}路徑過長")]
		public string PetAvatar { get; set;}
	}
}
