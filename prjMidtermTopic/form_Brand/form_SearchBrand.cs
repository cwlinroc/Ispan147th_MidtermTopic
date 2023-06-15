using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.form_Category;
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

namespace prjMidtermTopic.form_Brand
{
	public partial class form_SearchBrand : Form, IGrid
	{
		private IBrandRepository _repo;
		public form_SearchBrand()
		{
			InitializeComponent();

			_repo = new BrandRepository();

			Modifier.ModGridView(dataGridView1);
		}

		List<BrandDto> data;

		#region 開啟&按下搜尋時載入資料
		private void form_SearchBrand_Load(object sender, EventArgs e)
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

		public void Display()
		{
			bool isInt = int.TryParse(this.txt_BrandId.Text, out int brandId);
			int? sId = isInt ? brandId : (int?)null;

			string sName = this.txt_BrandName.Text;

			data = _repo.Search(sId, sName);

			this.dataGridView1.DataSource = data;
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			if (Authentication.Permission >= 4)
			{
				MessageBox.Show("權限不足，無法編輯商品品牌。");
				return;
			}

			int id = this.data[e.RowIndex].BrandId;

			var frm = new form_EditBrand(id);
			frm.Owner = this;
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			var frm = new form_CreateBrand();
			frm.Owner = this;
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		private void btn_DefaultSearch_Click(object sender, EventArgs e)
		{
			DefaultSearch();
		}

		public void DefaultSearch()
		{
			txt_BrandId.Text = string.Empty;
			txt_BrandName.Text = string.Empty;
			Display();
		}
	}
}
