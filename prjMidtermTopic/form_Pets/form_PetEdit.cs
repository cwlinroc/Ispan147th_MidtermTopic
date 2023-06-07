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
		private readonly int _petID;
		private bool _gender;
		private string _originalFilePath;
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
				{"SpeciesID",txtSpeciesID },
				{"BreedID",txtBreedID },
				{"PetName",txtPetName},
				{"Gender",radioButtonMale},
				{"Age",txtAge},
				{"Description",txtDescription},
				{"Location",txtLocation},
				{"PetAvartar",txtPetAvatar }
			};
			_petRepo = new PetRepository();
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
			txtSpeciesID.Text = dto.SpeciesID.ToString();
			txtBreedID.Text = dto.BreedID.ToString();
			txtPetName.Text = dto.PetName;
			txtAge.Text = dto.Age.ToString();
			txtDescription.Text = dto.Description;
			txtLocation.Text = dto.Location;
			txtPetAvatar.Text = dto.PetAvatar;
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
			var vm = new PetCreateVM()
			{
				PetID = int.Parse(txtPetID.Text),
				SpeciesID = txtSpeciesID.Text,
				BreedID = txtBreedID.Text,
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

				UploadFileToDb(_originalFilePath);

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
					_originalFilePath = openFileDialog.FileName;

					SelectFileToForm(_originalFilePath);
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
