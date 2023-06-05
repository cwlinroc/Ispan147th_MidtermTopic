using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.form_QA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static ISpan147.Estore.SqlDataLayer.Dtos.QADto;

namespace prjMidtermTopic
{
    public partial class form_QAList : Form
    {
		QAService _service;
		//List<QADto> _data;

		public form_QAList()
		{
            InitializeComponent();
			_service = new QAService();
		}

		private void form_QAList_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			var data = _service.SearchTheme(this.textBoxSearch.Text);

			// 繫結到DataGridView
			DataGridView1Show(data);
		}


		private void Display()
		{
			//int? keyword = null;
			//if (string.IsNullOrWhiteSpace(this.textBoxSearch.Text) == false)
			//{
			//	keyword = Convert.ToInt32(this.textBoxSearch.Text);
			//}

			// 叫用Search(),取得符合的記錄
			var data = _service.GetThemeList(null);
			// 繫結到DataGridView
			DataGridView1Show(data);
		}

		private void DataGridView1Show(List<Theme> data)
		{
			this.dataGridView1.DataSource = data;
			this.dataGridView1.Columns["ForumAccountId"].Visible = false;
			this.dataGridView1.Columns["ForumAccountName"].Visible = false;
		}



		//methods

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			                              //            列                欄位
			var themeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
			//var themeId = this._data[e.RowIndex].ThemeId;
			var selectedThemeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["themeId"].Value);


			var frm = new Form_ThemeCommemt(themeId);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void buttonCreateTheme_Click_1(object sender, EventArgs e)
		{
			from_ThemeCreate qaCreate = new from_ThemeCreate();
			qaCreate.Owner = this;
			qaCreate.ShowDialog();
		}










	}
}
