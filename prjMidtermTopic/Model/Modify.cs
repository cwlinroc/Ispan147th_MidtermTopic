using prjMidtermTopic.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.Model
{
	public class Modifier
	{
		static public void ModForm(Form frm)
		{
			frm.BackColor = Color.FromArgb(200,240,250);
			frm.ShowIcon = false;
			frm.FormBorderStyle = FormBorderStyle.Sizable;
			frm.AutoScroll = true;
			//frm.Icon = Resources.favicon ;
		}

		static public void ModGridView(DataGridView grid)
		{
			//grid.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
			//grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;

			foreach (DataGridViewTextBoxColumn col in grid.Columns)
			{
				col.HeaderCell.Style.Font = new Font("細明體", 9.75F, FontStyle.Bold);
			}

			//grid.DefaultCellStyle.BackColor = Color.WhiteSmoke;
			//grid.DefaultCellStyle.ForeColor = Color.DarkGray;
			//grid.DefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

			grid.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
		}
	}
}
