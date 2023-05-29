using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer
{
	public class SqlDb
	{
		public static string GetConnectString(string connectName)
		{
			try
			{
				return System.Configuration.ConfigurationManager.ConnectionStrings[connectName].ToString();
			}
			catch (Exception)
			{
				throw new Exception($"找不到連線字串，請確認名稱{connectName}是否正確");
			}
		}

		public static SqlConnection GetConnection(string connectName)
		{
			try
			{
				return new SqlConnection(GetConnectString(connectName));
			}
			catch (Exception)
			{
				throw new Exception($"連線失敗，請確認名稱{connectName}是否正確");
			}
		}

		public static SqlConnection GetConnection()
		{
			try
			{
				return new SqlConnection(GetConnectString("default"));
			}
			catch (Exception)
			{
				throw new Exception($"連線失敗，請確認正確的連線端口");
			}
		}

		public static T Get<T>(
			Func<SqlConnection> connGetter,
			string sql,
			Func<SqlDataReader, T> assembler,
			params SqlParameter[] parameters)
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
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

					return (reader.Read()) ? assembler(reader) : default(T);
				}
			}
		}

		public static IEnumerable<T> Search<T>(
			Func<SqlConnection> connGetter,
			string sql,
			Func<SqlDataReader, T> assembler,
			params SqlParameter[] parameters)
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

					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

					while (reader.Read())
					{
						yield return assembler(reader);
					}

				}
			}
		}

		public static int Create(
			Func<SqlConnection> connGetter,
			string sql,
			params SqlParameter[] parameters)
		{
			using (var conn = connGetter())
			{
				conn.Open();
				using (SqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql + " ;\r\nSET @newId = SCOPE_IDENTITY()";
					cmd.Parameters.Add(new SqlParameter("@newId", SqlDbType.Int) { Direction = ParameterDirection.Output });

					if (parameters.Length > 0) cmd.Parameters.AddRange(parameters);

					cmd.ExecuteNonQuery();
					
					return (int)cmd.Parameters["@newId"].Value;					
				}
			}
		}

		public static void CreateWithoutScope(
			Func<SqlConnection> connGetter,
			string sql,
			params SqlParameter[] parameters)
		{
			using (var conn = connGetter())
			{
				conn.Open();
				using (SqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;

					if (parameters.Length > 0) cmd.Parameters.AddRange(parameters);

					cmd.ExecuteNonQuery();
				}
			}
		}

		public static int UpdateOrDelete(
			Func<SqlConnection> connGetter,
			string sql,
			params SqlParameter[] parameters)
		{
			using (var conn = connGetter())
			{
				conn.Open();
				using (SqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;

					if (parameters.Length > 0) cmd.Parameters.AddRange(parameters);

					try
					{
						return cmd.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						if (ex.Message.Contains("FK_"))
						{
							throw new Exception("異動失敗，異動資料有相關聯之資料表");
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
