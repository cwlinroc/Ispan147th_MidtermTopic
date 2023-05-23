using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberClassLibrary
{
	public class SqlDb
	{
		//public static string GetConnString(string connName)
		//{
		//	try
		//	{
		//		string connStr = System.Configuration
		//					.ConfigurationManager.ConnectionStrings[connName].ToString();

		//		return connStr;

		//	}
		//	catch (Exception ex)
		//	{
		//		throw new Exception($"找不到連線字串,名稱為{connName}, 請確認之後再試一次");
		//	}
		//}

		//public static SqlConnection GetConnection()
		//{
		//	return GetConnection("default");
		//}
		//public static SqlConnection GetConnection(string connName)
		//{
		//	string connString = GetConnString(connName);
		//	return new SqlConnection(connString);
		//}

		public static T Get<T>(Func<SqlConnection> connGetter, string sql, Func<SqlDataReader, T> assembler, params SqlParameter[] parameters)
		{
			using (var conn = connGetter())
			{
				conn.Open();

				using (SqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					//如果有SqlParameter,就加入
					if (parameters.Length > 0)
					{
						cmd.Parameters.AddRange(parameters);
					}

					SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

					return (reader.Read()) ? assembler(reader) : default(T);
				}
			}
		}

		public static IEnumerable<T> Search<T>(Func<SqlConnection> connGetter, string sql,
							Func<SqlDataReader, T> assembler, params SqlParameter[] parameters)
		{
			using (var conn = connGetter())
			{
				conn.Open();

				using (SqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					if (parameters.Length > 0)
					{
						cmd.Parameters.AddRange(parameters);
					}

					SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

					while (reader.Read() == true)
					{
						yield return assembler(reader);
					}

				}
			}
		}

		public static int Create(Func<SqlConnection> connGetter, string sql, params SqlParameter[] parameters)
		{
			using (var conn = connGetter())
			{
				conn.Open();

				using (SqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql + ";\r\nSET @newId = SCOPE_IDENTITY()";

					SqlParameter parameter = new SqlParameter("@newId", SqlDbType.Int) { Direction = ParameterDirection.Output };
					cmd.Parameters.Add(parameter);

					if (parameters.Length > 0)
					{
						cmd.Parameters.AddRange(parameters);
					}

					cmd.ExecuteNonQuery();
					return (int)cmd.Parameters["@newId"].Value;
				}
			}
		}

		public static int UpdateOrDelete(Func<SqlConnection> connGetter, string sql, params SqlParameter[] parameters)
		{
			using (var conn = connGetter())
			{
				conn.Open();
				using (SqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					if (parameters != null && parameters.Length > 0)
					{
						cmd.Parameters.AddRange(parameters);
					}

					try
					{
						return cmd.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						if (ex.Message.Contains("FK_"))
						{
							throw new Exception("此商品分類有其他資料參考, 無法異動");
						}
						else
						{
							throw;
						}
					}

				}
			}
		}
	}
}
