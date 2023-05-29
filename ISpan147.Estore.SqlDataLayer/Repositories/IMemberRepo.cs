using ISpan147.Estore.SqlDataLayer.Dtos;

namespace prjMidtermTopic.Interfaces
{
	public interface IMemberRepo
	{
		MemberDto GetByName(string memberName);
		MemberDto GetById(int id);
		int Create(MemberDto dto);
		int Update(MemberDto dto);		
		int Delete(int memberID);
	}
}
