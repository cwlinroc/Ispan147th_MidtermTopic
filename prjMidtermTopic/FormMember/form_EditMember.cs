
using Ispan147.Estore.SqlDataLayer.Repositories;
using Ispan147.Estore.SqlDataLayer.Services;
using ISpan147.Estore.SqlDataLayer.Dtos;
using prjMidtermTopic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ISpan147.Estore.SqlDataLayer.Dtos.MemberDto;

namespace prjMidtermTopic.FormMember
{
	public partial class form_EditMember : Form
	{
		public GenderType _gender;
		private readonly int _memberId;
		public form_EditMember(int memberId)
		{
			InitializeComponent();
			_memberId = memberId;
		}

		private void form_EditMember_Load(object sender, EventArgs e)
		{
			//var repo = new MemberRepository();
			//MemberDto dto = repo.GetById(_memberId);
			//if (dto == null)
			//{
			//	MessageBox.Show("找不到紀錄");
			//	return;
			//}

			//txtId.Text = dto.Id.ToString();
			//txtName.Text = dto.Name;
			//txtDateOfBirth.Text = dto.DateOfBirth.ToString();
			//txtAccount.Text = dto.Account;
			//txtPassword.Text = dto.Password;
			//txtPhone.Text = dto.Phone;
			//txtAddress.Text = dto.Address;			
			//txtEmail.Text = dto.Email;
			//txtAvatar.Text = dto.Avatar;
		}

		//button
		private void radbtnMale_CheckedChanged(object sender, EventArgs e)
		{
			if (radbtnMale.Checked)
			{
				_gender = GenderType.Male;
				radbtnFemale.Checked = false;
			}
		}

		private void radbtnFemale_CheckedChanged(object sender, EventArgs e)
		{
			if (radbtnFemale.Checked)
			{
				_gender = GenderType.Female;
				radbtnMale.Checked = false;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			MemberDto dto = new MemberDto()
			{
				MemberID = this._memberId,
				MemberName = txtName.Text,
				DateOfBirth = DateTime.Parse(txtDateOfBirth.Text),
				Account = txtAccount.Text,
				Password = txtPassword.Text,
				Phone = txtPhone.Text,
				Address = txtAddress.Text,
				Email = txtEmail.Text,
				Avatar = txtAvatar.Text
			};

			//try
			//{
			//	var service = new MemberService();
			//	int rows = service.Update(dto);
			//	if (rows > 0)
			//	{
			//		MessageBox.Show("更新成功");
			//	}
			//	else
			//	{
			//		MessageBox.Show("更新失敗,可能沒有這筆紀錄");
			//	}
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show("更新失敗,原因:" + ex.Message);
			//}

			//IGrid parent = this.Owner as IGrid;
			////將開啟我的視窗轉型成IGrid,若轉型失敗,不丟出例外而是傳回null
			//if (parent == null)
			//{
			//	MessageBox.Show("開啟我的表單沒有實作IGrid,所以無法通知它");
			//}
			//else
			//{
			//	parent.Display();//呼叫它的Display()重新顯示資料
			//}

			//this.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//var repo = new MemberRepository();
			//try
			//{
			//	int rows = repo.Delete(_memberId);
			//	//回到FormCategories
			//	if (rows > 0)
			//	{
			//		MessageBox.Show("刪除成功");
			//	}
			//	else
			//	{
			//		MessageBox.Show("刪除失敗");
			//	}
			//	IGrid parent = this.Owner as IGrid;
			//	//將開啟我的視窗轉型成IGrid,若轉型失敗,不丟出例外而是傳回null
			//	if (parent == null)
			//	{
			//		MessageBox.Show("開啟我的表單沒有實作IGrid,所以無法通知它");
			//	}
			//	else
			//	{
			//		parent.Display();//呼叫它的Display()重新顯示資料
			//	}
			//	this.Close();
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show("刪除失敗,原因:" + ex.Message);
			//}
		}

		
	}
}
