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

		public static Func<SqlDataReader, QADto.Theme> ThemeDtoAssembler
		{
			get => (reader) =>
				new QADto.Theme
				{
					ThemeId = reader.GetInt("ThemeId"),
					//ForumAccountId = reader.GetInt("ForumAccountId"),
					//ForumAccountName = reader.GetString("ForumAccountName"),
					ThemeDateTime = reader.GetDateTime(reader.GetOrdinal("ThemeDateTime")),
					ThemeContext = reader.GetString("ThemeContext")//.Length > 50 ?	reader.GetString("ThemeContext").Substring(0, 50) + "..." : reader.GetString("ThemeContext")
				};
		}


		public static Func<SqlDataReader, QADto.Comment> CommentDtoAssembler
		{
			get => (reader) => 
				new QADto.Comment
			{
				//ThemeId = reader.GetInt("ThemeId"),
				CommentId = reader.GetInt("CommentId"),
				CommentTime = reader.GetDateTime(reader.GetOrdinal("CommentTime")),
				CommentContext = reader.GetString("CommentContext").Length > 50 ?
										reader.GetString("CommentContext").Substring(0, 50) + "..." : reader.GetString("CommentContext")
			};

		}

	}
}
