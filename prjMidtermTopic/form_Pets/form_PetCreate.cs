using Ispan147.Estore.SqlDataLayer.Services;
using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.form_Pets
{
	public partial class form_PetCreate : Form
	{
		private bool _gender;
		private Dictionary<string, Control> _map;
		private Dictionary<int, string> _mapSpecies = new Dictionary<int, string>();
		private Dictionary<int, string> _mapBreed = new Dictionary<int, string>();
		private string _originalFilePath;
		private string _targetFolderPath = @"images/petavatar/";
		private IPetRepo _petRepo;
		public form_PetCreate()
		{
			InitializeComponent();
			_map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"SpeciesID",comboBoxSpeciesID },
				{"BreedID",comboBoxBreedID },
				{"PetName",txtPetName},
				{"Gender",radioButtonFemale },
				{"Age",txtAge },
				{"Description",txtDescription },
				{"Location",txtLocation },
				{"PetAvatar",txtPetAvatar }
			};
			_petRepo = new PetRepository();

			pbPet.Image = Properties.Resources.CryCat;

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

		private void SelectFileToForm(string filePath)
		{
			try
			{
				string fileName = Path.GetFileName(filePath);
				//加上時間戳重新命名,避免檔名重複
				txtPetAvatar.Text = DateTime.Now.ToString("yyyyMMddhhmmssss_") + fileName;

				MessageBox.Show("選擇成功");

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
				MessageBox.Show($"上傳失敗,原因：{ex.Message}");
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
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
				SpeciesID = speciesID.ToString(),
				BreedID = breedID.ToString(),
				PetName = txtPetName.Text,
				Gender = _gender,
				Age = txtAge.Text,
				Description = txtDescription.Text,
				Location = txtLocation.Text,
				PetAvatar = txtPetAvatar.Text
			};

			//驗證vm是否通過欄位驗證
			bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, _map);
			if (hasError) return;

			try
			{
				PetDto dto = new PetDto
				{
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
				int newID = service.Create(dto);

				UploadFileToDb(_originalFilePath);

				MessageBox.Show($"新增成功,新的編號為{newID}");
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，原因:" + ex.Message);
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

		private void btnPetAvatar_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog selectImage = new OpenFileDialog())
			{
				selectImage.InitialDirectory =
					Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				selectImage.Title = "選擇檔案";
				selectImage.Filter =
					"Image files(*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";
				selectImage.Multiselect = false;

				if (selectImage.ShowDialog() == DialogResult.OK)
				{
					_originalFilePath = selectImage.FileName;

					SelectFileToForm(_originalFilePath);
				}
			}
		}

		private void btnCancelPicture_Click(object sender, EventArgs e)
		{
			txtPetAvatar.Text = null;
			btnCancelPicture.Enabled = false;

			pbPet.Image = Properties.Resources.CryCat;
		}
	}
}
