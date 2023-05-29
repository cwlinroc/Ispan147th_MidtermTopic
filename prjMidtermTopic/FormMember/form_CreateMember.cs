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

namespace prjMidtermTopic.FormMember
{
	public partial class form_CreateMember : Form
	{
		private bool _gender;
		Dictionary<string, Control> _map;
		string _filePath;
		public form_CreateMember()
		{
			InitializeComponent();
			_map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "MemberName", txtMemberName},
				{ "NickName", txtNickName},
				{ "Account", txtAccount},
				{ "Password", txtPassword},
				{ "Phone", txtPhone},
				{ "Address", txtAddress},
				{ "Email", txtEmail},
				{ "Avatar", txtAvatar}
			};
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
				NickName = vm.NickName,
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
				int newID = service.Create(dto);
				MessageBox.Show($"新增成功,新的編號為{newID}");
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
				return;
			}

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
		
		private void btnUploadAvatar_Click(object sender, EventArgs e)
		{
			_filePath = string.Empty;

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory =
					Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				openFileDialog.Title = "選擇檔案";
				openFileDialog.Filter =
					"(*.png)|*.png|(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.gif)|*.gif";
				openFileDialog.Multiselect = false;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					_filePath = openFileDialog.FileName;

					Upload(_filePath);
				}
			}

		}

		private void Upload(string filePath)
		{
			string targetFolderPath = @"images/avatar/";
			string fileName = Path.GetFileName(filePath);
			string targetFilePath = Path.Combine(targetFolderPath, fileName);

			try
			{
				File.Copy(filePath, targetFilePath);
				txtAvatar.Text = Path.GetFileNameWithoutExtension(filePath);

				MessageBox.Show($"上傳成功,路徑:{filePath}");
			}
			catch (Exception)
			{
				MessageBox.Show("上傳失敗");
				return;
			}
		}

	}

}
