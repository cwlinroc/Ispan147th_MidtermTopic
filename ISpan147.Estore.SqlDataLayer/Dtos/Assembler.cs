
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
				PaymentAmount = reader.GetNullableInt("PaymentAmount")
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

		public static Func<SqlDataReader, OrderListGridDto> OrderListGridDtoAssembler
		{
			get => (reader) => new OrderListGridDto
			{
				OrderListID = reader.GetInt("OrderListID"),
				OrderID = reader.GetInt("OrderID"),
				MerchandiseID = reader.GetInt("MerchandiseID"),
				MerchandiseName = reader.GetString("MerchandiseName"),
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
			get => (reader) => new MemberDto
			{
				MemberID = reader.GetInt("memberid"),
				MemberName = reader.GetString("membername"),
				ForumAccountID = reader.GetNullableInt("forumAccountid"),
				NickName = reader.GetString("nickname"),
				DateOfBirth = reader.GetDate("dateofbirth"),
				Gender = reader.GetBool("gender"),
				Account = reader.GetString("account"),
				Password = reader.GetString("password"),
				Phone = reader.GetString("phone"),
				Address = reader.GetString("address"),
				Email = reader.GetString("email"),
				Avatar = reader.GetString("avatar"),
			};
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

		public static Func<SqlDataReader, MerchandiseSearchDto> MerchandiseSearchDtoAssembler
		{
			get => (reader) => new MerchandiseSearchDto
			{
				MerchandiseID = reader.GetInt("MerchandiseId"),
				MerchandiseName = reader.GetString("MerchandiseName"),
				CategoryID = reader.GetInt("CategoryId"),
				CategoryName = reader.GetString("CategoryName"),
				Price = reader.GetInt("Price"),
				Amount = reader.GetInt("Amount"),
				Description = reader.GetString("Description"),
				ImageURL = reader.GetString("ImageURL")
			};
		}

		public static Func<SqlDataReader, CategoryDto> CategoryDtoAssembler
		{
			get => (reader) => new CategoryDto
			{
				CategoryId = reader.GetInt("CategoryId"),
				CategoryName = reader.GetString("CategoryName")
			};
		}
		public static Func<SqlDataReader, QADto.Theme> ThemeDtoAssembler
		{
			get => (reader) => new QADto.Theme
			{
				ThemeId = reader.GetInt("ThemeId"),
				UserId = reader.GetInt("UserId"),
				UserName = reader.GetString("UserName"),
				ThemeDateTime = reader.GetDateTime(reader.GetOrdinal("ThemeDateTime")),
				ThemeContext = reader.GetString("ThemeContext")
			};
		}

		public static Func<SqlDataReader, QADto.Comment> CommentDtoAssembler
		{
			get => (reader) => new QADto.Comment
			{
				ThemeId = reader.GetInt("ThemeId"),
				CommentId = reader.GetInt("CommentId"),
				UserId = reader.GetInt("UserId"),
				UserName = reader.GetString("UserName"),
				CommentDateTime = reader.GetDateTime(reader.GetOrdinal("CommentDateTime")),
				CommentContext = reader.GetString("CommentContext")
			};	
		
		}

	}
}
