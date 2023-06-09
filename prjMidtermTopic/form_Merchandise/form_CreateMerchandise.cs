﻿using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace prjMidtermTopic.form_Merchandise
{
	public partial class form_CreateMerchandise : Form
	{
		private IMerchandiseRepository _repo;
		private ICategoryRepository _categoryRepository;
		private Dictionary<int, string> map = new Dictionary<int, string>();
		private int _categoryId;
		private string _imagePath = string.Empty;
		//改使用內嵌影像
		//string defaultImageURL = @"images/MerchandisePicture/default.png";
	
		public form_CreateMerchandise()
		{
			InitializeComponent();

			_repo = new MerchandiseRepository();
			_categoryRepository = new CategoryRepository();

			//顯示預設圖片
			#region 其他圖片載入方法
			//pictureBox_Image.Image = Image.FromFile(defaultImageURL);

			//using (var bmpTemp = new Bitmap(defaultImageURL))
			//{
			//	pictureBox_Image.Image = new Bitmap(bmpTemp);
			//}
			#endregion
			//使用內嵌影像，不從資料夾讀取，適合於系統預設圖片
			pictureBox_Image.Image = Properties.Resources._default;
			
			//動態生成商品類別資料 for 下拉選單
			map.Add(0, "未選擇");
			new CategoryService(_categoryRepository).Search().ForEach(c => map.Add(c.CategoryId, c.CategoryName));
			foreach (var item in map)
			{
				comboBox_CategoryId.Items.Add(item);
			}
			comboBox_CategoryId.DisplayMember = "Value";

			//設定預設值
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
			bool AmountisInt = int.TryParse(txt_Amount.Text, out int Amount);
			Amount = AmountisInt ? Amount : -1;
			// ↓讀取下拉選單的欄位值
			int categoryId = (comboBox_CategoryId.SelectedItem as dynamic).Key;
			string marchandisename = txt_MerchandiseName.Text;
			string Description = (string.IsNullOrEmpty(txt_Description.Text)) ? null : txt_Description.Text;
			string ImageURL = (string.IsNullOrEmpty(txt_ImageURL.Text)) ? null : txt_ImageURL.Text;

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
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

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
				var service = new MerchandiseService(_repo);
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

		#region 圖片上傳
		private void btn_SelectImage_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog selectImage = new OpenFileDialog())
			{
				selectImage.InitialDirectory =
					Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				selectImage.Title = "選擇檔案";
				selectImage.Filter = "Image files(*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";
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
			try
			{
				// 使用時間戳系統性改名，避免資料庫內名稱重複
				txt_ImageURL.Text = DateTime.Now.ToString("yyyyMMddhhmmssffff") + 
																Path.GetFileName(imagePath);

				MessageBox.Show($"圖片選擇成功,路徑:{imagePath}");

				btn_CancelImage.Enabled = true;

				//顯示預覽圖片
				//pictureBox_Image.Image = Image.FromFile(imagePath);
				//使用Bitmap轉檔，並兩次使用以達到暫存效果(??)並降低系統負擔
				using (var bmpTemp = new Bitmap(imagePath))
				{
					pictureBox_Image.Image = new Bitmap(bmpTemp);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("選擇失敗，原因：" + ex.Message);
			}
		}

		private void UploadToDb(string imagePath)
		{
			string targetFolderPath = @"images/MerchandisePicture/";
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
			txt_ImageURL.Text = null;
			btn_CancelImage.Enabled = false;
						
			pictureBox_Image.Image = Properties.Resources._default;
		}
		#endregion
	}
}
