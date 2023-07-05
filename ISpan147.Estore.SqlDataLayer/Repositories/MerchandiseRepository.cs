﻿using ISpan147.Estore.SqlDataLayer.Builders;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan147.Estore.SqlDataLayer.EFModel;
using Dapper;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class MerchandiseRepository : IMerchandiseRepository
	{
		/// 透過字串組成SQL語法，取得商品分類記錄
		public MerchandiseDto GetByMerchandiseId(int merchandiseId)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Merchandises WHERE MerchandiseId = {merchandiseId}";
			Func<SqlDataReader, MerchandiseDto> assembler = Assembler.MerchandiseDtoAssembler;
			SqlParameter[] parameters = new SqlParameter[0];

			return SqlDb.Get(connGetter, sql, assembler);
		}

		public MerchandiseDto GetByMerchandiseName(string merchandisename)
		{
			Func<SqlConnection> connGetter = SqlDb.GetConnection;
			string sql = $"SELECT * FROM Merchandises WHERE MerchandiseName = @MerchandiseName";
			Func<SqlDataReader, MerchandiseDto> assembler = Assembler.MerchandiseDtoAssembler;
			SqlParameter parameters = new SqlParameter("@MerchandiseName", SqlDbType.NVarChar, 30) { Value = merchandisename };

			return SqlDb.Get(connGetter, sql, assembler, parameters);
        }

        public MerchandiseDto GetByCategoryId(int? categoryId)
        {
            Func<SqlConnection> connGetter = SqlDb.GetConnection;
            string sql = $"SELECT * FROM Merchandises WHERE CategoryId = {categoryId}";
            Func<SqlDataReader, MerchandiseDto> assembler = Assembler.MerchandiseDtoAssembler;
            SqlParameter[] parameters = new SqlParameter[0];

            return SqlDb.Get(connGetter, sql, assembler);
        }

        public MerchandiseDto GetByBrandName(string brandname)
        {
            Func<SqlConnection> connGetter = SqlDb.GetConnection;
            string sql = $"SELECT * FROM Merchandises WHERE BrandName = @BrandName";
            Func<SqlDataReader, MerchandiseDto> assembler = Assembler.MerchandiseDtoAssembler;
            SqlParameter parameters = new SqlParameter("@BrandName", SqlDbType.NVarChar, 30) { Value = brandname };

            return SqlDb.Get(connGetter, sql, assembler, parameters);
        }

        public IEnumerable<MerchandiseSearchDto> Search(MerchandiseConditionSearchDto csDto)
		{
			if (csDto == null) { return null; }

			string top = string.Empty;
			if (csDto.MaxQueryNumber.HasValue)
			{
				top = $"TOP (" + csDto.MaxQueryNumber + ") ";
			}
			else
			{
				top = string.Empty;
			}

			string orderBy = $" ORDER BY m.{csDto.OrderBy}";
			string decending = csDto.Descending ? " ASC" : " DESC";

			string sql = $@"SELECT {top}MerchandiseId, MerchandiseName, CategoryName, BrandName, 
										Description, ImageURL 
							FROM Merchandises AS m 
							JOIN Categories AS c 
							ON m.CategoryId = c.CategoryId 
							JOIN Brands AS b 
							ON m.BrandId = b.BrandId ";

			//var builder = new SqlParameterBuilder();

			string where = string.Empty;
			#region 串接搜尋條件
			if (csDto.MerchandiseId.HasValue)
			{
				where += $" AND MerchandiseId = @MerchandiseId";
			}
			if (!string.IsNullOrEmpty(csDto.MerchandiseName))
			{
				where += $" AND MerchandiseName LIKE '%'+@MerchandiseName+'%'";
            }
            if (csDto.CategoryId.HasValue)
            {
                where += $" AND m.CategoryId = @CategoryId";
            }
            if (!string.IsNullOrEmpty(csDto.BrandName))
            {
                where += $" AND b.BrandName LIKE '%'+@BrandName+'%'";
            }
            //if (csDto.MaxPrice.HasValue)
            //{
            //	where += $" AND Price <= @MaxPrice";
            //}
            //if (csDto.MinPrice.HasValue)
            //{
            //	where += $" AND Price >= @MinPrice";
            //}
            if (string.IsNullOrEmpty(where) == false)
			{
				where = " WHERE " + where.Substring(5);
			}
			#endregion

			string assembleSQL = sql + where + orderBy + decending;

			using (var conn = SqlDb.GetConnection())
			{
				return conn.Query<MerchandiseSearchDto>(assembleSQL, csDto);
			}
		}

		public int Update(MerchandiseDto dto)
		{
			var builder = new SqlParameterBuilder()
				.AddInt("@MerchandiseId", dto.MerchandiseId)
				.AddNVarchar("@MerchandiseName", 30, dto.MerchandiseName)
				.AddInt("@CategoryId", dto.CategoryId)
				.AddInt("@BrandId", dto.BrandId);
			string description = "";
			string imageurl = "";

			if (dto.Description != null)
			{
				builder = builder.AddNVarchar("@Description", 30, dto.Description);
				description = ", Description = @Description ";
			}
			else
			{
				description = ", Description = null ";
			}

			if (dto.ImageURL != null)
			{
				builder = builder.AddNVarchar("@ImageURL", 30, dto.ImageURL);
				imageurl = ", ImageURL = @ImageURL ";
			}
			else
			{
				imageurl = ", ImageURL = null ";
			}
			var parameters = builder.Build();

			string sql = $@"UPDATE Merchandises 
                            SET MerchandiseName = @MerchandiseName,
							CategoryId = @CategoryId, BrandId = @BrandId 
							{description} {imageurl}
                            WHERE MerchandiseId = @MerchandiseId";

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameters);
		}

		public int Create(MerchandiseDto dto)
		{
			var builder = new SqlParameterBuilder()
				.AddInt("@MerchandiseId", dto.MerchandiseId)
				.AddNVarchar("@MerchandiseName", 30, dto.MerchandiseName)
				.AddInt("@CategoryId", dto.CategoryId)
                .AddInt("@BrandId", dto.BrandId);
			string _description = "";
			string description = "";
			string _imageurl = "";
			string imageurl = "";

			if (dto.Description != null)
			{
				builder = builder.AddNVarchar("@Description", 30, dto.Description);
				_description = ", Description ";
				description = ", @Description ";
			}
			if (dto.ImageURL != null)
			{
				builder = builder.AddNVarchar("@ImageURL", 30, dto.ImageURL);
				_imageurl = ", ImageURL ";
				imageurl = ", @ImageURL ";
			}
			var parameters = builder.Build();

			string sql = $@"INSERT INTO Merchandises       
                            (MerchandiseName, CategoryId, BrandId{_description}{_imageurl})
                            Values
                            (@MerchandiseName, @CategoryId, @BrandId{description}{imageurl})";

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.Create(connGetter, sql, parameters);
		}

		public int Delete(int merchandiseId)
		{
			string sql = @"DELETE FROM Merchandises
                            WHERE MerchandiseId = @MerchandiseId";

			SqlParameter parameter = new SqlParameter("@MerchandiseId", SqlDbType.Int) { Value = merchandiseId };

			Func<SqlConnection> connGetter = SqlDb.GetConnection;

			return SqlDb.UpdateOrDelete(connGetter, sql, parameter);
		}
	}
}
