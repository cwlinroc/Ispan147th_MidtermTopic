using ISpan147.Estore.SqlDataLayer.Dtos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjMidtermTopic.form_Merchandise
{
	public partial class form_EditMerchandise : Form
	{
		private IMerchandiseRepository _repo;
		private ICategoryRepository _categoryRepository;
		private Dictionary<int, string> map = new Dictionary<int, string>();
		private readonly int _merchandiseId;
		private string _newimagePath;
		private string _iniImageURL;
		private string _lasttargetFilePath;
		public form_EditMerchandise(int merchandiseId)
		{
			_merchandiseId = merchandiseId;

			InitializeComponent();

			_repo = new MerchandiseRepository();
			_categoryRepository = new CategoryRepository();

			//動態生成類別資料 for 下拉選單
			map.Add(0, "未選擇");
			new CategoryService(_categoryRepository).Search().ForEach(c => map.Add(c.CategoryId, c.CategoryName));
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

		private void form_EditMerchandise_Load(object sender, EventArgs e)
		{
			//var repo = new MerchandiseRepository();
			MerchandiseDto dto = _repo.GetByMerchandiseID(_merchandiseId);
			if (dto == null)
			{
				MessageBox.Show("找不到符合紀錄");
				return;
			}

			txt_MerchandiseId.Text = dto.MerchandiseID.ToString();
			txt_MerchandiseName.Text = dto.MerchandiseName.ToString();
			comboBox_CategoryId.SelectedItem = comboBox_CategoryId.Items.Cast<dynamic>()
														.FirstOrDefault(x => x.Key == dto.CategoryID);
			txt_Price.Text = dto.Price.ToString();
			txt_Amount.Text = dto.Amount.ToString();
			txt_Description.Text = dto.Description.ToString();
			txt_ImageURL.Text = dto.ImageURL.ToString();

			_iniImageURL = dto.ImageURL.ToString();
			_lasttargetFilePath = @"images/MerchendisePicture/" + dto.ImageURL.ToString();

			btn_DeleteImage.Enabled = (txt_ImageURL.Text.Length > 0) ? true : false;
		}

		private void btn_SelectNewImage_Click(object sender, EventArgs e)
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
					_newimagePath = selectImage.FileName;

					UploadToForm(_newimagePath);
				}
			}
		}

		private void UploadToForm(string newimagePath)
		{
			try
			{
				// 使用時間戳系統性改名，避免資料庫內名稱重複
				txt_ImageURL.Text = DateTime.Now.ToString("yyyyMMddhhmmssss") +
																Path.GetFileName(newimagePath);

				MessageBox.Show($"圖片選擇成功,路徑:{newimagePath}");

				btn_DeleteImage.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("選擇失敗，原因：" + ex.Message);

			}
		}
		private void UploadToDb(string newimagePath)
		{
			DeleteFromDb();

			string targetFolderPath = @"images/MerchendisePicture/";
			string newimageName = Path.GetFileName(newimagePath);
			string renamedtargetFilePath = targetFolderPath + txt_ImageURL.Text;

			try
			{
				File.Copy(newimagePath, renamedtargetFilePath);

				MessageBox.Show($"上傳成功");
			}
			catch (Exception ex)
			{
				MessageBox.Show("上傳失敗，原因：" + ex.Message);
			}
		}

		private void btn_DeleteImage_Click(object sender, EventArgs e)
		{

			if (File.Exists(_lasttargetFilePath))
			{
				try
				{
					txt_ImageURL.Text = string.Empty;

					MessageBox.Show("儲存後將刪除商品圖片");

					btn_DeleteImage.Enabled = false;
				}
				catch (Exception ex)
				{
					MessageBox.Show("刪除失敗，原因：" + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("本商品無圖片檔");

				btn_DeleteImage.Enabled = false;
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
				btn_DeleteImage.Enabled = false;
			}
		}

		private void btn_Updata_Click(object sender, EventArgs e)
		{
			//收集表單欄位值到dto
			bool PriceisInt = int.TryParse(txt_Price.Text, out int Price);
			Price = PriceisInt ? Price : 0;
			bool AmountisInt = int.TryParse(txt_Amount.Text, out int Amount);
			Amount = AmountisInt ? Amount : 0;

			var vm = new MerchandiseCreateVM()
			{
				MerchandiseId = this._merchandiseId,
				MerchandiseName = txt_MerchandiseName.Text,
				CategoryID = (comboBox_CategoryId.SelectedItem as dynamic).Key,
				Price = Price,
				Amount = Amount,
				Description = txt_Description.Text,
				ImageURL = txt_ImageURL.Text
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
				int rows = service.Update(dto);

				if (txt_ImageURL.Text != _iniImageURL && txt_ImageURL.Text.Length > 0)
				{
					UploadToDb(_newimagePath);
				}
				if (txt_ImageURL.Text != _iniImageURL && txt_ImageURL.Text.Length == 0)
				{
					DeleteFromDb();
				}

				//回到FormCategories
				if (rows > 0)
				{
					MessageBox.Show("更新成功");

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
				else
				{
					MessageBox.Show("更新失敗，原因為：該紀錄可能已被其他使用者刪除");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，原因：" + ex.Message);
			}
		}
		private void btn_Delete_Click(object sender, EventArgs e)
		{
			//var repo = new MerchandiseRepository();
			var service = new MerchandiseService(_repo);
			try
			{
				if (MessageBox.Show("確定要刪除資料嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					DeleteFromDb();

					int rows = service.Delete(_merchandiseId);

					this.Close();
					//回到FormCategories
					if (rows > 0)
					{
						MessageBox.Show("刪除成功");
					}
					else
					{
						MessageBox.Show("刪除失敗");
					}
				}
				else
				{
					MessageBox.Show("取消刪除");
					this.Close();
					return;
				}

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
				MessageBox.Show("刪除失敗，失敗原因：" + ex.Message);
			}
		}
	}
}