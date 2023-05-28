
using Ispan147.Estore.SqlDataLayer.Repositories;
using Ispan147.Estore.SqlDataLayer.Services;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.ExtMethods;
using prjMidtermTopic.Interfaces;
using System;
using System.Windows.Forms;

namespace prjMidtermTopic.FormMember
{
	public partial class form_EditMember : Form
	{
		private bool _gender;
		private readonly int _memberID;
		public form_EditMember(int memberID)
		{
			InitializeComponent();
			_memberID = memberID;
		}		

		private void form_EditMember_Load(object sender, EventArgs e)
		{
			var repo = new MemberRepository();
			MemberDto dto = repo.GetById(_memberID);
			if (dto == null)
			{
				MessageBox.Show("找不到紀錄");
				return;
			}
			txtMemberID.Text = dto.MemberID.ToString();
			txtMemberName.Text = dto.MemberName;
			txtNickName.Text = dto.NickName;
			DateOfBirthPicker.Value = dto.DateOfBirth;
			txtAccount.Text = dto.Account;
			txtPassword.Text = dto.Password;
			txtPhone.Text = dto.Phone;
			txtAddress.Text = dto.Address;
			txtEmail.Text = dto.Email;
			txtAvatar.Text = dto.Avatar;
		}

		//button
		private void radbtnMale_CheckedChanged(object sender, EventArgs e)
		{
			if (radbtnMale.Checked)
			{
				_gender = true;
				radbtnFemale.Checked = false;
			}
		}

		private void radbtnFemale_CheckedChanged(object sender, EventArgs e)
		{
			if (radbtnFemale.Checked)
			{
				_gender = false;
				radbtnMale.Checked = false;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			MemberDto dto = new MemberDto()
			{
				MemberID = this._memberID,
				MemberName = txtMemberName.Text,
				NickName = txtNickName.Text,
				DateOfBirth = DateOfBirthPicker.Value,
				Gender = _gender,
				Account = txtAccount.Text,
				Password = MyEncoder.GetSaltedSha256(txtPassword.Text),
				Phone = txtPhone.Text,
				Address = txtAddress.Text,
				Email = txtEmail.Text,
				Avatar = txtAvatar.Text
			};

			try
			{
				var service = new MemberService();
				int rows = service.Update(dto);
				if (rows > 0)
				{
					MessageBox.Show("更新成功");
				}
				else
				{
					MessageBox.Show("更新失敗,可能沒有這筆紀錄");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗,原因:" + ex.Message);
			}

			IGrid parent = this.Owner as IGrid;
			//將開啟我的視窗轉型成IGrid,若轉型失敗,不丟出例外而是傳回null
			if (parent == null)
			{
				MessageBox.Show("開啟我的表單沒有實作IGrid,所以無法通知它");
			}
			else
			{
				parent.Display();//呼叫它的Display()重新顯示資料
			}

			this.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var repo = new MemberRepository();
			try
			{
				int rows = repo.Delete(_memberID);
				//回到FormCategories
				if (rows > 0)
				{
					MessageBox.Show("刪除成功");
				}
				else
				{
					MessageBox.Show("刪除失敗");
				}
				IGrid parent = this.Owner as IGrid;
				//將開啟我的視窗轉型成IGrid,若轉型失敗,不丟出例外而是傳回null
				if (parent == null)
				{
					MessageBox.Show("開啟我的表單沒有實作IGrid,所以無法通知它");
				}
				else
				{
					parent.Display();//呼叫它的Display()重新顯示資料
				}
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("刪除失敗,原因:" + ex.Message);
			}
		}

		
	}
}
