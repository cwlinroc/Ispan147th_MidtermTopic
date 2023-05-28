using ISpan147.Estore.SqlDataLayer.Builders;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
	public class Table : Attribute
	{
		public string TableName { get; set; }
		public Table(string tableName)
		{
			TableName = tableName;
		}
	}

	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
	public class Condition : Attribute
	{
		public ConditionState State { get; set; }
		public Condition(ConditionState state)
		{
			State = state;
		}
	}

	public enum ConditionState
	{
		Equal = 0,
		MoreThan = 1,
		LessThan = 2,
		StringContains = 3
	}

	public class DapperStringCreator
	{
		static public string Where(object obj)
		{
			var objProperties = obj.GetType().GetProperties();

			string whereStr = " WHERE 1=1 ";

			foreach (var prop in objProperties)
			{
				if (prop.GetValue(obj) == null) continue;

				if (prop.PropertyType == typeof(string) && prop.GetValue(obj) == string.Empty)
				{
					continue;
				}

				var attr = prop.GetCustomAttributes(typeof(Table), true).FirstOrDefault();

				string tableName = string.Empty;

				if (attr != null)
				{
					tableName = $"[{(attr as Table).TableName}].";
				}

				attr = prop.GetCustomAttributes(typeof(Condition), true).FirstOrDefault();

				if (attr == null)
				{
					whereStr += $" AND {tableName}{prop.Name} = @{prop.Name} ";
					continue;
				}

				ConditionState state = (attr as Condition).State;

				if (state == ConditionState.StringContains)
				{
					whereStr += $" AND {tableName}{prop.Name} LIKE '%'+@{prop.Name}+'%' ";
					continue;
				}
				if (state == ConditionState.MoreThan)
				{
					whereStr += $" AND {tableName}{prop.Name} > @{prop.Name} ";
					continue;
				}
				if (state == ConditionState.StringContains)
				{
					whereStr += $" AND {tableName}{prop.Name} < @{prop.Name} ";
					continue;
				}
				if (state == ConditionState.Equal)
				{
					whereStr += $" AND {tableName}{prop.Name} = @{prop.Name} ";
					continue;
				}

			}
			return whereStr;
		}

		static public string Insert(object obj, string table, string output = "")
		{
			var objProperties = obj.GetType().GetProperties();

			string sqlString = $" INSERT INTO [{table}] ( ";

			sqlString += objProperties.Where(prop => prop.GetValue(obj) != null)
				.Select(prop => prop.Name)
				.Where(o => o != output)
				.Aggregate((acc, next) => acc + ", " + next);

			sqlString += " ) ";

			if (!string.IsNullOrEmpty(output)) sqlString += $"OUTPUT INSERTED.{output}";

			sqlString += " VALUES ( @";

			sqlString += objProperties.Where(prop => prop.GetValue(obj) != null)
				.Select(prop => prop.Name)
				.Where(o => o!=output)
				.Aggregate((acc, next) => acc + ", @" + next);

			sqlString += " )";

			return sqlString;
		}

	}


}
