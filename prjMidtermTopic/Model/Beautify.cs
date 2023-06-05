using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UClass.View.Login;

namespace prjMidtermTopic.Model
{
	public class Beautify
	{
		static public void SetFormRoundRectRgn(Form form, int rgnRadius)
		{
			int hRgn = 0;
			hRgn = Win32.CreateRoundRectRgn(0, 0, form.Width + 1, form.Height + 1, rgnRadius, rgnRadius);
			Win32.SetWindowRgn(form.Handle, hRgn, true);
			Win32.DeleteObject(hRgn);
		}
	}

	
}
