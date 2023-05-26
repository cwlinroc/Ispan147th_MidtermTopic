using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System.Dynamic;
using ISpan147.Estore.SqlDataLayer.ExtMethods;
using System.Security.Principal;
using static System.Net.Mime.MediaTypeNames;
using ISpan147.Estore.SqlDataLayer.Utility;
using ISpan147.Estore.SqlDataLayer.Services;
using ISpan147.Estore.SqlDataLayer.EFModel;

namespace TestConsole
{
	internal class Program
	{
		static void Main(string[] args)
		{


			//var mass = new MassInsertService();

			//mass.CreateRandomMembers(400);
			//會員

			//mass.CreateRandomMerchandise(200);
			//商品

			//mass.CreateRandomPets(100);
			//寵物

			//mass.CreateRandomOrderAndOrderList(500);
			//訂單和訂單明細

			//mass.CreateRandomThemeAndCommon(150);
			//QA

			//mass.CreateRandomAdopt(150);
			//領養清單


			var dto = new OrderSearchDto
			{
				MemberID = 12,
				MemberName = "fad",
				Payed = true,
				PurchaseTime = DateTime.Now,
				//		public int? OrderID { get; set; }
				//[Table("Orders")]
				//public int? MemberID { get; set; }
				//public string MemberName { get; set; }
				//public int? PaymentMethod { get; set; }
				//public bool? Payed { get; set; }
				//public DateTime? PurchaseTime { get; set; }
				//public int? PaymentAmount { get; set; }
			};

			string str = DapperStringCreator.Where(dto);

            Console.WriteLine(str);

			str = DapperStringCreator.Insert(dto, "table");

			Console.WriteLine(str);

			Console.WriteLine("Test Over!");
			Console.ReadKey();
			Console.ReadKey();
		}
	}
}
