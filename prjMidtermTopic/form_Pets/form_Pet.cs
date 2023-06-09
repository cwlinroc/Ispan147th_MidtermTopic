﻿using ISpan147.Estore.SqlDataLayer.Dtos;
using prjMidtermTopic.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ISpan147.Estore.SqlDataLayer.Repositories;
using prjMidtermTopic.form_Pets;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Model;
using System.Linq;

namespace prjMidtermTopic
{
	public partial class form_Pet : Form, IGrid
	{
		private int _sortIndex;
		private List<PetGridDto> _data;
		private Dictionary<int, string> _mapSpecies = new Dictionary<int, string>();
		private Dictionary<int, string> _mapBreed = new Dictionary<int, string>();
		private readonly Dictionary<string, Func<PetGridDto, PetGridDto, int>> _sortMap;
		private IPetRepo _repo;
		private readonly string[] SortingOptionNames = new string[]
		{
			"寵物編號", "物種名稱","血統名稱", "性別", "年齡","所在地"
		};
		private readonly string[] SortingOptions = new string[]
		{
			"PetID","SpeciesID","BreedID","Gender","Age","Location"
		};

		public form_Pet()
		{
			InitializeComponent();

			_repo = new PetRepository();

			_sortMap = new Dictionary<string, Func<PetGridDto, PetGridDto, int>>
			{
				{"PetID",(prev,next) => prev.PetID.CompareTo(next.PetID) },
				{"SpeciesName",(prev,next) => prev.SpeciesName.CompareTo(next.SpeciesName) },
				{"BreedName",(prev,next) => prev.BreedName.CompareTo(next.BreedName) },
				{"Gender",(prev,next) => prev.Gender.CompareTo(next.Gender) },
				{"Age",(prev,next) => prev.Age.CompareTo(next.Age) },
				{"Location",(prev,next) => prev.Location.CompareTo(next.Location) },
			};

			_mapSpecies.Add(0, "請選擇");
			_mapBreed.Add(0, "請選擇");
			new PetService(_repo).SearchSpescies().ForEach(s => _mapSpecies.Add(s.SpeciesID, s.SpeciesName));
			new PetService(_repo).SearchBreed().ForEach(s => _mapBreed.Add(s.BreedID, s.BreedName));

			foreach (var species in _mapSpecies)
			{
				comboBoxSearchSpecies.Items.Add(species);
			}

			foreach (var breed in _mapBreed)
			{
				comboBoxSearchBreed.Items.Add(breed);
			}

			comboBoxSearchSpecies.DisplayMember = "Value";
			comboBoxSearchBreed.DisplayMember = "Value";

			comboBoxSearchSpecies.SelectedIndex = 0;
			comboBoxSearchBreed.SelectedIndex = 0;

			comboBoxSortBy.Items.AddRange(SortingOptionNames);
			comboBoxSortBy.SelectedIndex = 0;

			Modifier.ModGridView(dataGridView1);
		}

		public void Display()
		{
			try
			{
				var repo = new PetRepository();
				PetSearchDto sDto = new PetSearchDto();

				if (int.TryParse(txtPetID.Text, out int PetID))
				{
					sDto.PetID = PetID;
				}

				if (txtPetName.Text != string.Empty)
				{
					sDto.PetName = txtPetName.Text;
				}

				if (comboBoxSearchSpecies.SelectedIndex != 0)
				{
					sDto.SpeciesID = (comboBoxSearchSpecies.SelectedItem as dynamic).Key;
				}

				if (comboBoxSearchBreed.SelectedIndex != 0)
				{
					sDto.BreedID = (comboBoxSearchBreed.SelectedItem as dynamic).Key;
				}

				if (checkBoxMax.Checked)
				{
					sDto.MaxQueryNumber = int.Parse(txtMax.Text.Trim());
				}
				sDto.Descending = true;
				if (checkBoxDescending.Checked)
				{
					sDto.Descending = false;
				}
				sDto.OrderBy = SortingOptions[comboBoxSortBy.SelectedIndex];

				_data = repo.Search(sDto);
				dataGridView1.DataSource = _data.Select(o => new
				{
					PetID = o.PetID,
					SpeciesID = o.SpeciesID,
					BreedID = o.BreedID,
					PetName = o.PetName,
					Gender = (o.Gender ? "公" : "母"),
					Age = o.Age,
					Description = o.Description,
					Location = o.Location,
					PetAvatar = o.PetAvatar,
					SpeciesName = o.SpeciesName,
					BreedName = o.BreedName,
				}).ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show("讀取資料失敗，原因" + ex.Message);
			}
		}

		private void form_Pet_Load(object sender, EventArgs e)
		{
			Display();
			if (Authentication.Permission > 4)
			{
				btnAdd.Enabled = false;
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;//按到header,不處理

			int id = this._data[e.RowIndex].PetID;

			var frm = new form_PetEdit(id);
			frm.Owner = this;
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var frm = new form_PetCreate();
			frm.Owner = this;
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtPetID.Text = string.Empty;
			txtPetName.Text = string.Empty;
			txtPetID.Focus();
			comboBoxSearchSpecies.SelectedIndex = 0;
			comboBoxSearchBreed.SelectedIndex = 0;
		}

		public void OrderByHeader(int columnIndex)
		{
			string colProp = dataGridView1.Columns[columnIndex].DataPropertyName;

			if (_sortMap.TryGetValue(colProp, out Func<PetGridDto, PetGridDto, int> func))
			{
				if (_sortIndex == columnIndex)
				{
					_data.Sort((x, y) => func(y, x));
					_sortIndex = -1;
				}
				else
				{
					_data.Sort((x, y) => func(x, y));
					_sortIndex = columnIndex;
				}
			}

			dataGridView1.DataSource = _data.Select(o => new
			{
				PetID = o.PetID,
				SpeciesID = o.SpeciesID,
				BreedID = o.BreedID,
				PetName = o.PetName,
				Gender = (o.Gender ? "公" : "母"),
				Age = o.Age,
				Description = o.Description,
				Location = o.Location,
				PetAvatar = o.PetAvatar,
				SpeciesName = o.SpeciesName,
				BreedName = o.BreedName,
			}).ToList();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) return;

			OrderByHeader(e.ColumnIndex);
		}
	}
}
