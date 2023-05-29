using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class QADto
	{
		public class Theme
		{
			/// <summary>
			/// 主題編號
			/// </summary>
			public int ThemeId { get; set; }

			/// <summary>
			/// 會員
			/// </summary>
			public int MemberId { get; set; }
			public string MemberName { get; set; }

			/// <summary>
			/// 留言時間
			/// </summary>
			public DateTime ThemeDateTime { get; set; }

			/// <summary>
			/// 留言板內文
			/// </summary>
			public string ThemeContext { get; set; }
		}

		public class Common
		{
			/// <summary>
			/// 主題編號
			/// </summary>
			public int CommonId { get; set; }

			/// <summary>
			/// 會員
			/// </summary>
			public int MemberId { get; set; }
			public string MemberName { get; set; }

			/// <summary>
			/// 員工
			/// </summary>
			public int EmployeeId { get; set; }
			public string EmployeeName { get; set; }

			/// <summary>
			/// 留言時間
			/// </summary>
			public DateTime ThemeDateTime { get; set; }

			/// <summary>
			/// 留言板內文
			/// </summary>
			public string CommonContext { get; set; }
		}
	}
}
