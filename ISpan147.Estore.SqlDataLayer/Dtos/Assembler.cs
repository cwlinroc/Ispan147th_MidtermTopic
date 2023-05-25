
using ISpan147.Estore.SqlDataLayer.ExtMethods;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public static class Assembler
	{
		public static Func<SqlDataReader, OrderDto> OrderDtoAssembler
		{
			get => (reader) => new OrderDto
			{
				OrderID = reader.GetInt("OrderID"),
				MemberID = reader.GetInt("MemberID"),
				PaymentMethod = reader.GetInt("PaymentMethod"),
				Payed = reader.GetBool("Payed"),
				PurchaseTime = reader.GetDate("PurchaseTime"),
				PaymentAmount = reader.GetInt("PaymentAmount")
			};
		}

		public static Func<SqlDataReader, OrderListDto> OrderListDtoAssembler
		{
			get => (reader) => new OrderListDto
			{
				OrderListID = reader.GetInt("OrderListID"),
				OrderID = reader.GetInt("OrderID"),
				MerchandiseID = reader.GetInt("MerchandiseID"),
				Quantity = reader.GetInt("Quantity")
			};
		}

		public static Func<SqlDataReader, EmployeeDto> EmployeeDtoAssembler
		{
			get => (reader) => new EmployeeDto
			{
				EmployeeAccount = reader.GetString("EmployeeAccount"),
				EmployeePassword = reader.GetString("EmployeePassword"),
				Permission = reader.GetInt("Permission")
			};
		}

		public static Func<SqlDataReader, MemberDto> MemberDtoAssembler
		{
			get
			{
				Func<SqlDataReader, MemberDto> func = (reader) =>
				{
					int id = reader.GetInt("memberid");
					string name = reader.GetString("membername");
					DateTime dob = reader.GetDate("dateofbirth");
					bool gender = reader.GetBool("gender");
					string acc = reader.GetString("account");
					string pwd = reader.GetString("password");
					string phone = reader.GetString("phone");
					string address = reader.GetString("address");
					string email = reader.GetString("email");
					string avatar = reader.GetString("avatar");

					return new MemberDto
					{
						MemberID = id,
						MemberName = name,
						DateOfBirth = dob,
						Gender = gender,
						Account = acc,
						Password = pwd,
						Phone = phone,
						Address = address,
						Email = email,
						Avatar = avatar,
					};
				};
				return func;

			}
		}

		public static Func<SqlDataReader, MerchandiseDto> MerchandiseDtoAssembler
		{
			get => (reader) => new MerchandiseDto
			{
				MerchandiseID = reader.GetInt("MerchandiseId"),
				MerchandiseName = reader.GetString("MerchandiseName"),
				CategoryID = reader.GetInt("CategoryId"),
				Price = reader.GetInt("Price"),
				Amount = reader.GetInt("Amount"),
				Description = reader.GetString("Description"),
				ImageURL = reader.GetString("ImageURL")
			};
		}
	}
}
