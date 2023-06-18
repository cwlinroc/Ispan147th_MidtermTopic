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
	public partial class form_CreateBrand : Form
	{
		private IBrandRepository _repo;
		public form_CreateBrand()
		{
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

		private void btn_Add_Click(object sender, EventArgs e)
		{
			string brandname = txt_BrandName.Text;

			var vm = new BrandCreateVM()
			{
				BrandName = brandname
			};

			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
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
				int newId = service.Create(dto);
				MessageBox.Show($"新增成功，新的ID為{newId}。");
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
	}
}
