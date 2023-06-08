using Ispan147.Estore.SqlDataLayer.Repositories;
using Ispan147.Estore.SqlDataLayer.Services;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Services;
using ISpan147.Estore.SqlDataLayer.Utility;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace prjMidtermTopic.FormMember
{
	public partial class form_EditMember : Form
	{
		private Dictionary<string, Control> _map;
		private bool _gender;
		private readonly int _memberID;
		private string _originalFilePath;
		private string _targetFolderPath = @"images/avatar/";
		private IMemberRepo _memberRepo;
		private string _forumAccountID;//txtForumAccountID
		private string _password;//txtPassword
		public form_EditMember(int memberID)
		{
			InitializeComponent();
			_memberID = memberID;

			_map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "MemberName", txtMemberName},
				//{ "ForumAccountID", txtForumAccountID},
				{ "NickName", txtNickName},
				{ "DateOfBirth", DateOfBirthPicker},
				{ "Gender", radbtnFemale},
				{ "Account", txtAccount},
				{ "Phone", txtPhone},
				{ "Address", txtAddress},
				//{ "Password", txtPassword},
				{ "Email", txtEmail},
				{ "Avatar", txtAvatar}
			};

		}

		private void form_EditMember_Load(object sender, EventArgs e)
		{
			_memberRepo = new MemberRepository();
			MemberDto dto = _memberRepo.GetById(_memberID);
			if (dto == null)
			{
				MessageBox.Show("找不到紀錄");
				return;
			}
			txtMemberName.Text = dto.MemberName;
			_forumAccountID = dto.ForumAccountID.ToString();
			txtNickName.Text = dto.NickName;
			DateOfBirthPicker.Value = dto.DateOfBirth;
			txtAccount.Text = dto.Account;
			_password = dto.Password;
			txtPhone.Text = dto.Phone;
			txtAddress.Text = dto.Address;
			txtEmail.Text = dto.Email;
			txtAvatar.Text = dto.Avatar;

			if (dto.Gender)
			{
				radbtnMale.Checked = true;
			}
			else
			{
				radbtnFemale.Checked = true;
			}

			btnDeleteAvatar.Enabled = !string.IsNullOrEmpty(txtAvatar.Text);
			btnApplyForumAccount.Enabled = string.IsNullOrEmpty(_forumAccountID);
			btnEditForumName.Enabled = !string.IsNullOrEmpty(_forumAccountID);

			#region 載入預覽圖片
			try
			{
				if (string.IsNullOrEmpty(txtAvatar.Text))
				{
					pictureBoxAvatar.Image = Properties.Resources.default_avatar;
				}
				else
				{
					using (var bmpTemp = new Bitmap("images/avatar/" + txtAvatar.Text))
					{
						pictureBoxAvatar.Image = new Bitmap(bmpTemp, 256, 256);
					}
				}
			}
			catch
			{
				pictureBoxAvatar.Image = Properties.Resources.error_icon;
			}
			#endregion

			if (Authentication.Permission > 4)
			{
				btnUploadAvatar.Enabled = false;
				btnDeleteAvatar.Enabled = false;
				btnApplyForumAccount.Enabled = false;
				btnEditForumName.Enabled = false;
				btnUpdate.Enabled = false;
			}
			if (Authentication.Permission > 2)
			{
				btnDelete.Enabled = false;
			}
		}

		private void SelectFileToForm(string filePath)
		{
			try
			{
				string fileName = Path.GetFileName(filePath);
				//加上時間戳重新命名,避免檔名重複
				txtAvatar.Text = DateTime.Now.ToString("yyyyMMddhhmmss_") + fileName;

				//變更預覽圖片
				using (var bmpTemp = new Bitmap(filePath))
				{
					pictureBoxAvatar.Image = new Bitmap(bmpTemp, 256, 256);
				}

				MessageBox.Show("選擇成功");

			}
			catch (Exception ex)
			{
				MessageBox.Show($"選擇失敗,原因:{ex.Message}");
			}

		}

		private void UploadFileToDb(string filePath)
		{
			string targetFilePath = _targetFolderPath + txtAvatar.Text;

			if (!string.IsNullOrEmpty(filePath))
			{
				File.Delete(targetFilePath);
			}
			else
			{
				return;
			}
			try
			{
				File.Copy(filePath, targetFilePath);

				MessageBox.Show($"上傳成功,路徑:{targetFilePath}");
				btnDeleteAvatar.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"上傳失敗,原因:{ex.Message}");
			}
		}

		private void DeleteFile(string filePath)
		{
			string targetFilePath = _targetFolderPath + filePath;
			try
			{
				if (File.Exists(targetFilePath))
				{
					File.Delete(targetFilePath);
					MessageBox.Show("刪除成功");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show($"刪除失敗,原因:{ex.Message}");
			}
		}

		private void DateOfBirthPicker_ValueChanged(object sender, EventArgs e)
		{
			DateTime selectedDate = DateOfBirthPicker.Value;
			DateTime currentDate = DateTime.Now;

			if (selectedDate < currentDate.AddYears(-100))
			{
				MessageBox.Show("選擇時間早於目前時間100年!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		#region button
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

		private void btnSelectAvatar_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory =
					Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				openFileDialog.Title = "選擇檔案";
				openFileDialog.Filter =
					"Image files(*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";
				openFileDialog.Multiselect = false;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					_originalFilePath = openFileDialog.FileName;

					SelectFileToForm(_originalFilePath);
				}
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var vm = new MemberCreateVM()
			{
				MemberID = this._memberID,
				MemberName = txtMemberName.Text,
				ForumAccountID = Utility.ToNullableInt(_forumAccountID),
				NickName = txtNickName.Text,
				DateOfBirth = DateOfBirthPicker.Value,
				Gender = _gender,
				Account = txtAccount.Text,
				Password = _password,
				Phone = txtPhone.Text,
				Address = txtAddress.Text,
				Email = txtEmail.Text,
				Avatar = txtAvatar.Text
			};

			//驗證vm是否通過欄位驗證
			bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, _map);
			if (hasError) return;

			MemberDto dto = new MemberDto
			{
				MemberID = vm.MemberID,
				MemberName = vm.MemberName,
				ForumAccountID = vm.ForumAccountID,
				NickName = vm.NickName,
				DateOfBirth = vm.DateOfBirth,
				Gender = vm.Gender.Value,
				Account = vm.Account,
				Password = vm.Password,
				Phone = vm.Phone,
				Address = vm.Address,
				Email = vm.Email,
				Avatar = vm.Avatar
			};

			try
			{
				var service = new MemberService(_memberRepo);
				int rows = service.Update(dto);

				UploadFileToDb(_originalFilePath);

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
			var service = new MemberService(_memberRepo);
			try
			{
				int rows = service.Delete(_memberID);
				if (rows > 0)
				{
					MessageBox.Show("刪除成功");
				}
				else
				{
					MessageBox.Show("刪除失敗");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("刪除失敗,原因:" + ex.Message);
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

		private void btnDeleteAvatar_Click(object sender, EventArgs e)
		{
			DeleteFile(txtAvatar.Text);
			txtAvatar.Text = null;
			pictureBoxAvatar.Image = Properties.Resources.default_avatar;
			btnDeleteAvatar.Enabled = false;
		}

		private void btnApplyForumAccount_Click(object sender, EventArgs e)
		{
			var frm = new form_ApplyForumAccount(_memberID);
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		private void btnEditForumName_Click(object sender, EventArgs e)
		{
			var frm = new form_EditForumName(int.Parse(_forumAccountID));
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		#endregion

	}
}
