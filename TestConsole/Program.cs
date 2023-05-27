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

			var repo = new OrderListRepositoryLinq();
			//var repo = new OrderListRepositoryAdoNet();
			int id = repo.Delete(10000);

            Console.WriteLine(id);


            Console.WriteLine("Test Over!");
			Console.ReadKey();
			Console.ReadKey();
		}
	}
}
