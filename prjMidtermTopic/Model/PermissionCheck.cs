using ISpan147.Estore.SqlDataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.Model
{
	public class PermissionCheck
	{
		static public bool Enable(int requiredLevel)
		{
			bool result = Authentication.Permission <= requiredLevel;
			
			if (!result)
			{
				MessageBox.Show("權限不足!");
			}

			return result;
		}
	}
}
