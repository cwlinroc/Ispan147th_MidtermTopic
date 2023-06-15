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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.form_Brand
{
	public partial class form_EditBrand : Form
	{
		private IBrandRepository _repo;
		private readonly int _brandId;
		public form_EditBrand(int brandId)
		{
			_brandId = brandId;

			InitializeComponent();

			_repo = new BrandRepository();
		}

		private (bool isValid, List<ValidationResult> errors) Validate(BrandCreateVM vm)
		{
			ValidationContext context = new ValidationContext(vm, null, null);

			List<ValidationResult> errors = new List<ValidationResult>();

			bool validateAllProperties = true;
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}

		private void DisplayErrors(List<ValidationResult> errors)
		{
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"BrandName", txt_BrandName}
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

		private void form_EditBrand_Load(object sender, EventArgs e)
		{
			BrandDto dto = _repo.GetByBrandID(_brandId);
			if (dto == null)
			{
				MessageBox.Show("找不到符合紀錄");
				return;
			}

			txt_BrandId.Text = dto.BrandId.ToString();
			txt_BrandName.Text = dto.BrandName.ToString();

			if (Authentication.Permission >= 3)
			{
				btn_Delete.Enabled = false;
			}
		}

		private void btn_Update_Click(object sender, EventArgs e)
		{
			var vm = new BrandCreateVM()
			{
				BrandId = this._brandId,
				BrandName = txt_BrandName.Text
			};

			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (!validationResult.isValid)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			BrandDto dto = new BrandDto
			{
				BrandId = vm.BrandId,
				BrandName = vm.BrandName
			};

			try
			{
				var service = new BrandService(_repo);
				int rows = service.Update(dto);

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

			IGrid parent = this.Owner as IGrid;
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
			try
			{
				if (MessageBox.Show("確定要刪除資料嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					int rows = _repo.Delete(_brandId);
					this.Close();

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

				IGrid parent = this.Owner as IGrid;
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
