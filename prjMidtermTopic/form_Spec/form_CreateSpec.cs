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

namespace prjMidtermTopic.form_Spec
{
	public partial class form_CreateSpec : Form
	{
		private ISpecRepository _repo;
		private readonly int _merchandiseId;
		private readonly string _merchandiseName;
		public form_CreateSpec(int merchandiseId, string merchandiseName)
		{
			_merchandiseId = merchandiseId;
			_merchandiseName = merchandiseName;

			InitializeComponent();

			_repo = new SpecRepository();
		}

		private void form_CreateSpec_Load(object sender, EventArgs e)
		{
			txt_MerchandiseName.Text = _merchandiseName;
		}

		private (bool isValid, List<ValidationResult> errors) Validate(SpecCreateVM vm)
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
				{"SpecName", txt_SpecName},
				{"Price", txt_Price},
				{"Amount", txt_Amount}
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
			//收集表單欄位值建立SpecCreateVM物件
			int merchandiseId = _merchandiseId;
			string specName = txt_SpecName.Text;
			int price = int.Parse(txt_Price.Text);
			int amount = int.Parse(txt_Amount.Text);

			var vm = new SpecCreateVM()
			{
				SpecName = specName,
				MerchandiseId = merchandiseId,
				Price = price,
				Amount = amount
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

			//通過驗證則將vm轉型為dto
			SpecDto dto = new SpecDto
			{
				SpecName = vm.SpecName,
				MerchandiseId = vm.MerchandiseId,
				Price = vm.Price,
				Amount = vm.Amount
			};
			try
			{
				var service = new SpecService(_repo);
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
