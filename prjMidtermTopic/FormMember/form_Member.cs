﻿using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.FormMember;
using Ispan147.Estore.SqlDataLayer.Services;
using System.Linq;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;
using ISpan147.Estore.SqlDataLayer.EFModel;
using System.Security.Principal;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using ISpan147.Estore.SqlDataLayer.Services;

namespace prjMidtermTopic
{
	public partial class form_Member : Form, IGrid
	{
		private IMemberRepo _repo;
		List<MemberDto> _data;
		private int _row = -1;
		private int _sortedIndex = 0;
		private readonly Dictionary<string, Func<MemberDto, MemberDto, int>> _sortMap;

		public form_Member()
		{
			InitializeComponent();

			_sortMap = new Dictionary<string, Func<MemberDto, MemberDto, int>>
			{
				{ "MemberID", (prev, next) => prev.MemberID.CompareTo(next.MemberID) },
				{ "MemberName", (prev, next) => prev.MemberName.CompareTo(next.MemberName) },
				{ "ForumAccountID", (prev, next) => prev.ForumAccountID.GetValueOrDefault().CompareTo(next.ForumAccountID.GetValueOrDefault()) },
				{ "DateOfBirth", (prev, next) => prev.DateOfBirth.CompareTo(next.DateOfBirth) },
				{ "Account", (prev, next) => prev.Account.CompareTo(next.Account) },
				{ "Phone", (prev, next) => prev.Phone.CompareTo(next.Phone) },
				//{ "Address", (prev, next) => {
				//	string prevStr = (prev.Address == null)? string.Empty: prev.Address;
				//	string nextStr = (next.Address == null)? string.Empty: next.Address;
				//	return prevStr.CompareTo(nextStr); } }
				{ "Address", (prev, next) => (prev.Address??"").CompareTo(next.Address??"")}
			};

			Modifier.ModGridView(dataGridView1);
		}

		private void form_Member_Load(object sender, EventArgs e)
		{
			if (Authentication.Permission >= 5)
			{
				btnAdd.Enabled = false;
			}

			Display();
			if (Authentication.Permission > 4) btnAdd.Enabled = false;
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
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var frm = new form_CreateMember();
			frm.Owner = this;
			Modifier.ModForm(frm);
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
				dataGridView1.DataSource = _data.Select(o => new
				{
					MemberID = o.MemberID,
					MemberName = o.MemberName,
					NickName = o.NickName,
					DateOfBirth = o.DateOfBirth,
					Gender = (o.Gender) ? "男" : "女",
					Account = o.Account,
					Phone = o.Phone,
					Address = o.Address,
					Email = o.Email,
					Avatar = o.Avatar
				}).ToList();
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

		//select change
		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			_row = dataGridView1.CurrentCell.RowIndex;
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 || e.ColumnIndex < 0) return;

			//取得雙擊標題(column header)所對應的資料屬性名稱(Property Name)
			string colProp = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;

			//將對應的名稱字串輸入Dictionary _sortMap,並得到對應比較方式的委派
			if (_sortMap.TryGetValue(colProp, out Func<MemberDto, MemberDto, int> func))
			{
				//如果雙擊的標題是剛好是之前升冪排序的資料行(column)，則反轉為降冪排序
				if (_sortedIndex == e.ColumnIndex)
				{
					//因為_data是List，所以直接呼叫List.Sort方法，並依照其中的委派比較方式做排序
					_data.Sort((x, y) => func(y, x));
					//將紀錄清空，因為下次不管點到哪個都肯定是升冪
					_sortedIndex = -1;
				}
				//其餘的就一律升冪排序
				else
				{
					_data.Sort((x, y) => func(x, y));
					//紀錄這次升冪排列的資料行
					_sortedIndex = e.ColumnIndex;
				}
				//將整理好的_data丟到dataGridView裡面
				dataGridView1.DataSource = _data.Select(o => new
				{
					MemberID = o.MemberID,
					MemberName = o.MemberName,
					NickName = o.NickName,
					DateOfBirth = o.DateOfBirth,
					Gender = (o.Gender) ? "男" : "女",
					Account = o.Account,
					Phone = o.Phone,
					Address = o.Address,
					Email = o.Email,
					Avatar = o.Avatar
				}).ToList();
			}
		}
	}
}
