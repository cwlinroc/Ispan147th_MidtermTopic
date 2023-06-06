using ISpan147.Estore.SqlDataLayer.Dtos;
using prjMidtermTopic.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ISpan147.Estore.SqlDataLayer.Repositories;
using prjMidtermTopic.form_Pets;

namespace prjMidtermTopic
{
    public partial class form_Pet : Form,IGrid
    {
        List<PetDto> data;
        public form_Pet()
        {
            InitializeComponent();
        }

        public void Display()
        {
            bool isInt = int.TryParse(txtPetID.Text,out int PetID);
            int? pID = isInt ? PetID : (int?)null;
            string pName = txtPetName.Text;

            var repo = new PetRepository();
            data = repo.Search(pID, pName);
            dataGridView1.DataSource = data;
        }

		private void form_Pet_Load(object sender, EventArgs e)
		{
            Display();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
            Display();
            txtPetID.Text = string.Empty;
            txtPetName.Text = string.Empty;
            txtPetID.Focus();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            if (e.RowIndex < 0) return;//按到header,不處理

            int id = this.data[e.RowIndex].PetID;

            var frm = new form_PetEdit(id);
            frm.Owner = this;
            frm.ShowDialog();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
            var frm = new form_PetCreate();
            frm.Owner = this;
            frm.ShowDialog();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
            Display();
		}
	}
}
