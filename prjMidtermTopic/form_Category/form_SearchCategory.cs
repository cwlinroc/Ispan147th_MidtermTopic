using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using prjMidtermTopic.form_Merchandise;
using prjMidtermTopic.Interfaces;
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
		public form_SearchCategory()
		{
			InitializeComponent();
		}

		List<CategoryDto> data;

		#region 開啟&按下搜尋時載入資料
		private void form_SearchCategory_Load(object sender, EventArgs e)
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
			bool isInt = int.TryParse(this.txt_CategoryId.Text, out int categoryId);
			int? sId = isInt ? categoryId : (int?)null;

			string sName = this.txt_CategoryName.Text;

			//取得符合紀錄
			var repo = new CategoryRepository();
			data = repo.Search(sId, sName);

			//匯入DataGridView
			this.dataGridView1.DataSource = data;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

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
	}
}
