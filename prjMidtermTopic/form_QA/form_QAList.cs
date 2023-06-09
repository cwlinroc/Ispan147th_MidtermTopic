using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.form_QA;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
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
    public partial class form_QAList : Form , IGrid
	{
		QAService _service;
		
		public form_QAList()
		{
            InitializeComponent();
			_service = new QAService();

			Modifier.ModGridView(dataGridViewTheme);
		}

		private void form_QAList_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			var data = _service.SearchTheme(this.textBoxSearch.Text);
			
			// 繫結到DataGridView
			DataGridViewThemeShow(data);
		}

		public void Display()
		{
			// 叫用Search(),取得符合的記錄
			var data = _service.GetThemeList(null);
			// 繫結到DataGridView
			DataGridViewThemeShow(data);
		}

		private void DataGridViewThemeShow(List<Theme> data)
		{
			this.dataGridViewTheme.DataSource = data;
			this.dataGridViewTheme.Columns["ForumAccountId"].Visible = false;
			this.dataGridViewTheme.Columns["ForumAccountName"].Visible = false;
		}

		//methods
		public void dataGridViewTheme_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			                              //            列                欄位
			var themeId = Convert.ToInt32(dataGridViewTheme.Rows[e.RowIndex].Cells[0].Value);
			//var themeId = this._data[e.RowIndex].ThemeId;
			var selectedThemeId = Convert.ToInt32(dataGridViewTheme.Rows[e.RowIndex].Cells["themeId"].Value);

			var frm = new Form_ThemeCommemt(themeId);
			frm.Owner = this;
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		private void buttonCreateTheme_Click_1(object sender, EventArgs e)
		{
			from_ThemeCreate qaCreate = new from_ThemeCreate();
			qaCreate.Owner = this;
			Modifier.ModForm(qaCreate);
			qaCreate.ShowDialog();
		}
		
		//分頁功能
		public int pageSize = 10;      //顯示頁數
		public int recordCount = 0;    //总记录数
		public int pageCount = 0;      //全部分頁數
		public int currentPage = 0;    //目前頁
		DataTable dtSource = new DataTable();
		/// <summary>
		/// 分頁
		/// </summary>
		private void LoadPage()
		{
			if (currentPage < 1) currentPage = 1;
			if (currentPage > pageCount) currentPage = pageCount;

			int beginRecord;
			int endRecord;
			DataTable dtTemp;
			dtTemp = dtSource.Clone();

			beginRecord = pageSize * (currentPage - 1);
			if (currentPage == 1) beginRecord = 0;
			endRecord = pageSize * currentPage;

			if (currentPage == pageCount) endRecord = recordCount;
			for (int i = beginRecord; i < endRecord; i++)
			{
				dtTemp.ImportRow(dtSource.Rows[i]);
			}
			dataGridViewTheme.DataSource = dtTemp;  
		}

	}
}
