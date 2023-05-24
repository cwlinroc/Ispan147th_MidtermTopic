using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using prjMidtermTopic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjMidtermTopic.form_Merchandise
{
	public partial class form_EditMerchandise : Form
	{
		private readonly int _merchandiseId;
		public form_EditMerchandise(int merchandiseId)
		{
			_merchandiseId = merchandiseId;

			InitializeComponent();
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
				{"CategoryId ", },	// todo 下拉式選單
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
			var repo = new MerchandiseRepository();
			MerchandiseDto dto = repo.GetByID(_merchandiseId);
			if (dto == null)
			{
				MessageBox.Show("找不到符合紀錄");
				return;
			}

			txt_MerchandiseId.Text = dto.MerchandiseId.ToString();
			txt_MerchandiseName.Text = dto.MerchandiseName.ToString();
			// todo 下拉式清單 = dto.CategoryId.ToString();
			txt_Price.Text = dto.Price.ToString();
			txt_Amount.Text = dto.Amount.ToString();
			txt_Description.Text = dto.Description.ToString();
			txt_ImageURL.Text = dto.ImageURL.ToString();
		}

		private void btn_Updata_Click(object sender, EventArgs e)
		{
			//收集表單欄位值到dto
			bool PriceisInt = int.TryParse(txt_Price.Text, out int Price);
			Price = PriceisInt ? Price : 0;
			bool AmountisInt = int.TryParse(txt_Price.Text, out int Amount);
			Amount = AmountisInt ? Amount : 0;

			var vm = new MerchandiseCreateVM()
			{
				MerchandiseId = this._merchandiseId,
				MerchandiseName = txt_MerchandiseName.Text,
				// todo CategoryId
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

			//通過驗證則將vm轉型為CategoryDto
			MerchandiseDto dto = new MerchandiseDto
			{
				MerchandiseId = vm.MerchandiseId,
				MerchandiseName = vm.MerchandiseName,
				CategoryId = vm.CategoryId,
				Price = vm.Price,
				Amount = vm.Amount,
				Description = vm.Description,
				ImageURL = vm.ImageURL
			};

			try
			{
				var service = new MerchandiseService();
				int rows = service.Update(dto);

				//回到FormCategories
				if (rows > 0)
				{
					MessageBox.Show("更新成功");
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

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			var repo = new MerchandiseRepository();
			try
			{
				if (MessageBox.Show("確定要刪除資料嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					int rows = repo.Delete(_merchandiseId);
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
