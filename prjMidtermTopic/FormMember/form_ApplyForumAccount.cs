using Ispan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prjMidtermTopic.FormMember
{
	public partial class form_ApplyForumAccount : Form
	{
		private readonly Dictionary<string, Control> _map;
		private ForumAccountRepository _forumAccountrepo;
		private IMemberRepo _memberrepo;
		private readonly int _memberId;

		public form_ApplyForumAccount(int memberId)
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

		private void form_ApplyForumAccount_Load(object sender, EventArgs e)
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
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			try
			{
				var vm = new ForumAccountVM
				{
					ForumAccountName = string.IsNullOrEmpty(txtNickName.Text) ?
									txtMemberName.Text.Trim() : txtNickName.Text.Trim()
				};

				bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, _map);
				if (hasError) return;

				int forumID = new ForumAccountService()
					.CreateForumAccount(_memberId, vm.ForumAccountName);

				if (forumID <= 0)
				{
					throw new Exception("未成功取得論壇編號");
				}
				
				MessageBox.Show($"申請成功,論壇編號為{forumID}");				

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("申請失敗,原因:" + ex.Message);
			}
		}

	}
}
