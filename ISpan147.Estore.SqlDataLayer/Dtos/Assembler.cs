﻿using Ispan147.Estore.SqlDataLayer.Dtos;
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
				ID = reader.GetInt("OrderID"),
				CustomerID = reader.GetString("CustomerID"),
				PaymentMethod = reader.GetInt("PaymentMethod"),
				Payed = reader.GetBool("Payed")
			};
		}

		public static Func<SqlDataReader, OrderListDto> OrderListDtoAssembler
		{
			get => (reader) => new OrderListDto
			{
				ID = reader.GetInt("OrderListID"),
				OrderID = reader.GetInt("OrderID"),
				MerchandiseID = reader.GetString("MerchandiseID"),
				Quantity = reader.GetInt("Quantity")
			};
		}

		public static Func<SqlDataReader, EmployeeDto> EmployeeDtoAssembler
		{
			get => (reader) => new EmployeeDto
			{
				Account = reader.GetString("EmployeeAccount"),
				Password = reader.GetString("EmployeePassword"),
				Permission = reader.GetInt("Permission")
			};
		}

		public static Func<SqlDataReader, MemberDto> MemberDtoAssembler
		{
			get
			{
				Func<SqlDataReader, MemberDto> func = (reader) =>
				{
					int id = reader.GetInt("id");
					string name = reader.GetString("name");
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
						ID = id,
						Name = name,
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

	}
}
