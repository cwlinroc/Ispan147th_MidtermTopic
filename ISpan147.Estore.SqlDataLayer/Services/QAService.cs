using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class QAService
	{
		/// <summary>
		/// 取得留言列表
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

	}
}
