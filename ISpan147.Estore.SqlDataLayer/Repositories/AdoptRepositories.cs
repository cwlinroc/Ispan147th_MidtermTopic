using ISpan147.Estore.SqlDataLayer.Builders;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
    internal class AdoptRepositories
    {
        public int Create(AdoptDto dto)
        {
            string sql = @"INSERT INTO Adopts(PetID,MemberID,ApplicationTime)
                                values(@PetID,@MemberID,@ApplicationTime)";

            var parameters = new SqlParameterBuilder()
                .AddInt("@PetID", dto.PetID)
                .AddInt("@MemberID", dto.MemberID)
                .AddDateTime("@ApplicationTime", dto.ApplicationTime)
                .Build();

            Func<SqlConnection> connGetter = SqlDb.GetConnection;
            return SqlDb.Create(connGetter, sql, parameters);
        }
        public int Update(AdoptDto dto)
        {
            string sql = @"UPDATE Adopts
                              SET PetID = @PetID,
                                  MemberID = @MemberID,
                                  ApplicationTime = @ApplicationTime
                                  WHERE AdoptID = @AdoptID";
            var parameters = new SqlParameterBuilder()
                .AddInt("@PetID", dto.PetID)
                .AddInt("@MemberID", dto.MemberID)
                .AddDateTime("@ApplicationTime", dto.ApplicationTime)
                .Build();
            Func<SqlConnection> connGetter = SqlDb.GetConnection;
            return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
        }
        public int Delete(AdoptDto dto)
        {
            string sql = @"DELETE FROM Adopts WHERE AdoptID = @AdoptID";

            var parameters = new SqlParameterBuilder()
                .AddInt("@PetID",dto.PetID)
                .AddInt("@MemberID",dto.MemberID)
                .AddDateTime("@ApplicationTime",dto.ApplicationTime)
                .Build() ;
            Func<SqlConnection> connGetter = SqlDb.GetConnection;
            return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
        }
        public List<AdoptDto> Search(int? AdoptID, int? PetID, DateTime? Application)
        {
            string sql = $"SELECT * FROM Adopts AS a JOIN Members AS m ON m.MemberID = a.MemberID  ";
            var parameter = new SqlParameterBuilder();
            string where = "";
            if (AdoptID.HasValue)
            {
                where += $"AND AdoptID = @AdoptID";
                parameter.AddInt("@AdoptID", AdoptID.Value);
            }
            if (PetID.HasValue)
            {
                where += $" AND PetID = @PetID";
                parameter.AddInt("@PetID", PetID.Value);
            }
            if (Application.HasValue) 
            {
                where += $"AND Application = @Application";
                parameter.AddDateTime("@Application",Application.Value);
            }
            SqlParameter[] parameters = parameter.Build();
            Func<SqlDataReader, AdoptDto> func = Assembler.AdoptDtoAssembler;
            Func<SqlConnection> connGetter = SqlDb.GetConnection;
            
            return SqlDb.Search(connGetter, sql, func, parameters.ToArray()).ToList();



        }
    }
}
