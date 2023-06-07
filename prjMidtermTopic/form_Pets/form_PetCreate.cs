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
		private string _originalFilePath;
		private string _targetFolderPath = @"images/petavatar/";
		private IPetRepo _petRepo;
		public form_PetCreate()
		{
			InitializeComponent();
			_map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"SpeciesID",txtSpeciesID },
				{"BreedID",txtBreedID },
				{"PetName",txtPetName},
				{"Gender",radioButtonFemale },
				{"Age",txtAge },
				{"Description",txtDescription },
				{"Location",txtLocation },
				{"PetAvatar",txtPetAvatar }
			};
			_petRepo = new PetRepository();

			pbPet.Image = Properties.Resources.CryCat;
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
			var vm = new PetCreateVM()
			{
				SpeciesID = txtSpeciesID.Text,
				BreedID = txtBreedID.Text,
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
			this.Close();
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
