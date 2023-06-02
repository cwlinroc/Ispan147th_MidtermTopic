using Ispan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using prjMidtermTopic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.FormMember
{
	public partial class form_ApplyForumMember : Form
	{
		private Dictionary<string, Control> _map;
		private IMemberRepo _memberRepo;
		
		public form_ApplyForumMember()
		{
			InitializeComponent();			
			_map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "MemberName", txtMemberName},
				{ "NickName", txtNickName}
			};

			_memberRepo = new MemberRepository();
		}

		private void form_ApplyForumMember_Load(object sender, EventArgs e)
		{
			MemberDto dto = _memberRepo.GetById(_memberID);
			if (dto == null)
			{
				MessageBox.Show("找不到紀錄");
				return;
			}
		}
	}
}
