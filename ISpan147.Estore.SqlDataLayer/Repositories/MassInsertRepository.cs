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
					+ " (MemberName, DateOfBirth, Gender, Account,"
					+ " Password, Phone, Address, Email, Avatar)"
					+ " VALUES (@MemberName, @DateOfBirth, @Gender, @Account,"
					+ " @Password, @Phone, @Address, @Email, @Avatar)";

				conn.Execute(strSql, dto);
			}
		}

		public void CreatePet(PetDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO Pet"
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
				string strSql = "INSERT INTO Orders"
					+ " ( MemberID,  PaymentMethod,  Payed) "
					+ " OUTPUT INSERTED.OrderID"
					+ " VALUES ( @MemberID,  @PaymentMethod,  @Payed)";

				int result = conn.QuerySingle<int>(strSql, dto);
				return result;
			}
		}

		public void CreateOrderList(OrderListDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO OrderList (OrderID, MerchandiseID, Quantity)"
				+ " VALUES (@OrderID, @MerchandiseID, @Quantity) ";

				conn.Execute(strSql, dto);
			}
		}

		public void CreateMerchandise(MerchandiseDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO Merchandises"
					+ " ( MerchandiseName, CategoryID, Price,"
					+ " Amount, Description, ImageURL )"
					+ " VALUES ( @MerchandiseName, @CategoryID, @Price,"
					+ " @Amount, @Description, @ImageURL )";

				conn.Execute(strSql, dto);
			}
		}

		public int CreateTheme(ThemeDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO Theme "
					+ " ( ThemeName, ThemeDateTime, ThemeContext )"
					+ " OUTPUT INSERTED.ThemeID"
					+ " VALUES ( @ThemeName, @ThemeDateTime, @ThemeContext )";

				int result = conn.QuerySingle<int>(strSql, dto);
				return result;
			}
		}

		public void CreateCommon(CommonDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO Common "
					+ " ( CommonName, CommonTime, CommonContext, ThemeID )"
					+ " VALUES ( @CommonName, @CommonTime, @CommonContext, @ThemeID )";

				conn.Execute(strSql, dto);
			}
		}


		public void CreateAdopt(AdoptDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO Adopt "
					+ " ( PetID, MemberID, ApplicationTime )"
					+ " VALUES ( @PetID, @MemberID, @ApplicationTime )";

				conn.Execute(strSql, dto);
			}
		}


		public IEnumerable<int> GetBreedIDs(int speciesID)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = $"SELECT BreedID FROM Breed WHERE SpeciesID = @SpeciesID";

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
				string strSql = $"SELECT PetID FROM Pet ";

				var result = conn.Query<int>(strSql);

				return result;
			}
		}

		public IEnumerable<int> GetAllMerchandiseID()
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = $"SELECT MerchandiseID FROM Merchandises ";

				var result = conn.Query<int>(strSql);

				return result;
			}
		}


		public IEnumerable<MemberDto> GetAllMemberDtos()
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = $"SELECT * FROM Member ";

				var result = conn.Query<MemberDto>(strSql);

				return result;
			}

		}





	}




}
