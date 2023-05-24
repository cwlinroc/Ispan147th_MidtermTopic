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
				string strSql = "INSERT INTO Member"
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

		public void CreateOrder(OrderDto dto)
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = "INSERT INTO Orders"
					+ " ( CustomerID,  PaymentMethod,  Payed) "
					+ " VALUES ( @CustomerID,  @PaymentMethod,  @Payed)";

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
				string strSql = $"SELECT MemberID FROM Member ";

				var result = conn.Query<int>(strSql);

				return result;
			}
		}

		public IEnumerable<int> GetAllMerchandiseID()
		{
			using (var conn = SqlDb.GetConnection())
			{
				string strSql = $"SELECT MerchandiseID FROM Merchandise ";

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
