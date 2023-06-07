namespace prjMidtermTopic
{
    partial class form_Pet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.txtPetID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPetName = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.PetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SpeciesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BreedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PetAvatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.comboBoxSearchSpecies = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxSearchBreed = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "寵物編號";
			// 
			// txtPetID
			// 
			this.txtPetID.Location = new System.Drawing.Point(126, 25);
			this.txtPetID.Name = "txtPetID";
			this.txtPetID.Size = new System.Drawing.Size(100, 22);
			this.txtPetID.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(67, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "寵物名稱";
			// 
			// txtPetName
			// 
			this.txtPetName.Location = new System.Drawing.Point(126, 59);
			this.txtPetName.Name = "txtPetName";
			this.txtPetName.Size = new System.Drawing.Size(100, 22);
			this.txtPetName.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(848, 44);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "新增資料";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PetID,
            this.SpeciesID,
            this.BreedID,
            this.PetName,
            this.Gender,
            this.Age,
            this.Description,
            this.Location,
            this.PetAvatar});
			this.dataGridView1.Location = new System.Drawing.Point(61, 102);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1062, 568);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// PetID
			// 
			this.PetID.DataPropertyName = "PetID";
			this.PetID.HeaderText = "寵物編號";
			this.PetID.Name = "PetID";
			// 
			// SpeciesID
			// 
			this.SpeciesID.DataPropertyName = "SpeciesID";
			this.SpeciesID.HeaderText = "物種編號";
			this.SpeciesID.Name = "SpeciesID";
			// 
			// BreedID
			// 
			this.BreedID.DataPropertyName = "BreedID";
			this.BreedID.HeaderText = "血統編號";
			this.BreedID.Name = "BreedID";
			// 
			// PetName
			// 
			this.PetName.DataPropertyName = "PetName";
			this.PetName.HeaderText = "寵物名稱";
			this.PetName.Name = "PetName";
			// 
			// Gender
			// 
			this.Gender.DataPropertyName = "Gender";
			this.Gender.HeaderText = "性別";
			this.Gender.Name = "Gender";
			// 
			// Age
			// 
			this.Age.DataPropertyName = "Age";
			this.Age.HeaderText = "年齡";
			this.Age.Name = "Age";
			// 
			// Description
			// 
			this.Description.DataPropertyName = "Description";
			this.Description.HeaderText = "寵物敘述";
			this.Description.Name = "Description";
			// 
			// Location
			// 
			this.Location.DataPropertyName = "Location";
			this.Location.HeaderText = "所在地";
			this.Location.Name = "Location";
			// 
			// PetAvatar
			// 
			this.PetAvatar.DataPropertyName = "PetAvatar";
			this.PetAvatar.HeaderText = "寵物照片";
			this.PetAvatar.Name = "PetAvatar";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(700, 44);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "重置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(1010, 45);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "搜尋";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// comboBoxSearchSpecies
			// 
			this.comboBoxSearchSpecies.FormattingEnabled = true;
			this.comboBoxSearchSpecies.Location = new System.Drawing.Point(303, 27);
			this.comboBoxSearchSpecies.Name = "comboBoxSearchSpecies";
			this.comboBoxSearchSpecies.Size = new System.Drawing.Size(121, 20);
			this.comboBoxSearchSpecies.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(232, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "按物種分類";
			// 
			// comboBoxSearchBreed
			// 
			this.comboBoxSearchBreed.FormattingEnabled = true;
			this.comboBoxSearchBreed.Location = new System.Drawing.Point(303, 62);
			this.comboBoxSearchBreed.Name = "comboBoxSearchBreed";
			this.comboBoxSearchBreed.Size = new System.Drawing.Size(121, 20);
			this.comboBoxSearchBreed.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(232, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "按血統分類";
			// 
			// form_Pet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1160, 721);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxSearchBreed);
			this.Controls.Add(this.comboBoxSearchSpecies);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtPetName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPetID);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(1176, 760);
			this.Name = "form_Pet";
			this.Text = "PetMain";
			this.Load += new System.EventHandler(this.form_Pet_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPetID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPetName;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn PetID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SpeciesID;
		private System.Windows.Forms.DataGridViewTextBoxColumn BreedID;
		private System.Windows.Forms.DataGridViewTextBoxColumn PetName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn Age;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn Location;
		private System.Windows.Forms.DataGridViewTextBoxColumn PetAvatar;
		private System.Windows.Forms.ComboBox comboBoxSearchSpecies;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxSearchBreed;
		private System.Windows.Forms.Label label4;
	}
}