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
			/// 暱稱ID                   
			/// </summary>
			public int ForumAccountId { get; set; }    //EmployeeID or MemberId
			
			/// <summary>
			/// 暱稱
			/// </summary>
			public string ForumAccountName { get; set; }

			/// <summary>
			/// 留言時間
			/// </summary>
			public DateTime ThemeDateTime { get; set; }

			/// <summary>
			/// 留言板內文
			/// </summary>
			public string ThemeContext { get; set; }
		}

		public class ThemeList
		{
			///// <summary>
			///// 主題留言板內文
			///// </summary>
			//public string ThemeContext { get; set; }

			///// <summary>
			///// 留言時間
			///// </summary>
			//public DateTime ThemeDateTime { get; set; }

			///// <summary>
			///// 主題留言板內文
			///// </summary>
			//public string ThemeContext { get; set; }
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
			public int ForumAccountId { get; set; }    //EmployeeID or MemberId
			public string ForumAccountName { get; set; }


			/// <summary>
			/// 留言時間
			/// </summary>
			public DateTime CommentDateTime { get; set; }

			/// <summary>
			/// 留言板內文
			/// </summary>
			public string CommentContext { get; set; }
		}
		public class CommentList
		{
			///// <summary>
			///// 回覆留言板內文
			///// </summary>
			//public string CommentContext { get; set; }

			///// <summary>
			///// 留言時間
			///// </summary>
			//public DateTime CommentTime { get; set; }

			///// <summary>
			///// 回覆留言板內文
			///// </summary>
			//public string CommentContext { get; set; }
		}
	}
}
