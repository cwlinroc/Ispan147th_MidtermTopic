﻿using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using prjMidtermTopic.form_Merchandise;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic
{
    public partial class form_SearchMerchandise : Form
    {
        public form_SearchMerchandise()
        {
            InitializeComponent();
		}

		List<MerchandiseDto> data;

		#region 開啟&按下搜尋時載入資料
		private void FormSearchMerchandise_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			Display();
		}
		#endregion

		//載入資料
		public void Display()
		{
			//讀取篩選條件
			bool isInt = int.TryParse(this.txt_MerchandiseId.Text, out int merchandiseId);
			int? sId = isInt ? merchandiseId : (int?)null;

			string sName = this.txt_MerchandiseName.Text;

			// todo 下拉式選單設定key=categoryName, value=categoryId

			//取得符合紀錄
			var repo = new MerchandiseRepository();
			data = repo.Search(sId, sName);

			//匯入DataGridView
			this.dataGridView1.DataSource = data;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int id = this.data[e.RowIndex].MerchandiseId;

			var frm = new form_EditMerchandise(id);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			var frm = new form_CreateMerchandise();
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
