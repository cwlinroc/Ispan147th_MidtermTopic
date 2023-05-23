using Ispan147.Estore.SqlDataLayer.Dtos;
using Ispan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ispan147.Estore.SqlDataLayer.Dtos.MemberDto;

namespace prjMidtermTopic.FormMember
{
	public partial class form_CreateMember : Form
	{
		public GenderType _gender;
		public form_CreateMember()
		{
			InitializeComponent();
		}

		private (bool isValid, List<ValidationResult> errors) Validate(MemberCreateVM vm)
		{
			//得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			//用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			//驗證 model
			bool validateAllPropeoties = true;//是否驗證所有規則,並非只驗證required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllPropeoties);

			return (isValid, errors);
		}

		private void DisplayErrors(List<ValidationResult> errors)
		{
			//大小寫不同仍視為相同的key
			Dictionary<string, Control> map =
				new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "Name", txtName},
				{ "DateOfBirth", txtDateOfBirth},
				
				{ "Account", txtAccount},
				{ "Password", txtPassword},				
				{ "Phone", txtPhone},				
				{ "Address", txtAddress},				
				{ "Email", txtEmail},
				{ "Avatar", txtAvatar}
			};
			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
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

		public int newId = 5;
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			DateTime dob = DateTime.Parse(txtDateOfBirth.Text);			
			string acc = txtAccount.Text;
			string pwd = txtPassword.Text;
			string phone = txtPhone.Text;
			string address = txtAddress.Text;
			string email = txtEmail.Text;
			string avatar = txtAvatar.Text;			

			var vm = new MemberCreateVM()
			{
				Name = name,
				DateOfBirth = dob,
				Gender = _gender,
				Account = acc,
				Password = pwd,
				Phone = phone,
				Address = address,
				Email = email,
				Avatar = avatar				
			};

			//驗證vm是否通過欄位驗證
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			//若有錯就顯示它
			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			MemberDto dto = new MemberDto
			{
				Id = vm.Id,
				Name = vm.Name,
				DateOfBirth = vm.DateOfBirth,
				Gender = vm.Gender,
				Account = vm.Account,
				Password = vm.Password,
				Phone = vm.Phone,
				Address = vm.Address,
				Email = vm.Email,
				Avatar = vm.Avatar
			};

			try
			{
				var service = new MemberService();				
				newId++;
				MessageBox.Show($"新增成功,新的編號為{newId}");
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
				return;
			}


			//try
			//{
			//	var service = new MemberService();
			//	int newId = service.Create(dto);
			//	MessageBox.Show($"新增成功,新的編號為{newId}");
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show("新增失敗, 原因: " + ex.Message);
			//	return;
			//}

			// 關閉表單
			IGrid parent = this.Owner as IGrid;
			// 將開啟我的那個視窗, 轉型成 IGrid, 如果轉型失敗,不會丟出例外, 而是傳回null
			if (parent == null) // 表示轉型失敗
			{
				MessageBox.Show("開啟我的表單沒有實作IGrid,所以無法通知它");
			}
			else
			{
				parent.Display(); // 呼叫它的 Display() 重新顯示資料
			}

			this.Close();
		}

		
	}
	
}
