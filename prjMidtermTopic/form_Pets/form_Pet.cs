using ISpan147.Estore.SqlDataLayer.Dtos;
using prjMidtermTopic.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ISpan147.Estore.SqlDataLayer.Repositories;
using prjMidtermTopic.form_Pets;
using ISpan147.Estore.SqlDataLayer.Services;

namespace prjMidtermTopic
{
    public partial class form_Pet : Form,IGrid
    {
        List<PetDto> data;
        private Dictionary<int,string> mapSpecies = new Dictionary<int, string>();
		private Dictionary<int,string> mapBreed = new Dictionary<int, string>();
		private IPetRepo _repo;
        public form_Pet()
        {
            InitializeComponent();

            _repo = new PetRepository();

			mapSpecies.Add(0,"請選擇");
			mapBreed.Add(0,"請選擇");
            new PetService(_repo).SearchSpescies().ForEach(s => mapSpecies.Add(s.SpeciesID,s.SpeciesName));
			new PetService(_repo).SearchBreed().ForEach(s => mapBreed.Add(s.BreedID, s.BreedName));

			foreach (var species in mapSpecies)
            {
                comboBoxSearchSpecies.Items.Add(species);
            }

			foreach (var breed in mapBreed)
			{
				comboBoxSearchBreed.Items.Add(breed);
			}

			comboBoxSearchSpecies.DisplayMember = "Value";
            comboBoxSearchBreed.DisplayMember = "Value";

			comboBoxSearchSpecies.SelectedIndex = 0;
			comboBoxSearchBreed.SelectedIndex = 0;
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
