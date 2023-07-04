using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class MassInsertRepository
	{
		public void CreateMember(MemberDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO Members"
					+ " (MemberName, NickName, DateOfBirth, Gender, Account,"
					+ " Password, Phone, Address, Email, Avatar)"
					+ " VALUES (@MemberName, @NickName, @DateOfBirth, @Gender, @Account,"
					+ " @Password, @Phone, @Address, @Email, @Avatar)";

				conn.Execute(strSql, dto);
			}
		}

		public void CreatePet(PetDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO Pets"
					+ " ( SpeciesID,  BreedID,  PetName,"
					+ " Gender,  Age,  Description, Location) "
					+ " VALUES ( @SpeciesID,  @BreedID,  @PetName,"
					+ " @Gender,  @Age,  @Description, @Location)";

				conn.Execute(strSql, dto);
			}
		}

		public int CreateOrder(OrderDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = DapperStringCreator.Insert(dto, "Orders", "OrderID");

				int result = conn.QuerySingle<int>(strSql, dto);
				return result;
			}
		}

		public void CreateOrderList(OrderListDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO OrderLists (OrderID, MerchandiseId, Quantity)"
				+ " VALUES (@OrderID, @MerchandiseId, @Quantity) ";

				conn.Execute(strSql, dto);
			}
		}

		public void CreateMerchandise(MerchandiseDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO Merchandises"
					+ " ( MerchandiseName, CategoryId, Price,"
					+ " Amount, Description, ImageURL )"
					+ " VALUES ( @MerchandiseName, @CategoryId, @Price,"
					+ " @Amount, @Description, @ImageURL )";

				conn.Execute(strSql, dto);
			}
		}

		public int CreateForumAccount(ForumAccountDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO ForumAccounts "
					+ " ( ForumAccountName )"
					+ " OUTPUT INSERTED.ForumAccountID"
					+ " VALUES ( @ForumAccountName )";

				int result = conn.QuerySingle<int>(strSql, dto);
				return result;
			}
		}

		public void UpdateForumAccountID(int MemberID, int ForumAccountID)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "Update Members "
					+ $" SET ForumAccountID = {ForumAccountID} "
					+ $" WHERE MemberID = {MemberID}";

				conn.Execute(strSql);
			}
		}


		public int CreateTheme(ThemeDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO Themes "
					//+ " ( ThemeName, ThemeDateTime, ThemeContext, ForumAccountID )"
					+ " ( ThemeDateTime, ThemeContext, ForumAccountID )"
					+ " OUTPUT INSERTED.ThemeID"
					+ " VALUES ( @ThemeDateTime, @ThemeContext, @ForumAccountID )";
					//+ " VALUES ( @ThemeName, @ThemeDateTime, @ThemeContext, @ForumAccountID )";

				int result = conn.QuerySingle<int>(strSql, dto);
				return result;
			}
		}

		public void CreateCommon(CommentDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO Comments "
					+ " ( ForumAccountID, CommentTime,CommentContext, ThemeID )"
					+ " VALUES ( @ForumAccountID, @CommentTime, @CommentContext, @ThemeID )";

				conn.Execute(strSql, dto);
			}
		}

		public void CreateAdopt(AdoptDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO Adopts "
					+ " ( PetID, MemberID, ApplicationTime )"
					+ " VALUES ( @PetID, @MemberID, @ApplicationTime )";

				conn.Execute(strSql, dto);
			}
		}


		public IEnumerable<int> GetBreedIDs(int speciesID)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = $"SELECT BreedID FROM Breeds WHERE SpeciesID = @SpeciesID";

				var parameters = new { SpeciesID = speciesID };

				var result = conn.Query<int>(strSql, parameters);

				return result;
			}
		}


		public IEnumerable<int> GetAllMemberID()
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = $"SELECT MemberID FROM Members ";

				var result = conn.Query<int>(strSql);

				return result;
			}
		}

		public IEnumerable<int> GetAllPetID()
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = $"SELECT PetID FROM Pets ";

				var result = conn.Query<int>(strSql);

				return result;
			}
		}

		public IEnumerable<int> GetAllMerchandiseID()
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = $"SELECT MerchandiseId FROM Merchandises ";

				var result = conn.Query<int>(strSql);

				return result;
			}
		}
		public IEnumerable<int> GetAllOrderID()
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = $"SELECT OrderID FROM Orders ";

				var result = conn.Query<int>(strSql);

				return result;
			}
		}

		public IEnumerable<int> GetAllForumAccountID()
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = $"SELECT ForumAccountID FROM ForumAccounts";

				var result = conn.Query<int>(strSql);

				return result;
			}
		}
		public IEnumerable<MemberDto> GetAllMemberDtos()
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = $"SELECT * FROM Members ";

				var result = conn.Query<MemberDto>(strSql);

				return result;
			}

		}

		public int GetTotalPrice(int orderID)
		{
			string sql = "SELECT SUM(Quantity * Price)"
				+ " From Orders t1 "
				+ " JOIN OrderLists t2 ON t1.OrderID = t2.OrderID "
				+ " JOIN Merchandises t3 ON t2.MerchandiseId = t3.MerchandiseId "
				+ $" WHERE t1.OrderID = {orderID} "
				+ " GROUP BY t1.OrderID";

			using (var conn = SqlDb.GetConnection())
			{
				return conn.QuerySingle<int>(sql);
			}
		}

		public int UpdateOrder(OrderDto dto)
		{
			if (dto == null) return -1;

			string sql = " UPDATE Orders SET "
					+ " Payed = @Payed, "
					+ " PaymentAmount = @PaymentAmount "
					+ " OUTPUT INSERTED.OrderID WHERE OrderID = @OrderID ";

			using (var conn = SqlDb.GetConnection())
			{
				return conn.QuerySingle<int>(sql, dto);
			}
		}


	}




}
