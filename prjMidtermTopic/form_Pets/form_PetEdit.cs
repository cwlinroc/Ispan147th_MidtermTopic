﻿using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.EntitySql;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.form_Pets
{
	public partial class form_PetEdit : Form
	{
		private Dictionary<string, Control> _map;
		private Dictionary<int, string> _mapSpecies = new Dictionary<int, string>();
		private Dictionary<int, string> _mapBreed = new Dictionary<int, string>();
		private readonly int _petID;
		private bool _gender;
		private string _originalFilePath;
		private string _newImagePath;
		private string _targetFolderPath = @"images/petavatar/";
		private string _lasttargetFilePath;
		private IPetRepo _petRepo;
		public form_PetEdit(int PetID)
		{
			InitializeComponent();
			_petID = PetID;

			_map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"PetID",txtPetID },
				{"SpeciesID",comboBoxSpeciesID },
				{"BreedID",comboBoxBreedID },
				{"PetName",txtPetName},
				{"Gender",radioButtonMale},
				{"Age",txtAge},
				{"Description",txtDescription},
				{"Location",txtLocation},
				{"PetAvartar",txtPetAvatar }
			};
			_petRepo = new PetRepository();

			_mapSpecies.Add(0, "請選擇");
			_mapBreed.Add(0, "請選擇");
			new PetService(_petRepo).SearchSpescies().ForEach(s => _mapSpecies.Add(s.SpeciesID, s.SpeciesName));
			new PetService(_petRepo).SearchBreed().ForEach(s => _mapBreed.Add(s.BreedID, s.BreedName));

			foreach (var species in _mapSpecies)
			{
				comboBoxSpeciesID.Items.Add(species);
			}

			foreach (var breed in _mapBreed)
			{
				comboBoxBreedID.Items.Add(breed);
			}

			comboBoxSpeciesID.DisplayMember = "Value";
			comboBoxBreedID.DisplayMember = "Value";

			comboBoxSpeciesID.SelectedIndex = 0;
			comboBoxBreedID.SelectedIndex = 0;
		}

		private void form_PetEdit_Load(object sender, EventArgs e)
		{
			_petRepo = new PetRepository();
			PetDto dto = _petRepo.GetByID(_petID);
			if (dto == null)
			{
				MessageBox.Show("查無資料");
				return;
			}
			txtPetID.Text = dto.PetID.ToString();
			comboBoxSpeciesID.SelectedItem = comboBoxSpeciesID.Items.Cast<dynamic>().FirstOrDefault(x => x.Key == dto.SpeciesID);
			comboBoxBreedID.SelectedItem = comboBoxBreedID.Items.Cast<dynamic>().FirstOrDefault(x => x.Key == dto.BreedID);
			txtPetName.Text = dto.PetName;
			txtAge.Text = dto.Age.ToString();
			txtDescription.Text = dto.Description;
			txtLocation.Text = dto.Location;
			txtPetAvatar.Text = dto.PetAvatar;

			_originalFilePath = dto.PetAvatar;
			_lasttargetFilePath = @"images/petavatar/" + dto.PetAvatar;


			if (dto.Gender)
			{
				radioButtonMale.Checked = true;
			}
			else
			{
				radioButtonFemale.Checked = true;
			}

			try
			{
				if (string.IsNullOrEmpty(txtPetAvatar.Text))
				{
					pbPet.Image = Properties.Resources.CryCat;
				}
				else
				{
					using (var bmpTemp = new Bitmap(_lasttargetFilePath))
					{
						pbPet.Image = new Bitmap(bmpTemp);
					}
				}
			}
			catch
			{
				pbPet.Image = Properties.Resources.CryCat;
			}

			btnDeletePetAvatar.Enabled = !string.IsNullOrEmpty(txtPetAvatar.Text) ? true : false;


			if (Authentication.Permission > 4)
			{
				btnUpdate.Enabled = false;
				btnUpdatePetAvatar.Enabled = false;
				btnDeletePetAvatar.Enabled = false;
			}
			if (Authentication.Permission > 2)
			{
				btnDelete.Enabled = false;
			}
		}



		private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonMale.Checked)
			{
				_gender = true;
				radioButtonFemale.Checked = false;
			}
		}

		private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonFemale.Checked)
			{
				_gender = false;
				radioButtonMale.Checked = false;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int speciesID = (comboBoxSpeciesID.SelectedItem as dynamic).Key;
			int breedID = (comboBoxBreedID.SelectedItem as dynamic).Key;

			if (speciesID == 1 && !(breedID == 5 || breedID == 6 || breedID == 7 || breedID == 8))
			{
				MessageBox.Show("物種不相符，請更改");
				return;
			}

			if (speciesID == 2 && !(breedID == 9 || breedID == 10
				|| breedID == 11 || breedID == 12 || breedID == 13 || breedID == 14))
			{
				MessageBox.Show("物種不相符，請更改");
				return;
			}

			if (speciesID == 3 && !(breedID == 15 || breedID == 16
				|| breedID == 17 || breedID == 18 || breedID == 19))
			{
				MessageBox.Show("物種不相符，請更改");
				return;
			}

			if (speciesID == 4 && !(breedID == 20 || breedID == 21
				|| breedID == 22 || breedID == 23 || breedID == 24))
			{
				MessageBox.Show("物種不相符，請更改");
				return;
			}

			var vm = new PetCreateVM()
			{
				PetID = int.Parse(txtPetID.Text),
				SpeciesID = speciesID.ToString(),
				BreedID = breedID.ToString(),
				PetName = txtPetName.Text,
				Gender = _gender,
				Age = txtAge.Text,
				Description = txtDescription.Text,
				Location = txtLocation.Text,
				PetAvatar = txtPetAvatar.Text,
			};

			//驗證vm是否通過欄位驗證
			bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, _map);
			if (hasError) return;

			try
			{
				PetDto dto = new PetDto
				{
					PetID = vm.PetID,
					SpeciesID = int.Parse(vm.SpeciesID),
					BreedID = int.Parse(vm.BreedID),
					PetName = vm.PetName,
					Gender = vm.Gender,
					Age = int.Parse(vm.Age),
					Description = vm.Description,
					Location = vm.Location,
					PetAvatar = vm.PetAvatar
				};

				var service = new PetService(_petRepo);
				int rows = service.Update(dto);

				//UploadFileToDb(_originalFilePath);

				if (txtPetAvatar.Text != _originalFilePath && !string.IsNullOrEmpty(txtPetAvatar.Text))
				{
					UploadFileToDb(_newImagePath);
				}
				if (txtPetAvatar.Text != _originalFilePath && !string.IsNullOrEmpty(txtPetAvatar.Text))
				{
					DeleteFromDb();
				}

				if (rows > 0)
				{
					MessageBox.Show("更新成功");

					IGrid parent = this.Owner as IGrid;
					//將開啟我的視窗轉型為IGrid，若轉型失敗，不丟出例外而是傳回null
					if (parent == null)
					{
						MessageBox.Show("開啟我的表單沒有實作IGrid，所以無法通知他");
					}
					else
					{
						parent.Display();//呼叫他的Display()重新顯示資料
					}
				}
				else
				{
					MessageBox.Show("更新失敗，無此紀錄");
					return;
				}
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗，原因:" + ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var servise = new PetService(_petRepo);
			try
			{
				if (MessageBox.Show("確定要刪除資料?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					int rows = servise.Delete(_petID);
					//回到Form_Pet
					if (rows > 0)
					{
						MessageBox.Show("刪除成功");
					}
					else
					{
						MessageBox.Show("刪除失敗");
						return;
					}
					IGrid parent = this.Owner as IGrid;
					//將開啟我的視窗轉型為IGrid，若轉型失敗，不丟出例外而是傳回null
					if (parent == null)
					{
						MessageBox.Show("開啟我的表單沒有實作IGrid，所以無法通知他");
					}
					else
					{
						parent.Display();//呼叫他的Display()重新顯示資料
					}
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("刪除失敗，原因:" + ex.Message);
			}
		}
		private void btnUpdatePetAvatar_Click(object sender, EventArgs e)
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
					_newImagePath = openFileDialog.FileName;

					SelectFileToForm(_newImagePath);
				}
			}
		}

		private void btnDeletePetAvatar_Click(object sender, EventArgs e)
		{
			if (File.Exists(_lasttargetFilePath))
			{
				try
				{
					DeleteFile(txtPetAvatar.Text);
					txtPetAvatar.Text = string.Empty;
					btnDeletePetAvatar.Enabled = false;
				}
				catch (Exception ex)
				{
					MessageBox.Show("刪除失敗，原因：" + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("無寵物圖片檔案");
				btnDeletePetAvatar.Enabled = false;
			}
		}

		private void DeleteFromDb()
		{
			if (File.Exists(_lasttargetFilePath))
			{
				try
				{
					File.Delete(_lasttargetFilePath);

					MessageBox.Show($"圖片刪除成功");
				}
				catch (Exception ex)
				{
					MessageBox.Show("刪除失敗，原因：" + ex.Message);
				}
			}
			else
			{
				btnDeletePetAvatar.Enabled = false;
			}
		}

		private void SelectFileToForm(string filePath)
		{
			try
			{

				//加上時間戳重新命名,避免檔名重複
				txtPetAvatar.Text = DateTime.Now.ToString("yyyyMMddhhmmss_") + Path.GetFileName(filePath);

				MessageBox.Show("選擇成功");
				btnDeletePetAvatar.Enabled = true;

				using (var bmpTemp = new Bitmap(filePath))
				{
					pbPet.Image = new Bitmap(bmpTemp);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show($"選擇失敗,原因:{ex.Message}");
			}
		}

		private void UploadFileToDb(string filePath)
		{
			DeleteFromDb();

			string renamedtargetFilePath = _targetFolderPath + txtPetAvatar.Text;

			if (!string.IsNullOrEmpty(filePath))
			{
				File.Delete(renamedtargetFilePath);
			}
			else
			{
				return;
			}
			try
			{
				File.Copy(filePath, renamedtargetFilePath);

				MessageBox.Show($"上傳成功,路徑:{renamedtargetFilePath}");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"上傳失敗,{ex.Message}");
			}
		}

		private void DeleteFile(string filePath)
		{
			string renamedtargetFilePath = _targetFolderPath + filePath;
			try
			{
				if (File.Exists(renamedtargetFilePath))
				{
					File.Delete(renamedtargetFilePath);
					MessageBox.Show("刪除成功");
				}

			}
			catch (Exception ex) { MessageBox.Show($"刪除失敗,原因:{ex.Message}"); }
		}
	}
}
