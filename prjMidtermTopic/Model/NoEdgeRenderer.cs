using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.Model
{
	public class NoEdgeRenderer : ToolStripSystemRenderer
	{
		public NoEdgeRenderer() { }

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			if (!(e.ToolStrip is ToolStrip))
			{
				base.OnRenderToolStripBorder(e);
			}
		}
	}

	public class ColoredRenderer : ToolStripProfessionalRenderer
	{
		public ColoredRenderer() : base(new MyColors()) { }

		protected class MyColors : ProfessionalColorTable
		{
			public override Color MenuItemSelected
			{
				get { return Color.Yellow; }
			}
			public override Color MenuItemSelectedGradientBegin
			{
				get { return Color.DarkSeaGreen; }
			}
			public override Color MenuItemSelectedGradientEnd
			{
				get { return Color.Green; }
			}
			public override Color MenuItemPressedGradientEnd 
			{
				get => Color.Blue;
			}
			public override Color MenuItemPressedGradientBegin
			{
				get => Color.Aqua;
			}
		}
	}


}
