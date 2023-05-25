using ISpan147.Estore.SqlDataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.MassInsert
{
	public partial class form_MassInsert : Form
	{
		public form_MassInsert()
		{
			InitializeComponent();
		}

		private void btn_AddMember_Click(object sender, EventArgs e)
		{
			AddMassData(total => new MassInsertService().CreateRandomMembers(total),textBox_Member);
		}

		private void btn_AddPet_Click(object sender, EventArgs e)
		{
			AddMassData(total => new MassInsertService().CreateRandomPets(total),textBox_Pet);
		}

		private void btn_AddMerchanDise_Click(object sender, EventArgs e)
		{
			AddMassData(total => new MassInsertService().CreateRandomMerchandise(total), textBox_Merchandise);
		}

		private void btn_AddThemeCommon_Click(object sender, EventArgs e)
		{
			AddMassData(total => new MassInsertService().CreateRandomThemeAndCommon(total), textBox_ThemeAndCommon);
		}

		private void btn_AddOrderOrderList_Click(object sender, EventArgs e)
		{
			AddMassData(total => new MassInsertService().CreateRandomOrderAndOrderList(total), textBox_OrderAndOrderList);
		}

		private void btn_AddAdopt_Click(object sender, EventArgs e)
		{
			AddMassData(total => new MassInsertService().CreateRandomAdopt(total), textBox_Adopt);
		}


		private void AddMassData(Action <int> func,TextBox box)
		{
			try
			{
				if (!int.TryParse(box.Text, out var total))
				{
					throw new ArgumentOutOfRangeException("請入正整數");
				}

				DialogResult dialogResult = MessageBox.Show($"確任新增{total}筆會員資料？", "確認增加", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.No) return;

				func(total);

				MessageBox.Show("輸入成功!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("輸入失敗，原因：" + ex.Message);
			}
		}
	}
}
