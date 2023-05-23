﻿using MemberClassLibrary.Dtos;
using MemberClassLibrary.Services;
using MemberClassLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjMidtermTopic.Model;
using prjMidtermTopic.FormMember;

namespace prjMidtermTopic
{
    public partial class form_Member : Form, IGrid
    {
		List<MemberDto> data;

		public form_Member()
        {
            InitializeComponent();
        }

		private void form_Member_Load(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtId.Text, out int memberId);
			int? mId = isInt ? memberId : (int?)null;			
			string mName = txtName.Text;

			var repo = new MemberRepository();
			data = repo.LoadData(mId, mName);
			dataGridView1.DataSource = data;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			//Display();
		}

		public void Display()
		{
			//bool isInt = int.TryParse(txtId.Text, out int memberId);
			//int? mId = isInt ? memberId : (int?)null;
			//string mName = txtName.Text;

			//var repo = new MemberRepository();
			//data = repo.Search(mId, mName);
			//dataGridView1.DataSource = data;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return; // 按到了header,不處理

			int id = this.data[e.RowIndex].Id;

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
	}
}
