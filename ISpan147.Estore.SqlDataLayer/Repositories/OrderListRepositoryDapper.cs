using Dapper;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class OrderListRepositoryDapper : IOrderListRepositoy
	{
		public int Create(OrderListDto dto)
		{
			if (dto == null) return 0;

			string sql = "INSERT INTO OrderLists (OrderID, MerchandiseId, Quantity)"
				+ " OUTPUT INSERTED.OrderListID"
				+ " VALUES (@OrderID, @MerchandiseId, @Quantity) ";

			using (var conn = SqlDb.GetConnection())
			{
				return conn.QuerySingle<int>(sql, dto);
			}
		}

		public int Delete(int orderListID)
		{
			string sql = "DELETE OrderLists OUTPUT DELETED.OrderListID "
				+ " WHERE OrderListID = @OrderListID";

			using (var conn = SqlDb.GetConnection())
			{
				return conn.QuerySingle<int>(sql, new { OrderListID = orderListID });
			}
		}

		public OrderListDto Get(int id)
		{
			string sql = $"SELECT * FROM OrderLists WHERE OrderListID = {id}";

			using (var conn = SqlDb.GetConnection())
			{
				return conn.QuerySingle(sql);
			}
		}

		public List<OrderListGridDto> Search(
			int? id = null,
			int? orderID = null,
			int? merchandiseID = null,
			int? quantity = null)
		{
			string sql = $"SELECT OrderListID, OrderID, o.MerchandiseId, MerchandiseName, Quantity "
				+ " FROM OrderLists o "
				+ " JOIN Merchandises m ON o.MerchandiseId = m.MerchandiseId "
				+ " Where 1 = 1 ";

			if (id != null)
			{
				sql += " AND OrderListID = @OrderListID ";
			}
			if (orderID != null)
			{
				sql += " AND OrderID = @OrderID";
			}
			if (merchandiseID != null)
			{
				sql += " AND o.MerchandiseId = @MerchandiseId ";
			}
			if (quantity != null)
			{
				sql += " AND Quantity = @Quantity ";
			}

			using (var conn = SqlDb.GetConnection())
			{
				return conn.Query<OrderListGridDto>(sql, new
				{
					OrderListID = id,
					OrderID = orderID,
					MerchandiseID = merchandiseID,
					Quantity = quantity
				}).ToList();
			}
		}

		public int Update(OrderListDto dto)
		{
			if (dto == null) return 0;

			string sql = "UPDATE OrderLists SET OrderID = @OrderID"
				+ ", MerchandiseId = @MerchandiseId "
				+ ", Quantity = @Quantity "
				+ " OUTPUT INSERTED.OrderlistID "
				+ " WHERE OrderListID = @OrderListID ";

			using (var conn = SqlDb.GetConnection())
			{
				return conn.QuerySingle<int>(sql, dto);
			}
		}
	}
}
