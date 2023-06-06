using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.form_Merchandise;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.form_Category
{
	public partial class form_SearchCategory : Form, IGrid
	{
		private ICategoryRepository _repo;
		public form_SearchCategory()
		{
			InitializeComponent();

			_repo = new CategoryRepository();

			Modifier.ModGridView(dataGridView1);
		}

		List<CategoryDto> data;

		#region 開啟&按下搜尋時載入資料
		private void form_SearchCategory_Load(object sender, EventArgs e)
		{
			Display();

			if (Authentication.Permission >= 4)
			{
				btn_Add.Enabled = false;
			}
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
			bool isInt = int.TryParse(this.txt_CategoryId.Text, out int categoryId);
			int? sId = isInt ? categoryId : (int?)null;

			string sName = this.txt_CategoryName.Text;

			//取得符合紀錄
			//var repo = new CategoryRepository();
			data = _repo.Search(sId, sName);

			//匯入DataGridView
			this.dataGridView1.DataSource = data;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			if (Authentication.Permission >= 4)
			{
				MessageBox.Show("權限不足，無法編輯商品類別。");
				return;
			}

			int id = this.data[e.RowIndex].CategoryId;

			var frm = new form_EditCategory(id);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			var frm = new form_CreateCategory();
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void btn_DefaultSearch_Click(object sender, EventArgs e)
		{
			DefaultSearch();
		}

		public void DefaultSearch()
		{
			txt_CategoryId.Text = string.Empty;
			txt_CategoryName.Text = string.Empty;
			Display();
		}
	}
}
