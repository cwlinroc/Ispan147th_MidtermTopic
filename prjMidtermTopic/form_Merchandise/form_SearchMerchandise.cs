using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.form_Merchandise;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjMidtermTopic
{
	public partial class form_SearchMerchandise : Form, IGrid
	{
		private IMerchandiseRepository _repo;
		private ICategoryRepository _categoryRepository;
		private Dictionary<int, string> map = new Dictionary<int, string>();
		private readonly string[] SortingOptionNames = new string[] {"商品編號", "商品名稱",
													"商品類別", "價格", "庫存數量" };
		private readonly string[] SortingOptions = new string[] {"MerchandiseID", "MerchandiseName",
													"CategoryID", "Price", "Amount" };
		private int _sortIndex;
		private readonly Dictionary<string, Func<MerchandiseSearchDto, MerchandiseSearchDto, int>> _sortMap;
		List<MerchandiseSearchDto> _data;
		public form_SearchMerchandise()
		{
			InitializeComponent();

			_repo = new MerchandiseRepository();
			_categoryRepository = new CategoryRepository();

			_sortMap = new Dictionary<string, Func<MerchandiseSearchDto, MerchandiseSearchDto, int>>
			{
				{"MerchandiseID", (prev, next) =>prev.MerchandiseID.CompareTo(next.MerchandiseID)},
				{"MerchandiseName", (prev, next) =>prev.MerchandiseName.CompareTo(next.MerchandiseName)},
				{"CategoryID", (prev, next) =>prev.CategoryID.CompareTo(next.CategoryID)},
				{"CategoryName", (prev, next) =>prev.CategoryName.CompareTo(next.CategoryName)},
				{"Price", (prev, next) =>prev.Price.CompareTo(next.Price)},
				{"Amount", (prev, next) =>prev.Amount.CompareTo(next.Amount)},
				//{"Description", (prev, next) =>prev.Description.CompareTo(next.Description)},
				//{"ImageURL", (prev, next) =>prev.ImageURL.CompareTo(next.ImageURL)},
			};

			#region 產生商品類別選單選項

			map.Add(0, "未選擇");
			new CategoryService(_categoryRepository).Search().ForEach(c => map.Add(c.CategoryId, c.CategoryName));
			foreach (var item in map)
			{
				comboBox_CategoryId.Items.Add(item);
			}
			comboBox_CategoryId.DisplayMember = "Value";

			comboBox_CategoryId.SelectedIndex = 0;

			#endregion

			#region 產生搜尋條件選單選項

			comboBox_SortBy.Items.AddRange(SortingOptionNames);
			comboBox_SortBy.SelectedIndex = 0;

			#endregion

			Modifier.ModGridView(dataGridView1);
		}

		#region 功能/方法

		//載入資料
		public void Display()
		{
			try
			{
				//驗證價格區間
				int? maxprice = int.TryParse(this.txt_MaxPrice.Text, out int maprice) ? maprice : (int?)null;
				int? minprice = int.TryParse(this.txt_MinPrice.Text, out int miprice) ? miprice : (int?)null;
				if (maxprice < minprice)
				{
					MessageBox.Show("請輸入正確的價格區間");
					return;
				}

				//讀取篩選條件
				/*	第一版條件搜尋
				bool isInt = int.TryParse(this.txt_MerchandiseId.Text, out int merchandiseId);
				int? sId = isInt ? merchandiseId : (int?)null;
				string sName = this.txt_MerchandiseName.Text;
				int sCategoryId = (this.comboBox_CategoryId.SelectedItem as dynamic).Key;	*/
				var csDto = GetSearchDto();

				//取得符合紀錄
				/*	直接讀取資料庫
				var repo = new MerchandiseRepository();
				data = repo.Search(sId, sName, sCategoryId);
				 */
				//使用商業邏輯檢查
				//var service = new MerchandiseService(_repo);
				//_data = service.Search(sId, sName, sCategoryId);
				var conditionDtoList = new MerchandiseService(_repo);
				_data = conditionDtoList.Search(csDto).ToList();	//使用ToList()從IEnumerable< >轉型為List< >

				//匯入DataGridView
				this.dataGridView1.DataSource = _data;
			}
			catch (Exception ex)
			{
				MessageBox.Show("資料查詢失敗，可能原因：" + ex.Message);
			}
		}

		private MerchandiseConditionSearchDto GetSearchDto()
		{
			var csDto = new MerchandiseConditionSearchDto();

			#region 讀取篩選條件
			if (int.TryParse(txt_MerchandiseId.Text.Trim(), out int _merchandiseId))
			{
				csDto.MerchandiseID = _merchandiseId;
			}
			if (txt_MerchandiseName.Text.Trim().Length > 0)
			{
				csDto.MerchandiseName = txt_MerchandiseName.Text.Trim();
			}
			if (comboBox_CategoryId.SelectedIndex != 0)
			{
				csDto.CategoryID = (comboBox_CategoryId.SelectedItem as dynamic).Key;
			}
			if (int.TryParse(txt_MaxPrice.Text.Trim(), out int _maxprice))
			{
				csDto.MaxPrice = _maxprice;
			}
			if (int.TryParse(txt_MinPrice.Text.Trim(), out int _minprice))
			{
				csDto.MinPrice = _minprice;
			}
			if (checkBox_MaxData.Checked)
			{
				csDto.MaxQueryNumber = int.Parse(txt_MaxQuery.Text.Trim());
			}
			csDto.Descending = true;
			if (checkBox_desc.Checked)
			{
				csDto.Descending = false;
			}
			csDto.OrderBy = SortingOptions[comboBox_SortBy.SelectedIndex];
			#endregion

			return csDto;
		}

		public void OrderByHeader(int columnIndex)
		{
			//取得點選的資料欄名稱
			string colProp = dataGridView1.Columns[columnIndex].DataPropertyName;

			if (_sortMap.TryGetValue(colProp, out Func<MerchandiseSearchDto, MerchandiseSearchDto, int> func))
			{
				if (_sortIndex == columnIndex)
				{
					_data.Sort((x, y) => func(y, x));
					_sortIndex = -1;
				}
				else
				{
					{
						_data.Sort((x, y) => func(x, y));
						_sortIndex = columnIndex;
					}
				}

				dataGridView1.DataSource = _data.ToArray();
			}
		}

		public void DefaultSearch()
		{
			txt_MerchandiseId.Text = string.Empty;
			txt_MerchandiseName.Text = string.Empty;
			comboBox_CategoryId.SelectedIndex = 0;
			txt_MaxPrice.Text = string.Empty;
			txt_MinPrice.Text = string.Empty;
			txt_MaxQuery.Text = "100";
			comboBox_SortBy.SelectedIndex = 0;
			checkBox_MaxData.Checked = true;
			checkBox_desc.Checked = false;
			Display();
		}

		#endregion

		#region 資料載入/排序相關功能
		private void FormSearchMerchandise_Load(object sender, EventArgs e)
		{
			if (Authentication.Permission >= 5)
			{
				btn_Add.Enabled = false;
			}

			Display();
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void btn_DefaultSearch_Click(object sender, EventArgs e)
		{
			DefaultSearch();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) return;

			OrderByHeader(e.ColumnIndex);
		}
		#endregion

		#region 其他增修查改功能按鈕

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int id = this._data[e.RowIndex].MerchandiseID;

			var frm = new form_EditMerchandise(id);
			frm.Owner = this;
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			var frm = new form_CreateMerchandise();
			frm.Owner = this;
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}
		#endregion
	}
}
