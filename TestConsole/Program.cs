using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System.Dynamic;

namespace TestConsole
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var repo = new OrderRepository();


			//repo.Create(new OrderDto
			//{
			//	CustomerID = "666",
			//	PaymentMethod = 6,
			//	Payed = true
			//});


			//var dtos = repo.Search(null, "666");

			//foreach(var d in dtos)
			//{
			//	Console.WriteLine($"{d.ID}  {d.CustomerID}   {d.PaymentMethod}  {d.Payed} ");
			//}

			//repo.Update(new OrderDto
			//{
			//	ID = 1,
			//	CustomerID = "999",
			//	PaymentMethod = 1,
			//	Payed = false
			//});

			//repo.Delete(4);

			Console.WriteLine("Test Over!");
			Console.ReadKey();
		}
	}
}
