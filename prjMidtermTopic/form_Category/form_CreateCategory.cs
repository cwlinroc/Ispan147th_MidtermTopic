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

namespace prjMidtermTopic.form_Category
{
	public partial class form_CreateCategory : Form
	{
		public form_CreateCategory()
		{
			InitializeComponent();
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

		private void btn_Add_Click(object sender, EventArgs e)
		{
			//收集表單欄位值建立CategoryCreateVM物件
			string categoryname = txt_CategoryName.Text;

			var vm = new CategoryCreateVM()
			{
				CategoryName = categoryname
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
				var service = new CategoryService();
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
