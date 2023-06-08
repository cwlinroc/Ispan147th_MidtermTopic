using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class QAService
	{
		/// <summary>
		/// 取得主留言列表
		/// </summary>
		/// <param name="themeId">主題ID</param>
		/// <returns></returns>
		
		public List<QADto.Theme> GetThemeList(int? themeId = null)
		{
			return new QARepository().GetTheme(themeId);
		}
		
		public List<QADto.Theme> SearchTheme(string keyword)
		{ 
			return new QARepository().SearchTheme(keyword);
		}

		public string CreateTheme(QADto.Theme themeDto)
		{
			var result = new QARepository().CreateTheme(themeDto);

			return result > 0 ? $"新增一筆留言成功，留言編號是{result}。" : "新增留言失敗";
		}

		/// <summary>
		/// 取得回覆留言列表
		/// </summary>
		/// <param name="commentId"></param>
		/// <returns></returns>
		public List<QADto.Comment> GetCommentList(int? commentId = null)
		{
			return new QARepository().GetComment(commentId);
		}

		public List<QADto.Comment> SearchComment(string keyword) 
		{
			return new QARepository().SearchComment(keyword);
		}

		public string CreateComment(QADto.Comment commentDto)
		{ 
			var result = new QARepository().CreateComment(commentDto);

			return result > 0 ? $"新增一筆留言成功，留言編號是{result}。" : "新增留言失敗";
		}

	}
}
