using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.form_Category
{
	public partial class form_EditCategory : Form
	{
		private ICategoryRepository _repo;
		private readonly int _categoryId;
		public form_EditCategory(int categoryId)
		{
			_categoryId = categoryId;

			InitializeComponent();

			_repo = new CategoryRepository();
		}

		private (bool isValid, List<ValidationResult> errors) Validate(CategoryCreateVM vm)
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
				{"CategoryName", txt_CategoryName}
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

		private void form_EditCategory_Load(object sender, EventArgs e)
		{
			//var repo = new CategoryRepository();
			CategoryDto dto = _repo.GetByCategoryID(_categoryId);
			if (dto == null)
			{
				MessageBox.Show("找不到符合紀錄");
				return;
			}

			txt_CategoryId.Text = dto.CategoryId.ToString();
			txt_CategoryName.Text = dto.CategoryName.ToString();

			if (Authentication.Permission >= 3)
			{
				btn_Delete.Enabled = false;
			}
		}

		private void btn_Update_Click(object sender, EventArgs e)
		{
			//收集表單欄位值到dto
			var vm = new CategoryCreateVM()
			{
				CategoryId = this._categoryId,
				CategoryName = txt_CategoryName.Text
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
			CategoryDto dto = new CategoryDto
			{
				CategoryId = vm.CategoryId,
				CategoryName = vm.CategoryName
			};

			try
			{
				var service = new CategoryService(_repo);
				int rows = service.Update(dto);

				//回到Form
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
			//var repo = new CategoryRepository();
			try
			{
				if (MessageBox.Show("確定要刪除資料嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					int rows = _repo.Delete(_categoryId);
					this.Close();
					//回到Form
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
