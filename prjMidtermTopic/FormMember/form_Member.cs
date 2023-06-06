using ISpan147.Estore.SqlDataLayer.Dtos;
using Ispan147.Estore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.FormMember;
using Ispan147.Estore.SqlDataLayer.Services;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System.Linq;

namespace prjMidtermTopic
{
	public partial class form_Member : Form, IGrid
	{
		private IMemberRepo _repo;
		List<MemberDto> _data;

		public form_Member()
		{
			InitializeComponent();
		}

		private void form_Member_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
			txtMemberID.Text = string.Empty;
			txtMemberName.Text = string.Empty;
			txtMemberID.Focus();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtMemberID.Text = string.Empty;
			txtMemberName.Text = string.Empty;
			checkBoxMaxQuery.Checked = false;
			txtMaxQuery.Text = string.Empty;
			txtMemberID.Focus();
			Display();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return; // 按到了header,不處理

			int id = this._data[e.RowIndex].MemberID;

			var frm = new form_EditMember(id);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var frm = new form_CreateMember();
			frm.Owner = this;
			frm.ShowDialog();
		}

		public void Display()
		{
			try
			{
				var sDto = GetSearchDto();
				var DtoList = new MemberService(_repo);

				//使用ToList()從IEnumerable< >轉型為List< >
				_data = DtoList.Search(sDto).ToList();

				//匯入DataGridView
				dataGridView1.DataSource = _data;
			}
			catch (Exception ex)
			{
				MessageBox.Show("資料查詢失敗,原因:" + ex.Message);
			}

		}

		private MemberSearchDto GetSearchDto()
		{
			var sDto = new MemberSearchDto();

			#region 條件判斷
			if (int.TryParse(txtMemberID.Text.Trim(), out int memberID))
			{
				sDto.MemberID = memberID;
			}
			if (txtMemberName.Text.Trim().Length > 0)
			{
				sDto.MemberName = txtMemberName.Text.Trim();
			}
			if (checkBoxMaxQuery.Checked)
			{
				sDto.MaxQueryNumber = int.Parse(txtMaxQuery.Text.Trim());
			}
			#endregion

			return sDto;
		}

	}
}
