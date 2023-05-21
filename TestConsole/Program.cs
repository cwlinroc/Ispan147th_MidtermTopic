using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System.Dynamic;
using ISpan147.Estore.SqlDataLayer.ExtMethods;

namespace TestConsole
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//var repo = new OrderRepository();

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


			new EmployeeRepositoy().Create(new EmployeeDto
			{
				Account = "admin",
				Password = "admin".GetSaltedSha256(),
				Permission = 1
			});
			var dto = new EmployeeRepositoy().Get("admin");
			Console.WriteLine(dto.Password);
			Console.WriteLine("admin".GetSaltedSha256());
			Console.WriteLine("admin".GetSaltedSha256().Length);

			Console.WriteLine("Test Over!");
			Console.ReadKey();
		}
	}
}
