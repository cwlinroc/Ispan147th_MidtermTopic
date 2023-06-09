﻿using ISpan147.Estore.SqlDataLayer.Dtos;
using Ispan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using System.IO;
using ISpan147.Estore.SqlDataLayer.ExtMethods;
using Ispan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Utility;
using ISpan147.Estore.SqlDataLayer.EFModel;
using System.Drawing;

namespace prjMidtermTopic.FormMember
{
	public partial class form_CreateMember : Form
	{
		private bool? _gender;
		private Dictionary<string, Control> _map;
		private string _originalFilePath;
		private string _targetFolderPath = @"images/avatar/";
		private IMemberRepo _memberRepo;
		public form_CreateMember()
		{
			InitializeComponent();
			_map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "MemberName", txtMemberName},
				{ "NickName", txtNickName},
				{ "DateOfBirth", DateOfBirthPicker },
				{ "Gender", radbtnFemale},
				{ "Account", txtAccount},
				{ "Password", txtPassword},
				{ "Phone", txtPhone},
				{ "Address", txtAddress},
				{ "Email", txtEmail},
				{ "Avatar", txtAvatar}
			};

			_memberRepo = new MemberRepository();
			Load += Form_CreateMember_Load;
		}

		private void Form_CreateMember_Load(object sender, EventArgs e)
		{	
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
						pictureBoxAvatar.Image = new Bitmap(bmpTemp);
					}
				}
			}
			catch
			{
				pictureBoxAvatar.Image = Properties.Resources._error;
			}
			#endregion
		}

		private void SelectFileToForm(string filePath)
		{
			try
			{
				string fileName = Path.GetFileName(filePath);
				//加上時間戳重新命名,避免檔名重複
				txtAvatar.Text = DateTime.Now.ToString("yyyyMMddhhmmssss_") + fileName;

				//變更預覽圖片
				using (var bmpTemp = new Bitmap(filePath))
				{
					pictureBoxAvatar.Image = new Bitmap(bmpTemp);
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
			}
			catch (Exception ex)
			{
				MessageBox.Show($"上傳失敗,{ex.Message}");
			}
		}

		#region 事件
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

		private void checkBoxPasswordUncovered_CheckedChanged(object sender, EventArgs e)
		{
			txtPassword.PasswordChar = checkBoxPasswordUncovered.Checked ? '\0' : '●';
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
			btnDeleteAvatar.Enabled = true;
		}

		private void btnDeleteAvatar_Click(object sender, EventArgs e)
		{
			pictureBoxAvatar.Image = Properties.Resources.default_avatar;
			txtAvatar.Text = null;
			btnDeleteAvatar.Enabled = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{			
			string membername = txtMemberName.Text;
			string nickname = txtNickName.Text;
			DateTime dob = DateOfBirthPicker.Value;
			string acc = txtAccount.Text;
			string pwd = MyEncoder.GetSaltedSha256(txtPassword.Text);
			string phone = txtPhone.Text;
			string address = txtAddress.Text;
			string email = txtEmail.Text;
			string avatar = txtAvatar.Text;

			var vm = new MemberCreateVM()
			{
				MemberName = membername,				
				NickName = nickname,
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
				int newID = service.Create(dto);

				UploadFileToDb(_originalFilePath);

				MessageBox.Show($"新增成功,新的編號為{newID}");
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}

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


		#endregion
		
	}

}
