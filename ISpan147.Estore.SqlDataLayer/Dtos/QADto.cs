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
			/// 使用者                   
			/// </summary>
			public int UserId { get; set; }    //EmployeeID or MemberId
			public string UserName { get; set; }

			/// <summary>
			/// 留言時間
			/// </summary>
			public DateTime ThemeDateTime { get; set; }

			/// <summary>
			/// 留言板內文
			/// </summary>
			public string ThemeContext { get; set; }
		}

		public class Comment
		{
			/// <summary>
			/// 主題編號
			/// </summary>
			public int ThemeId { get; set; }
			/// <summary>
			/// 回覆留言編號
			/// </summary>
			public int CommentId { get; set; }

			/// <summary>
			/// 使用者
			/// </summary>
			public int UserId { get; set; }    //EmployeeID or MemberId
			public string UserName { get; set; }


			/// <summary>
			/// 留言時間
			/// </summary>
			public DateTime CommentDateTime { get; set; }

			/// <summary>
			/// 留言板內文
			/// </summary>
			public string CommentContext { get; set; }
		}
	}
}
