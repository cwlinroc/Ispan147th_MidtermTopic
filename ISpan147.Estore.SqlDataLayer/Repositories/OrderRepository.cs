using ISpan147.Estore.SqlDataLayer.Builders;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class OrderRepository
	{
		public OrderDto Get(int id)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Orders WHERE ID = {id}";
			Func<SqlDataReader, OrderDto> assembler = Assembler.OrderDtoAssembler;

			return SqlDb.Get(connGetter, sql, assembler);
		}

		public List<OrderDto> Search(
			int? orderID = null,
			string customerID = null,
			int? paymentmethod = null,
			bool? payed = null)
		{
			string sql = $"SELECT * FROM Orders ";
			var parameterBuilder = new SqlParameterBuilder();

			string where = "";

			if (orderID.HasValue)
			{
				where += " AND ID = @ID ";
				parameterBuilder.AddInt("ID", orderID.Value);
			}
			if (!string.IsNullOrEmpty(customerID))
			{
				where += " AND CustomerID = @CustomerID ";
				parameterBuilder.AddNVarchar("CustomerID", 15, customerID);
			}
			if (paymentmethod.HasValue)
			{
				where += " AND Paymentmethod = @Paymentmethod ";
				parameterBuilder.AddInt("Paymentmethod", paymentmethod.Value);
			}
			if (payed.HasValue)
			{
				where += " AND Payed = @Payed ";
				parameterBuilder.AddBit("Payed", payed.Value);
			}
			if (where != "")
			{
				where = " WHERE " + where.Substring(5);
				sql += where;
			}

			var parameters = parameterBuilder.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, OrderDto> assembler = Assembler.OrderDtoAssembler;

			return SqlDb.Search(connGetter, sql, assembler, parameters).ToList();
		}

		public int Update(OrderDto dto)
		{
			if (dto == null) return 0;

			string sql = "UPDATE Orders SET CustomerID = @CustomerID"
				+ ", Paymentmethod = @Paymentmethod "
				+ ", Payed = @Payed WHERE ID = @ID ";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("CustomerID", 15, dto.CustomerID)
				.AddInt("Paymentmethod", dto.PaymentMethod)
				.AddBit("Payed", dto.Payed)
				.AddInt("ID", dto.ID)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}

		public int Create(OrderDto dto)
		{
			string sql = "INSERT INTO Orders (CustomerID, Paymentmethod, Payed)"
				+ " VALUES (@CustomerID, @Paymentmethod, @Payed) ";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("CustomerID", 15, dto.CustomerID)
				.AddInt("Paymentmethod", dto.PaymentMethod)
				.AddBit("Payed", dto.Payed)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Create(connGetter, sql, parameters);
		}

		public int Delete(int orderID)
		{
			string sql = "DELETE Orders WHERE ID = @ID";

			var parameters = new SqlParameterBuilder()
				.AddInt("@ID", orderID)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}
	}
}
