using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.form_Spec;
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

namespace prjMidtermTopic.form_Merchandise
{
	public partial class form_ViewMerchandise : Form
	{
		private IMerchandiseRepository _repo;
		private ICategoryRepository _categoryRepository;
		private IBrandRepository _brandRepository;
		//private Dictionary<int, string> categorymap = new Dictionary<int, string>();
		//private Dictionary<int, string> brandmap = new Dictionary<int, string>();
		private readonly int _merchandiseId;
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
		}

		private void form_ViewMerchandise_Load(object sender, EventArgs e)
		{
			//todo 從這裡開始
			MerchandiseDto dto = _repo.GetByMerchandiseId(_merchandiseId);
			if (dto == null)
			{
				MessageBox.Show("找不到符合紀錄");
				return;
			}

			#region 載入輸入欄資料
			txt_MerchandiseId.Text = dto.MerchandiseId.ToString();
			txt_MerchandiseName.Text = dto.MerchandiseName;
			comboBox_CategoryId.SelectedItem = comboBox_CategoryId.Items.Cast<dynamic>()
														.FirstOrDefault(x => x.Key == dto.CategoryId);
			comboBox_BrandId.SelectedItem = comboBox_BrandId.Items.Cast<dynamic>()
														.FirstOrDefault(x => x.Key == dto.BrandId);
			txt_Description.Text = dto.Description;
			txt_ImageURL.Text = dto.ImageURL;

			_iniImageURL = dto.ImageURL;
			_lasttargetFilePath = @"images/MerchandisePicture/" + dto.ImageURL;
			#endregion

			#region 載入預覽圖片
			//使用Bitmap轉檔，並兩次使用以達到暫存效果(??)並降低系統負擔
			try
			{
				if (string.IsNullOrEmpty(txt_ImageURL.Text))
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
			btn_DeleteImage.Enabled = (string.IsNullOrEmpty(txt_ImageURL.Text)) ? false : true;

			//權限限制關閉按鈕
			if (Authentication.Permission >= 5)
			{
				btn_SelectNewImage.Enabled = false;
				btn_DeleteImage.Enabled = false;
				btn_Update.Enabled = false;
				txt_MerchandiseName.ReadOnly = true;
				comboBox_CategoryId.Enabled = false;
				comboBox_BrandId.Enabled = false;
				txt_Description.ReadOnly = true;
				txt_ImageURL.ReadOnly = true;
			}
			if (Authentication.Permission >= 4)
			{
				btn_Delete.Enabled = false;
			}
			#endregion
		}

		private void btn_Edit_Click(object sender, EventArgs e)
		{
			var frm = new form_EditMerchandise(_merchandiseId);
			frm.Owner = this;
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		private void btn_AddSpec_Click(object sender, EventArgs e)
		{
			var frm = new form_CreateSpec();
			frm.Owner = this;
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}
	}
}
