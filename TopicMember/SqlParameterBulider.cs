using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.FormMember
{
	public class SqlParameterBulider
	{
		private List<SqlParameter> _parameters = new List<SqlParameter>();

		public SqlParameterBulider AddInt(string parameterName, int value)
		{
			var parameter = new SqlParameter(parameterName, SqlDbType.Int)
			{ Value = value };
			_parameters.Add(parameter);

			return this;
		}
		public SqlParameterBulider AddNVarchar(string parameterName, int length, string value)
		{
			var parameter = new SqlParameter(parameterName, SqlDbType.NVarChar, length)
			{ Value = value };
			_parameters.Add(parameter);

			return this;
		}
		public SqlParameterBulider AddDateTime(string parameterName, DateTime value)
		{
			var parameter = new SqlParameter(parameterName, SqlDbType.DateTime)
			{ Value = value };
			_parameters.Add(parameter);

			return this;
		}
		public SqlParameterBulider AddVarchar(string parameterName, string value)
		{
			var parameter = new SqlParameter(parameterName, SqlDbType.VarChar)
			{ Value = value };
			_parameters.Add(parameter);

			return this;
		}
		public SqlParameterBulider AddBool(string parameterName)
		{
			var parameter = new SqlParameter(parameterName, SqlDbType.Bit);
			_parameters.Add(parameter);

			return this;
		}
		public SqlParameterBulider AddIntOut(string parameterName)
		{
			var parameter = new SqlParameter(parameterName, SqlDbType.Int);
			_parameters.Add(parameter);

			return this;
		}
		
		public SqlParameter[] Bulid()
		{
			return _parameters.ToArray();
		}
	}
}
