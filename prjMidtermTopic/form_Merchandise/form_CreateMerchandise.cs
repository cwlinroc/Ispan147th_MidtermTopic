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

namespace prjMidtermTopic.form_Merchandise
{
	public partial class form_CreateMerchandise : Form
	{
		public form_CreateMerchandise()
		{
			InitializeComponent();
		}

		//todo 建立MerchandiseCreateVM  確認分層 
		//private (bool isValid, List<ValidationResult> errors) Validate(MerchandiseCreateVM vm)
		//{
		//	取得驗證規則
		//	ValidationContext context = new ValidationContext(vm, null, null);

		//	建立存放錯誤集合
		//	List<ValidationResult> errors = new List<ValidationResult>();

		//	驗證model
		//	bool validateAllProperties = true;
		//	bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

		//	return (isValid, errors);
		//}

		private void DisplayErrors(List<ValidationResult> errors)
		{
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"MerchandiseName", txt_MerchandiseName},
				//{"CategoryId ", },	// todo 下拉式選單
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
	}
}
