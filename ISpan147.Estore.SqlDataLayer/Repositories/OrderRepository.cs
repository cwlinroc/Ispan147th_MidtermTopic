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
			string sql = $"SELECT * FROM Orders WHERE OrderID = {id}";
			Func<SqlDataReader, OrderDto> assembler = Assembler.OrderDtoAssembler;

			return SqlDb.Get(connGetter, sql, assembler);
		}

		public List<OrderDto> Search(
			int? orderID = null,
			int? memberID = null,
			int? paymentmethod = null,
			bool? payed = null)
		{
			string sql = $"SELECT * FROM Orders ";
			var parameterBuilder = new SqlParameterBuilder();

			string where = "";

			if (orderID.HasValue)
			{
				where += " AND ID = @OrderID ";
				parameterBuilder.AddInt("OrderID", orderID.Value);
			}
			if (memberID.HasValue				)
			{
				where += " AND MemberID = @MemberID ";
				parameterBuilder.AddInt("MemberID",  memberID.Value);
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

			string sql = "UPDATE Orders SET MemberID = @MemberID"
				+ ", Paymentmethod = @Paymentmethod "
				+ ", Payed = @Payed WHERE OrderID = @OrderID ";

			var parameters = new SqlParameterBuilder()
				.AddInt("MemberID", dto.MemberID)
				.AddInt("Paymentmethod", dto.PaymentMethod)
				.AddBit("Payed", dto.Payed)
				.AddInt("OrderID", dto.OrderID)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}

		public int Create(OrderDto dto)
		{
			string sql = "INSERT INTO Orders (MemberID, Paymentmethod, Payed)"
				+ " VALUES (@MemberID, @Paymentmethod, @Payed) ";

			var parameters = new SqlParameterBuilder().AddInt("MemberID", dto.MemberID)
				.AddInt("Paymentmethod", dto.PaymentMethod)
				.AddBit("Payed", dto.Payed)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Create(connGetter, sql, parameters);
		}

		public int Delete(int orderID)
		{
			string sql = "DELETE Orders WHERE OrderID = @OrderID";

			var parameters = new SqlParameterBuilder()
				.AddInt("@OrderID", orderID)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}
	}
}
