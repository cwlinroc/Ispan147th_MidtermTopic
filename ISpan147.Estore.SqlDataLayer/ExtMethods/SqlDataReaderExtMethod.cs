using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.ExtMethods
{
	public static class SqlDataReaderExtMethod
	{
		public static int GetInt(this SqlDataReader reader, string columnName)
		{
			int result = 0;
			GetData(reader, columnName, (r, i) => result = r.GetInt32(i));
			return result;
		}

		public static int? GetNullableInt(this SqlDataReader reader, string columnName)
		{
			int? result = null;
			GetData(reader, columnName, (r, i) => { if (r[i] != null) result = r.GetInt32(i); });
			return result;
		}


		public static string GetString(this SqlDataReader reader, string columnName)
		{
			string result = null;
			GetData(reader, columnName, (r, i) => result = r.GetString(i));
			return result;
		}

		public static bool GetBool(this SqlDataReader reader, string columnName)
		{
			bool result = false;
			GetData(reader, columnName, (r, i) => result = r.GetBoolean(i));
			return result;
		}

		public static DateTime GetDate(this SqlDataReader reader, string columnName)
		{
			DateTime result = DateTime.MinValue;
			GetData(reader, columnName, (r, i) => result = r.GetDateTime(i));
			return result;
		}

		private static void GetData(SqlDataReader reader, string columnName, Action<SqlDataReader, int> action)
		{
			try
			{
				int columnIndex = reader.GetOrdinal(columnName);
				if (!reader.IsDBNull(columnIndex))
				{
					action(reader, columnIndex);
				}
			}
			catch (Exception ex)
			{
				throw new Exception("讀取資料欄位時發生錯誤：" + ex.Message);
			}
		}

	}
}
