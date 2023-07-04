using ISpan147.Estore.SqlDataLayer.Builders;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class OrderListRepositoryAdoNet : IOrderListRepositoy
	{
		

		public int Create(OrderListDto dto)
		{
			string sql = "INSERT INTO OrderLists (OrderID, MerchandiseId, Quantity)"
				+ " VALUES (@OrderID, @MerchandiseId, @Quantity) ";

			var parameters = new SqlParameterBuilder()
				.AddInt("OrderID", dto.OrderID)
				.AddInt("MerchandiseId", dto.MerchandiseID)
				.AddInt("Quantity", dto.Quantity)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Create(connGetter, sql, parameters);
		}

		public int Delete(int orderID)
		{
			string sql = "DELETE OrderLists WHERE OrderListID = @OrderListID";

			var parameters = new SqlParameterBuilder()
				.AddInt("@OrderListID", orderID)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}

		public OrderListDto Get(int id)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM OrderLists WHERE OrderListID = {id}";
			Func<SqlDataReader, OrderListDto> assembler = Assembler.OrderListDtoAssembler;

			return SqlDb.Get(connGetter, sql, assembler);
		}


		public List<OrderListGridDto> Search(
			int? id = null,
			int? orderID = null,
			int? merchandiseID = null,
			int? quantity = null)
		{
			string sql = $"SELECT OrderListID, OrderID, o.MerchandiseId, MerchandiseName, Quantity "
				+ " FROM OrderLists o "
				+ " JOIN Merchandises m ON o.MerchandiseId = m.MerchandiseId ";
			var parameterBuilder = new SqlParameterBuilder();

			string where = "";

			if (id.HasValue)
			{
				where += " AND OrderListID = @OrderListID ";
				parameterBuilder.AddInt("OrderListID", id.Value);
			}
			if (orderID.HasValue)
			{
				where += " AND OrderID = @OrderID ";
				parameterBuilder.AddInt("OrderID", orderID.Value);
			}
			if (merchandiseID.HasValue)
			{
				where += " AND o.MerchandiseId = @MerchandiseId ";
				parameterBuilder.AddInt("MerchandiseId", merchandiseID.Value);
			}
			if (quantity.HasValue)
			{
				where += " AND Quantity = @Quantity ";
				parameterBuilder.AddInt("Quantity", quantity.Value);
			}
			if (where != "")
			{
				where = " WHERE " + where.Substring(5);
				sql += where;
			}

			var parameters = parameterBuilder.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, OrderListGridDto> assembler = Assembler.OrderListGridDtoAssembler;

			return SqlDb.Search(connGetter, sql, assembler, parameters).ToList();
		}

		public int Update(OrderListDto dto)
		{
			if (dto == null) return 0;

			string sql = "UPDATE OrderLists SET OrderID = @OrderID"
				+ ", MerchandiseId = @MerchandiseId "
				+ ", Quantity = @Quantity "
				+ " WHERE OrderListID = @OrderListID ";

			var parameters = new SqlParameterBuilder()
				.AddInt("OrderID", dto.OrderID)
				.AddInt("MerchandiseId", dto.MerchandiseID)
				.AddInt("Quantity", dto.Quantity)
				.AddInt("OrderListID", dto.OrderListID)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}


	}
}
