using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Builders
{
	public class SqlParameterBuilder
	{
		private List<SqlParameter> _parameters = new List<SqlParameter>();

		public SqlParameterBuilder AddInt(string columnName, int input)
		{
			_parameters.Add(new SqlParameter(columnName, SqlDbType.Int)
			{ Value = input });
			return this;
		}


		public SqlParameterBuilder AddNullableInt(string columnName, int? input)
		{
			SqlParameter parameter = new SqlParameter(columnName, SqlDbType.Int);
			if (input.HasValue)
			{
				parameter.Value = input.Value;
			}
			else
			{
				parameter.Value = DBNull.Value;
			}
			_parameters.Add(parameter);
			return this;
		}

		public SqlParameterBuilder AddOutInt(string columnName)
		{
			_parameters.Add(new SqlParameter(columnName, SqlDbType.Int)
			{ Direction = ParameterDirection.Output });
			return this;
		}

		public SqlParameterBuilder AddBit(string columnName, bool? input)
		{
			SqlParameter parameter = new SqlParameter(columnName, SqlDbType.Bit);
			if (input.HasValue)
			{
				parameter.Value = input.Value;
			}
			else
			{
				parameter.Value = DBNull.Value;
			}
			_parameters.Add(parameter);
			return this;
		}

		public SqlParameterBuilder AddDateTime(string columnName, DateTime input)
		{
			_parameters.Add(new SqlParameter(columnName, SqlDbType.DateTime)
			{ Value = input });
			return this;
		}

		public SqlParameterBuilder AddOutDateTime(string columnName)
		{
			_parameters.Add(new SqlParameter(columnName, SqlDbType.DateTime)
			{ Direction = ParameterDirection.Output });
			return this;
		}

		public SqlParameterBuilder AddNVarchar(string columnName, int length, string input)
		{
			_parameters.Add(new SqlParameter(columnName, SqlDbType.NVarChar, length)
			{ Value = input });
			return this;
		}

		public SqlParameterBuilder AddOutNVarchar(string columnName, int length)
		{
			_parameters.Add(new SqlParameter(columnName, SqlDbType.NVarChar, length)
			{ Direction = ParameterDirection.Output });
			return this;
		}

		public SqlParameterBuilder AddNchar(string columnName, int length, string input)
		{
			_parameters.Add(new SqlParameter(columnName, SqlDbType.NChar, length)
			{ Value = input });
			return this;
		}

		public SqlParameterBuilder AddOutNchar(string columnName, int length)
		{
			_parameters.Add(new SqlParameter(columnName, SqlDbType.NChar, length)
			{ Direction = ParameterDirection.Output });
			return this;
		}

		public SqlParameterBuilder AddVarchar(string columnName, int length, string input)
		{
			_parameters.Add(new SqlParameter(columnName, SqlDbType.VarChar, length)
			{ Value = input });
			return this;
		}

		public SqlParameterBuilder AddOutVarchar(string columnName, int length)
		{
			_parameters.Add(new SqlParameter(columnName, SqlDbType.VarChar, length)
			{ Direction = ParameterDirection.Output });
			return this;
		}

		public SqlParameter[] Build()
		{
			return _parameters.ToArray();
		}
	}
}
