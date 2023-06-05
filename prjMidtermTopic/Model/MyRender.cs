using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.Model
{
	public class MyRender : ToolStripSystemRenderer
	{
		public MyRender() { }

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			if (!(e.ToolStrip is ToolStrip))
			{
				base.OnRenderToolStripBorder(e);
			}
		}
	}
}
