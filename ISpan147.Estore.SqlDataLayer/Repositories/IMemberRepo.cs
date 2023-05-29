using Ispan147.Estore.SqlDataLayer.Repositories;
using Ispan147.Estore.SqlDataLayer.Services;
using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.Interfaces
{
	public interface IMemberRepo
	{
		MemberDto GetByName(string memberName);
		int Create(MemberDto dto);
		int Update(MemberDto dto);
		
	}
}
