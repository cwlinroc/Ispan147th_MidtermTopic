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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjMidtermTopic.form_Merchandise
{
	public partial class form_CreateMerchandise : Form
	{

		private int _categoryId;
		public form_CreateMerchandise()
		{
			InitializeComponent();

			comboBox_CategoryId.Items.AddRange(ChooseCategory.categoryNameOptions);
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
			switch (comboBox_CategoryId.SelectedIndex)
			{
				case 1:
					_categoryId = 1;
					break;
				case 2:
					_categoryId = 2;
					break;
				case 3:
					_categoryId = 3;
					break;
				case 4:
					_categoryId = 4;
					break;
				case 5:
					_categoryId = 5;
					break;
				case 6:
					_categoryId = 6;
					break;
				case 7:
					_categoryId = 7;
					break;
				case 8:
					_categoryId = 8;
					break;
				case 9:
					_categoryId = 9;
					break;
				case 10:
					_categoryId = 10;
					break;
				default:
					_categoryId = 0;
					break;
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			//收集表單欄位值建立MerchandiseCreateVM物件
			bool PriceisInt = int.TryParse(txt_Price.Text, out int Price);
			Price = PriceisInt ? Price : 0;
			bool AmountisInt = int.TryParse(txt_Price.Text, out int Amount);
			Amount = AmountisInt ? Amount : 0;

			int categoryId = comboBox_CategoryId.SelectedIndex;

			string marchandisename = txt_MerchandiseName.Text;
			string Description = txt_Description.Text;
			string ImageURL = txt_ImageURL.Text;

			var vm = new MerchandiseCreateVM() { MerchandiseName = marchandisename, CategoryID = categoryId,
												Price = Price, Amount = Amount,
												Description = Description, ImageURL = ImageURL
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
				var service = new MerchandiseService();
				int newId = service.Create(dto);
				MessageBox.Show($"新增成功，新的ID為{newId}。");
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，原因：" + ex.Message);
			}

			//關閉表單
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
	}
}
