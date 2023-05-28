using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.Model
{
	
	public class MyValidator
	{
		/// <summary>
		/// 驗證View Model是否符合其Attribute的設定，若有錯誤則在對應的控制項跳出錯誤，並回傳true
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="vm">要進行驗證的View Model</param>
		/// <param name="provider">WinForm的ErrorProvider控制項</param>
		/// <param name="map">屬性名稱以及對應顯示錯誤的控制項</param>
		/// <returns>有無錯誤，有錯回傳true，反之則回傳false</returns>
		static public bool ValidateAndDisplay<T>(T vm, ErrorProvider provider, Dictionary<string, Control> map)
		{
			ValidationContext context = new ValidationContext(vm);

			List<ValidationResult> errors = new List<ValidationResult>();

			bool isValid = System.ComponentModel.DataAnnotations.Validator.TryValidateObject(vm, context, errors, true);

			if (isValid) return false;

			provider.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					provider.SetError(ctrl, error.ErrorMessage);
				}
			}

			return true;
		}
	}
}
