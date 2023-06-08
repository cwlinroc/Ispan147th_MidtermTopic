using Dapper;
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

	public class OrderRepository : IOrderRepository
	{
		public OrderDto Get(int id)
		{
			string sql = $"SELECT * FROM Orders WHERE OrderID = {id}";

			using (var conn = SqlDb.GetConnection())
			{
				return conn.QuerySingle(sql);
			}
		}

		public IEnumerable<OrderGridDto> Search(OrderSearchDto sDto)
		{
			if (sDto == null) return null;

			string top = string.Empty;

			if (string.IsNullOrEmpty(sDto.OrderBy)) sDto.OrderBy = "OrderID";

			if (sDto.MaxQueryNumber != null)
			{
				top = $" TOP {sDto.MaxQueryNumber} ";
			}

			string orderBy = (sDto.Descending) ? $" ORDER BY {sDto.OrderBy} DESC " : $" ORDER BY {sDto.OrderBy} ";

			string sql = $" SELECT {top} OrderID , o.MemberID , MemberName "
					+ " , PaymentMethod ,Payed ,PurchaseTime , PaymentAmount "
					+ " FROM Orders o "
					+ " JOIN Members m ON m.MemberID = o.MemberID "
					+ " WHERE 1 = 1 ";

			#region --條件式--

			if (sDto.OrderID != null)
			{
				sql += " AND OrderID = @OrderID ";
			}
			if (sDto.MemberID != null)
			{
				sql += " AND o.MemberID = @MemberID ";
			}
			if (sDto.MemberName != null)
			{
				sql += " AND MemberName LIKE '%'+@MemberName+'%' ";
			}
			if (sDto.PurchaseTime != null)
			{
				sql += " AND PurchaseTime >= @PurchaseTime ";
			}
			if (sDto.PaymentMethod != null)
			{
				sql += " AND PaymentMethod = @PaymentMethod ";
			}
			if (sDto.Payed != null)
			{
				sql += " AND Payed = @Payed ";
			}
			if (sDto.MinPaymentAmount != null)
			{
				sql += " AND PaymentAmount >= @MinPaymentAmount ";
			}
			if (sDto.MaxPaymentAmount != null)
			{
				sql += " AND PaymentAmount <= @MaxPaymentAmount ";
			}

			#endregion

			sql += orderBy;

			using (var conn = SqlDb.GetConnection())
			{
				return conn.Query<OrderGridDto>(sql, sDto);
			}
		}

		public int Update(OrderDto dto)
		{
			if (dto == null) return -1;

			string sql = "UPDATE Orders SET MemberID = @MemberID"
					+ ", Paymentmethod = @Paymentmethod "
					+ ", Payed = @Payed"
					+ ", PurchaseTime = @PurchaseTime"
					+ ", PaymentAmount = @PaymentAmount "
					+ "OUTPUT INSERTED.OrderID WHERE OrderID = @OrderID ";

			using (var conn = SqlDb.GetConnection())
			{
				return conn.QuerySingle<int>(sql, dto);
			}
		}

		public int Create(OrderDto dto)
		{
			string strSql = DapperStringCreator.Insert(dto, "Orders", "OrderID");

			using (var conn = SqlDb.GetConnection())
			{
				int result = conn.QuerySingle<int>(strSql, dto);
				return result;
			}
		}

		public int Delete(int OrderID)
		{
			string strSql = "DELETE Orders OUTPUT DELETED.OrderID WHERE OrderID = @OrderID";

			using (var conn = SqlDb.GetConnection())
			{
				return conn.QuerySingle<int>(strSql, new { OrderID = OrderID });
			}
		}

		

	}
}
