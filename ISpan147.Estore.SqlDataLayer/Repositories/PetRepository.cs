using ISpan147.Estore.SqlDataLayer.Builders;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjMidtermTopic.Interfaces;
using System.Runtime.InteropServices;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class PetRepository : IPetRepo
	{

		#region 用編號查資料
		public PetDto GetByID(int PetID)
		{
			string sql = $"SELECT * FROM Pets WHERE PetID = {PetID}";
			Func<SqlDataReader, PetDto> func = Assembler.PetDtoAssembler;
			SqlParameter[] parameters = new SqlParameter[0];
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Get(connGetter, sql, func, parameters);
		}
		#endregion

		#region 用名字找資料
		public PetDto GetByName(string name)
		{
			string sql = $"SELECT * FROM Pets WHERE PetName = @PetName";
			Func<SqlDataReader, PetDto> func = Assembler.PetDtoAssembler;

			SqlParameter parameter = new SqlParameter("@PetName", SqlDbType.NVarChar, 15)
			{
				Value = name
			};

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Get(connGetter, sql, func, parameter);
		}
		#endregion

		#region 查資料
		public List<PetDto> Search(int? PetID, String s_name)
		{
			string sql = $"SELECT * FROM Pets";

			var builder = new SqlParameterBuilder();

			string where = string.Empty;
			if (PetID.HasValue)
			{
				where += $" AND PetID = @PetID";
				builder.AddInt("PetID", PetID.Value);
			}

			if (string.IsNullOrEmpty(s_name) == false)
			{
				where = $" AND PetName LIKE '%' + @PetName + '%'";
				builder.AddNVarchar("PetName", 15, s_name);
			}

			if (string.IsNullOrEmpty(where) == false)
			{
				where = " WHERE " + where.Substring(5);
				sql += where;
			}

			var parameters = builder.Build().ToArray();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, PetDto> func = Assembler.PetDtoAssembler;

			return SqlDb.Search(connGetter, sql, func, parameters).ToList();
		}
		#endregion

		#region 用物種找資料
		public List<SpeciesDto> SearchSpecies(int? spceiesID)
		{
			string sql = $"SELECT * FROM Species";

			var builder = new SqlParameterBuilder();

			string where = string.Empty;

			if (spceiesID.HasValue)
			{
				where += $" WHERE SpeciesID = @SpeciesID";
				builder.AddInt("SpeciesID", spceiesID.Value);
			}

			sql += where;

			var parameters = builder.Build().ToArray();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, SpeciesDto> func = Assembler.SpeciesDtoAssembler;

			return SqlDb.Search(connGetter, sql, func, parameters).ToList();
		}
		#endregion

		#region 用血統找資料
		public List<BreedDto> SearchBreed(int? breedID)
		{
			string sql = $"SELECT * FROM Breeds";

			var builder = new SqlParameterBuilder();

			string where = string.Empty;
			if (breedID.HasValue)
			{
				where += $" WHERE BreedID = @BreedID";
				builder.AddInt("BreedID", breedID.Value);
			}

			sql += where;

			var parameters = builder.Build().ToArray();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			Func<SqlDataReader, BreedDto> func = Assembler.BreedDtoAssembler;

			return SqlDb.Search(connGetter, sql, func, parameters).ToList();
		}
		#endregion

		#region 建資料
		public int Create(PetDto dto)
		{
			string sql = @"INSERT INTO Pets 
(SpeciesID, BreedID, PetName, Gender, Age, Description, Location, PetAvatar)
VALUES 
(@SpeciesID, @BreedID, @PetName, @Gender, @Age, @Description, @Location, @PetAvatar)";

			var parameters = new SqlParameterBuilder()
				.AddInt("@SpeciesID", dto.SpeciesID)
				.AddInt("@BreedID", dto.BreedID)
				.AddNVarchar("@PetName", 15, dto.PetName)
				.AddBit("@Gender", dto.Gender)
				.AddInt("@Age", dto.Age)
				.AddNVarchar("@Description", 500, dto.Description)
				.AddNVarchar("@Location", 30, dto.Description)
				.AddNVarchar("@PetAvatar", 50, dto.PetAvatar)
				.Build();

			return SqlDb.Create(SqlDb.GetConnection, sql, parameters);
		}
		#endregion

		#region 修資料
		public int Update(PetDto dto)
		{
			string sql = "UPDATE Pets SET SpeciesID = @SpeciesID, BreedID = BreedID, PetName = @PetName, Gender = @Gender," +
				"Age = @Age, Description = @Description, Location = @Location," +
				"PetAvatar = @PetAvatar WHERE PetID = @PetID";

			var parameters = new SqlParameterBuilder()
				.AddInt("PetID", dto.PetID)
				.AddInt("@SpeciesID", dto.SpeciesID)
				.AddInt("@BreedID", dto.BreedID)
				.AddNVarchar("@PetName", 15, dto.PetName)
				.AddBit("@Gender", dto.Gender)
				.AddInt("@Age", dto.Age)
				.AddNVarchar("@Description", 500, dto.Description)
				.AddNVarchar("@Location", 30, dto.Description)
				.AddNVarchar("@PetAvatar", 50, dto.PetAvatar)
				.Build();

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}
		#endregion

		#region 刪資料
		public int Delete(int PetID)
		{
			string sql = "DELETE FROM Pets WHERE PetID = @PetID";

			SqlParameter parameter = new SqlParameter("@PetID", SqlDbType.Int)
			{
				Value = PetID
			};
			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameter);
		}
		#endregion
	}
}
