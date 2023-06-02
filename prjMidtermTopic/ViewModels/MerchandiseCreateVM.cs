using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using ISpan147.Estore.SqlDataLayer.Repositories;
using prjMidtermTopic.form_Category;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace prjMidtermTopic.ViewModels
{
	public class MerchandiseCreateVM
	{
		[Display(Name = "商品編號")]
		public int MerchandiseId { get; set; }

		[Display(Name = "商品名稱")]
		[Required(ErrorMessage = "{0}為必填")]
		[MaxLength(30, ErrorMessage = "{0}長度不可超過{1}字")]
		public string MerchandiseName { get; set; }

		[Display(Name = "商品類別編號")]
		[Required(ErrorMessage = "{0}為必選")]
		public int CategoryID { get; set; }

		[Display(Name = "價格")]
		[Required(ErrorMessage = "{0}為必選")]
		// todo 是否可設定最小值? [Range(1, 99999, ErrorMessage = "{0}的值須介於{1}~{2}之間")]
		public int Price { get; set; }

		[Display(Name = "庫存數量")]
		[Required(ErrorMessage = "{0}為必選")]
		// todo 是否可設定最小值? [Range(1, 999, ErrorMessage = "{0}的值須介於{1}~{2}之間")]
		public int Amount { get; set; }

		[Display(Name = "商品描述")]
		[MaxLength(500, ErrorMessage = "{0}長度不可超過{1}字")]
		public string Description { get; set; }

		[Display(Name = "商品圖片")]
		[MaxLength(50, ErrorMessage = "{0}長度不可超過{1}字")]
		public string ImageURL { get; set; }
	}

	static public class ChooseCategory
	{
		//改由Category資料庫讀取選項		
		//static public readonly int[] categoryIdOptions = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		//static public readonly string[] categoryNameOptions = new string[] {"未選擇", "貓狗>食品保健", "貓狗>清潔耗材", 
		//										"貓狗>器材工具", "貓狗>飾品玩具", "貓狗>房屋器皿", "鼠兔>食品保健", 
		//										"鼠兔>清潔耗材", "鼠兔>器材工具", "鼠兔>飾品玩具", "鼠兔>各類容器" };

		static public MerchandiseDto ToDto(this MerchandiseCreateVM vm) // todo 新增下拉選單參數map
		{

			return new MerchandiseDto
			{
				MerchandiseID = vm.MerchandiseId,
				MerchandiseName = vm.MerchandiseName,
				CategoryID = vm.CategoryID,
				//Array.IndexOf(categoryNameOptions, vm.CategoryID),	// todo 確認是否可如此轉換(P1)
				Price = vm.Price,
				Amount = vm.Amount,
				Description = vm.Description,
				ImageURL = vm.ImageURL
			};
		}

		static public MerchandiseCreateVM ToVM(this MerchandiseDto dto, Dictionary<int, string> map)
		{
			map.TryGetValue(dto.CategoryID, out var categoryId);

			return new MerchandiseCreateVM
			{
				MerchandiseId = dto.MerchandiseID,
				MerchandiseName = dto.MerchandiseName.ToString(),
				CategoryID = dto.CategoryID, // todo 確認是否可如此轉換(P2)
				Price = dto.Price,
				Amount = dto.Amount,
				Description = dto.Description.ToString(),
				ImageURL = dto.ImageURL.ToString()
		};
		}
	}
}
