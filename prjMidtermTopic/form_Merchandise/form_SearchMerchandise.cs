using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.form_Merchandise;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjMidtermTopic
{
	// todo 增加反轉注入、排序
    public partial class form_SearchMerchandise : Form, IGrid
	{

		private Dictionary<int, string> map = new Dictionary<int, string>();
		public form_SearchMerchandise()
        {
            InitializeComponent();

			//動態生成類別資料 for 下拉選單
			map.Add(0, "未選擇");
			new CategoryService().Search().ForEach(c => map.Add(c.CategoryId, c.CategoryName));
			foreach(var item in map)
			{
				comboBox_CategoryId.Items.Add(item);
			}
			comboBox_CategoryId.DisplayMember = "Value";

			//設定類別選單資料來源&預設值
			comboBox_CategoryId.SelectedIndex = 0;
		}

		List<MerchandiseSearchDto> data;

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

			int sCategoryId = this.comboBox_CategoryId.SelectedIndex;

			//取得符合紀錄
			//var repo = new MerchandiseRepository();
			//data = repo.Search(sId, sName, sCategoryId);
			var service = new MerchandiseService();
			data = service.Search(sId, sName, sCategoryId);

			//匯入DataGridView
			this.dataGridView1.DataSource = data;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int id = this.data[e.RowIndex].MerchandiseID;

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
