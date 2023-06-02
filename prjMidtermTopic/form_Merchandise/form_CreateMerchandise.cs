using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjMidtermTopic.form_Merchandise
{
	public partial class form_CreateMerchandise : Form
	{
		private Dictionary<int, string> map = new Dictionary<int, string>();

		private int _categoryId;

		private string _imagePath = string.Empty;
		public form_CreateMerchandise()
		{
			InitializeComponent();

			//動態生成類別資料 for 下拉選單
			map.Add(0, "未選擇");
			new CategoryService().Search().ForEach(c => map.Add(c.CategoryId, c.CategoryName));
			foreach (var item in map)
			{
				comboBox_CategoryId.Items.Add(item);
			}
			comboBox_CategoryId.DisplayMember = "Value";

			//設定類別選單資料來源&預設值
			comboBox_CategoryId.SelectedIndex = 0;
		}

		private (bool isValid, List<ValidationResult> errors) Validate(MerchandiseCreateVM vm)
		{
			//取得驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			//建立存放錯誤集合
			List<ValidationResult> errors = new List<ValidationResult>();

			//驗證model
			bool validateAllProperties = true;
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}

		private void DisplayErrors(List<ValidationResult> errors)
		{
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"MerchandiseName", txt_MerchandiseName},
				{"CategoryId ", comboBox_CategoryId},
				{"Price", txt_Price},
				{"Amount", txt_Amount},
				{"Description", txt_Description},
				{"ImageURL", txt_ImageURL}
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

		private void comboBox_CategoryId_SelectedIndexChanged(object sender, EventArgs e)
		{
			_categoryId = (comboBox_CategoryId.SelectedItem as dynamic).Key;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			//收集表單欄位值建立MerchandiseCreateVM物件
			bool PriceisInt = int.TryParse(txt_Price.Text, out int Price);
			Price = PriceisInt ? Price : 0;
			bool AmountisInt = int.TryParse(txt_Price.Text, out int Amount);
			Amount = AmountisInt ? Amount : 0;
			// 讀取下拉選單的欄位值
			int categoryId = (comboBox_CategoryId.SelectedItem as dynamic).Key;
			string marchandisename = txt_MerchandiseName.Text;
			string Description = txt_Description.Text;
			string ImageURL = txt_ImageURL.Text;

			var vm = new MerchandiseCreateVM()
			{
				MerchandiseName = marchandisename,
				CategoryID = categoryId,
				Price = Price,
				Amount = Amount,
				Description = Description,
				ImageURL = ImageURL
			};

			//驗證vm是否通過欄位驗證
			(bool isValid, List < ValidationResult > errors) validationResult = Validate(vm);

			//若有錯則顯示
			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			//通過驗證則將vm轉型為MerchandiseDto
			MerchandiseDto dto = new MerchandiseDto
			{
				MerchandiseID = vm.MerchandiseId,
				MerchandiseName = vm.MerchandiseName,
				CategoryID = vm.CategoryID,
				Price = vm.Price,
				Amount = vm.Amount,
				Description = vm.Description,
				ImageURL = vm.ImageURL
			};
			try
			{
				var service = new MerchandiseService();
				int newId = service.Create(dto);
				
				if (txt_ImageURL.Text.Length > 0)
				{
					UploadToDb(_imagePath);
				}

				MessageBox.Show($"新增成功，新的ID為{newId}。");

				//成功則關閉表單
				IGrid parent = this.Owner as IGrid; //將開啟視窗轉型為IGrid，若轉型失敗不會丟出例外，而是回傳NULL
				if (parent == null)
				{
					MessageBox.Show("開啟用的表單沒有實作IGrid，因此無法回送通知");
				}
				else
				{
					parent.Display();
				}

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，原因：" + ex.Message);
			}
		}

		private void btn_SelectImage_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog selectImage = new OpenFileDialog())
			{
				selectImage.InitialDirectory =
					Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				selectImage.Title = "選擇檔案";
				selectImage.Filter = "(*.png)|*.png|(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.gif)|*.gif";
				selectImage.Multiselect = false;

				if (selectImage.ShowDialog() == DialogResult.OK)
				{
					_imagePath = selectImage.FileName;

					UploadToForm(_imagePath);
				}
			}
		}

		private void UploadToForm(string imagePath)
		{
			string targetFolderPath = @"images/MerchendisePicture/";
			string imageName = Path.GetFileName(imagePath);
			string targetFilePath = Path.Combine(targetFolderPath, imageName);

			try
			{
				// 使用時間戳系統性改名，避免資料庫內名稱重複
				txt_ImageURL.Text = DateTime.Now.ToString("yyyyMMddhhmmssss") + 
																Path.GetFileName(imagePath);

				MessageBox.Show($"圖片選擇成功,路徑:{imagePath}");

				btn_CancelImage.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("選擇失敗，原因：" + ex.Message);

			}
		}

		private void UploadToDb(string imagePath)
		{
			string targetFolderPath = @"images/MerchendisePicture/";
			string imageName = Path.GetFileName(imagePath);
			// 使用時間戳系統性改名，避免資料庫內名稱重複
			string renamedtargetFilePath = targetFolderPath + txt_ImageURL.Text;

			try
			{
				File.Copy(imagePath, renamedtargetFilePath);//(來源路徑(原始名), 目標路徑(改名))

				MessageBox.Show($"圖片上傳成功");
			}
			catch (Exception ex)
			{
				MessageBox.Show("圖片上傳失敗，原因：" + ex.Message);

			}
		}

		private void btn_CancelImage_Click(object sender, EventArgs e)
		{
			txt_ImageURL.Text = string.Empty;
			btn_CancelImage.Enabled = false;
		}
	}
}
