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
	public class OrderListRepository
	{
		public OrderListDto Get(int id)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM OrderList WHERE OrderListID = {id}";
			Func<SqlDataReader, OrderListDto> assembler = Assembler.OrderListDtoAssembler;

			return SqlDb.Get(connGetter, sql, assembler);
		}

		public List<OrderListDto> Search(
			int? id = null,
			int? orderID = null,
			int? merchandiseID = null,
			int? quantity = null)
		{
			string sql = $"SELECT * FROM OrderList ";
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
				where += " AND MerchandiseID = @MerchandiseID ";
				parameterBuilder.AddInt("MerchandiseID", merchandiseID.Value);
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
			Func<SqlDataReader, OrderListDto> assembler = Assembler.OrderListDtoAssembler;

			return SqlDb.Search(connGetter, sql, assembler, parameters).ToList();
		}

		public int Update(OrderListDto dto)
		{
			if (dto == null) return 0;

			string sql = "UPDATE OrderList SET OrderID = @OrderID"
				+ ", MerchandiseID = @MerchandiseID "
				+ ", Quantity = @Quantity "
				+ " WHERE OrderListID = @OrderListID ";

			var parameters = new SqlParameterBuilder()
				.AddInt("OrderID", dto.OrderID)
				.AddInt("MerchandiseID", dto.MerchandiseID)
				.AddInt("Quantity", dto.Quantity)
				.AddInt("OrderListID", dto.OrderListID)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}

		public int Create(OrderListDto dto)
		{
			string sql = "INSERT INTO OrderList (OrderID, MerchandiseID, Quantity)"
				+ " VALUES (@OrderID, @MerchandiseID, @Quantity) ";

			var parameters = new SqlParameterBuilder()
				.AddInt("OrderID", dto.OrderID)
				.AddInt("MerchandiseID", dto.MerchandiseID)
				.AddInt("Quantity", dto.Quantity)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Create(connGetter, sql, parameters);
		}

		public int Delete(int orderID)
		{
			string sql = "DELETE OrderList WHERE OrderListID = @OrderListID";

			var parameters = new SqlParameterBuilder()
				.AddInt("@OrderListID", orderID)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}
	}
}
