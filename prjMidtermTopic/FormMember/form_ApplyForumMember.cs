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
		private IForumAccountRepo _forumAccountrepo;
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
			btnEdit.Enabled = !string.IsNullOrEmpty(txtForumAccountId.Text);
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			try
			{
				var vm = new ForumAccountVM
				{
					MemberName = txtMemberName.Text.Trim(),
					NickName = txtNickName.Text.Trim()
				};

				bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, _map);
				if (hasError) return;

				int newId = new ForumAccountService(_forumAccountrepo)
					.Create(vm.ToDto());

				MessageBox.Show($"申請成功,論壇帳戶編號為{newId}");

				if (Owner != null)
				{
					IGrid parent = Owner as IGrid;
					parent.Display();
				}
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("申請失敗,原因:" + ex.Message);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
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

				string newName = new ForumAccountService(_forumAccountrepo)
					.Update(vm.ToDto());

				MessageBox.Show($"修改成功,論壇帳戶稱呼為{newName}");

				if (Owner != null)
				{
					IGrid parent = Owner as IGrid;
					parent.Display();
				}
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗,原因:" + ex.Message);
			}
		}
	}
}
