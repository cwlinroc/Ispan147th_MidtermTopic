using Ispan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		private readonly Dictionary<string, Control> _map;
		private ForumAccountRepository _forumAccountrepo;
		private IMemberRepo _memberrepo;
		private readonly int _memberId;

		public form_ApplyForumMember(int memberId)
		{
			InitializeComponent();
			_memberId = memberId;
			_forumAccountrepo = new ForumAccountRepository();
			_memberrepo = new MemberRepository();

			_map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "MemberName", txtMemberName},
				{ "NickName", txtNickName}
			};
		}

		private void form_ApplyForumMember_Load(object sender, EventArgs e)
		{
			MemberDto dto = _memberrepo.GetById(_memberId);
			if (dto == null)
			{
				MessageBox.Show("找不到紀錄");
				return;
			}

			txtMemberName.Text = dto.MemberName;
			txtNickName.Text = dto.NickName;
			txtForumAccountId.Text = dto.ForumAccountID.ToString();

			btnApply.Enabled = string.IsNullOrEmpty(txtForumAccountId.Text);			
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			try
			{
				var vm = new ForumAccountVM
				{
					ForumAccountName = string.IsNullOrEmpty(txtNickName.Text)?
									txtMemberName.Text.Trim() : txtNickName.Text.Trim()
				};

				bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, _map);
				if (hasError) return;

				int forumID = new ForumAccountService()
					.CreateForumAccount(_memberId, vm.ForumAccountName);

				if (forumID <= 0)
				{
					throw new Exception("未成功取得ForumAccountID");
				}

				Authentication.ForumAccountID = forumID;

				MessageBox.Show($"申請成功,論壇帳戶編號為{forumID}");
				
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("申請失敗,原因:" + ex.Message);
			}
		}
		
	}
}
