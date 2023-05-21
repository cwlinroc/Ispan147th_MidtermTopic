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
