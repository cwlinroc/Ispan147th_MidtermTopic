using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.form_Spec;
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
using System.Xml.Linq;

namespace prjMidtermTopic.form_Merchandise
{
	public partial class form_ViewMerchandise : Form, IGrid
	{
		private IMerchandiseRepository _repo;
		private ICategoryRepository _categoryRepository;
		private IBrandRepository _brandRepository;
		private ISpecRepository _specRepository;
		List<SpecDto> data;
		//private Dictionary<int, string> categorymap = new Dictionary<int, string>();
		//private Dictionary<int, string> brandmap = new Dictionary<int, string>();
		private int _sortIndex;
		private readonly Dictionary<string, Func<SpecDto, SpecDto, int>> _sortMap;
		private readonly int _merchandiseId;
		private string _merchandiseName;
		private string _newimagePath;
		private string _iniImageURL;
		private string _lasttargetFilePath;
		public form_ViewMerchandise(int merchandiseId)
		{
			_merchandiseId = merchandiseId;

			InitializeComponent();

			_repo = new MerchandiseRepository();
			_categoryRepository = new CategoryRepository();
			_brandRepository = new BrandRepository();
			_specRepository = new SpecRepository();

			_sortMap = new Dictionary<string, Func<SpecDto, SpecDto, int>>
			{
				{"SpecName", (prev, next) =>prev.SpecName.CompareTo(next.SpecName)},
				{"Price", (prev, next) =>prev.Price.CompareTo(next.Price)},
				{"Amount", (prev, next) =>prev.Amount.CompareTo(next.Amount)}
			};
		}
		public void Display()
		{
			try
			{
				data = _specRepository.ShowSpecs(_merchandiseId);
				this.dataGridView_Spec.DataSource = data;
			}
			catch (Exception ex)
			{
				MessageBox.Show("規格資料載入失敗，可能原因：" + ex.Message);
			}
		}

		private void form_ViewMerchandise_Load(object sender, EventArgs e)
		{
			MerchandiseSearchDto dto = _repo.GetCategoryAndBrandByMerchandiseId(_merchandiseId);
			if (dto == null)
			{
				MessageBox.Show("找不到符合紀錄");
				return;
			}

			#region 載入輸入欄資料
			txt_MerchandiseId.Text = dto.MerchandiseId.ToString();
			txt_MerchandiseName.Text = dto.MerchandiseName;
			_merchandiseName = dto.MerchandiseName;
			txt_CategoryName.Text = dto.CategoryName;
			txt_BrandName.Text = dto.BrandName;
			txt_Description.Text = dto.Description;

			_iniImageURL = dto.ImageURL;
			_lasttargetFilePath = @"images/MerchandisePicture/" + dto.ImageURL;
			
			Display();
			#endregion

			#region 載入預覽圖片
			//使用Bitmap轉檔，並兩次使用以達到暫存效果(??)並降低系統負擔
			try
			{
				if (string.IsNullOrEmpty(_iniImageURL))
				{
					//pictureBox_Image.Image = Image.FromFile(defaultImageURL);
					//using (var bmpTemp = new Bitmap(defaultImageURL))
					//{
					//	pictureBox_Image.Image = new Bitmap(bmpTemp);
					//}
					pictureBox_Image.Image = Properties.Resources._default;
				}
				else
				{
					//pictureBox_Image.Image = Image.FromFile(_lasttargetFilePath);
					using (var bmpTemp = new Bitmap(_lasttargetFilePath))
					{
						pictureBox_Image.Image = new Bitmap(bmpTemp);
					}
				}
			}
			catch
			{
				//pictureBox_Image.Image = Image.FromFile(errorImageURL);
				//using (var bmpTemp = new Bitmap(errorImageURL))
				//{
				//	pictureBox_Image.Image = new Bitmap(bmpTemp);
				//}
				pictureBox_Image.Image = Properties.Resources._error;
			}
			#endregion

			#region 限制按鈕使用權限
			if (Authentication.Permission >= 5)
			{
				btn_AddSpec.Enabled = false;
				btn_Edit.Enabled = false;
			}
			#endregion
		}

		#region 增刪查改功能
		private void btn_Edit_Click(object sender, EventArgs e)
		{
			var frm = new form_EditMerchandise(_merchandiseId);
			frm.Owner = this.Owner; //修改商品資料後更新上兩層的商品列表頁
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		private void btn_AddSpec_Click(object sender, EventArgs e)
		{
			var frm = new form_CreateSpec(_merchandiseId, _merchandiseName);
			frm.Owner = this;
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		private void dataGridView_Spec_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int specid = this.data[e.RowIndex].SpecId;

			var frm = new form_EditSpec(specid, _merchandiseName);
			frm.Owner = this;
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		#endregion

		#region 規格檢視排序
		private void dataGridView_Spec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) return;

			OrderByHeader(e.ColumnIndex);
		}

		public void OrderByHeader(int columnIndex)
		{
			//取得點選的資料欄名稱
			string colProp = dataGridView_Spec.Columns[columnIndex].DataPropertyName;

			if (_sortMap.TryGetValue(colProp, out Func<SpecDto, SpecDto, int> func))
			{
				if (_sortIndex == columnIndex)
				{
					data.Sort((x, y) => func(y, x));
					_sortIndex = -1;
				}
				else
				{
					data.Sort((x, y) => func(x, y));
					_sortIndex = columnIndex;
				}
				dataGridView_Spec.DataSource = data.ToArray();
			}
		}
		#endregion
	}
}
