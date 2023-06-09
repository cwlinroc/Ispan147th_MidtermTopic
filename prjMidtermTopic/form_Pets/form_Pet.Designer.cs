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
			this.SpeciesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BreedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BreedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.txtMax = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBoxMax = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
			this.checkBoxDescending = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(67, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "寵物編號：";
			// 
			// txtPetID
			// 
			this.txtPetID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPetID.Location = new System.Drawing.Point(163, 24);
			this.txtPetID.Name = "txtPetID";
			this.txtPetID.Size = new System.Drawing.Size(100, 29);
			this.txtPetID.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(67, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "寵物名稱：";
			// 
			// txtPetName
			// 
			this.txtPetName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPetName.Location = new System.Drawing.Point(163, 59);
			this.txtPetName.Name = "txtPetName";
			this.txtPetName.Size = new System.Drawing.Size(100, 29);
			this.txtPetName.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnAdd.Location = new System.Drawing.Point(1149, 61);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(91, 29);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "新增資料";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PetID,
            this.SpeciesID,
            this.SpeciesName,
            this.BreedID,
            this.BreedName,
            this.PetName,
            this.Gender,
            this.Age,
            this.Description,
            this.Location,
            this.PetAvatar});
			this.dataGridView1.Location = new System.Drawing.Point(61, 102);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1179, 568);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// PetID
			// 
			this.PetID.DataPropertyName = "PetID";
			this.PetID.HeaderText = "寵物編號";
			this.PetID.MinimumWidth = 6;
			this.PetID.Name = "PetID";
			this.PetID.Width = 125;
			// 
			// SpeciesID
			// 
			this.SpeciesID.DataPropertyName = "SpeciesID";
			this.SpeciesID.HeaderText = "物種編號";
			this.SpeciesID.MinimumWidth = 6;
			this.SpeciesID.Name = "SpeciesID";
			this.SpeciesID.Visible = false;
			this.SpeciesID.Width = 125;
			// 
			// SpeciesName
			// 
			this.SpeciesName.DataPropertyName = "SpeciesName";
			this.SpeciesName.HeaderText = "物種名稱";
			this.SpeciesName.MinimumWidth = 6;
			this.SpeciesName.Name = "SpeciesName";
			this.SpeciesName.Width = 125;
			// 
			// BreedID
			// 
			this.BreedID.DataPropertyName = "BreedID";
			this.BreedID.HeaderText = "血統編號";
			this.BreedID.MinimumWidth = 6;
			this.BreedID.Name = "BreedID";
			this.BreedID.Visible = false;
			this.BreedID.Width = 125;
			// 
			// BreedName
			// 
			this.BreedName.DataPropertyName = "BreedName";
			this.BreedName.HeaderText = "血統名稱";
			this.BreedName.MinimumWidth = 6;
			this.BreedName.Name = "BreedName";
			this.BreedName.Width = 125;
			// 
			// PetName
			// 
			this.PetName.DataPropertyName = "PetName";
			this.PetName.HeaderText = "寵物名稱";
			this.PetName.MinimumWidth = 6;
			this.PetName.Name = "PetName";
			this.PetName.Width = 125;
			// 
			// Gender
			// 
			this.Gender.DataPropertyName = "Gender";
			this.Gender.HeaderText = "性別";
			this.Gender.MinimumWidth = 6;
			this.Gender.Name = "Gender";
			this.Gender.Width = 125;
			// 
			// Age
			// 
			this.Age.DataPropertyName = "Age";
			this.Age.HeaderText = "年齡";
			this.Age.MinimumWidth = 6;
			this.Age.Name = "Age";
			this.Age.Width = 125;
			// 
			// Description
			// 
			this.Description.DataPropertyName = "Description";
			this.Description.HeaderText = "寵物敘述";
			this.Description.MinimumWidth = 6;
			this.Description.Name = "Description";
			this.Description.Width = 125;
			// 
			// Location
			// 
			this.Location.DataPropertyName = "Location";
			this.Location.HeaderText = "所在地";
			this.Location.MinimumWidth = 6;
			this.Location.Name = "Location";
			this.Location.Width = 125;
			// 
			// PetAvatar
			// 
			this.PetAvatar.DataPropertyName = "PetAvatar";
			this.PetAvatar.HeaderText = "寵物照片";
			this.PetAvatar.MinimumWidth = 6;
			this.PetAvatar.Name = "PetAvatar";
			this.PetAvatar.Width = 125;
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnReset.Location = new System.Drawing.Point(928, 59);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(91, 29);
			this.btnReset.TabIndex = 9;
			this.btnReset.Text = "輸入重置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSearch.Location = new System.Drawing.Point(928, 25);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 29);
			this.btnSearch.TabIndex = 8;
			this.btnSearch.Text = "搜尋";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// comboBoxSearchSpecies
			// 
			this.comboBoxSearchSpecies.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxSearchSpecies.FormattingEnabled = true;
			this.comboBoxSearchSpecies.Location = new System.Drawing.Point(405, 24);
			this.comboBoxSearchSpecies.Name = "comboBoxSearchSpecies";
			this.comboBoxSearchSpecies.Size = new System.Drawing.Size(121, 28);
			this.comboBoxSearchSpecies.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(293, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "按物種分類：";
			// 
			// comboBoxSearchBreed
			// 
			this.comboBoxSearchBreed.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxSearchBreed.FormattingEnabled = true;
			this.comboBoxSearchBreed.Location = new System.Drawing.Point(405, 57);
			this.comboBoxSearchBreed.Name = "comboBoxSearchBreed";
			this.comboBoxSearchBreed.Size = new System.Drawing.Size(121, 28);
			this.comboBoxSearchBreed.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(293, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 21);
			this.label4.TabIndex = 6;
			this.label4.Text = "按血統分類：";
			// 
			// txtMax
			// 
			this.txtMax.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtMax.Location = new System.Drawing.Point(699, 25);
			this.txtMax.Name = "txtMax";
			this.txtMax.Size = new System.Drawing.Size(100, 29);
			this.txtMax.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(805, 28);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 21);
			this.label6.TabIndex = 0;
			this.label6.Text = "筆資料";
			// 
			// checkBoxMax
			// 
			this.checkBoxMax.AutoSize = true;
			this.checkBoxMax.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.checkBoxMax.Location = new System.Drawing.Point(610, 27);
			this.checkBoxMax.Name = "checkBoxMax";
			this.checkBoxMax.Size = new System.Drawing.Size(93, 25);
			this.checkBoxMax.TabIndex = 4;
			this.checkBoxMax.Text = "最多顯示";
			this.checkBoxMax.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(603, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 21);
			this.label5.TabIndex = 8;
			this.label5.Text = "排序依據：";
			// 
			// comboBoxSortBy
			// 
			this.comboBoxSortBy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxSortBy.FormattingEnabled = true;
			this.comboBoxSortBy.Location = new System.Drawing.Point(699, 58);
			this.comboBoxSortBy.Name = "comboBoxSortBy";
			this.comboBoxSortBy.Size = new System.Drawing.Size(121, 28);
			this.comboBoxSortBy.TabIndex = 6;
			// 
			// checkBoxDescending
			// 
			this.checkBoxDescending.AutoSize = true;
			this.checkBoxDescending.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.checkBoxDescending.Location = new System.Drawing.Point(826, 62);
			this.checkBoxDescending.Name = "checkBoxDescending";
			this.checkBoxDescending.Size = new System.Drawing.Size(50, 20);
			this.checkBoxDescending.TabIndex = 7;
			this.checkBoxDescending.Text = "降冪";
			this.checkBoxDescending.UseVisualStyleBackColor = true;
			// 
			// form_Pet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1267, 721);
			this.Controls.Add(this.checkBoxDescending);
			this.Controls.Add(this.comboBoxSortBy);
			this.Controls.Add(this.comboBoxSearchBreed);
			this.Controls.Add(this.comboBoxSearchSpecies);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtPetName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMax);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtPetID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBoxMax);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Name = "form_Pet";
			this.Text = "寵物管理：檢視、搜尋";
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
		private System.Windows.Forms.ComboBox comboBoxSearchSpecies;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxSearchBreed;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn PetID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SpeciesID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SpeciesName;
		private System.Windows.Forms.DataGridViewTextBoxColumn BreedID;
		private System.Windows.Forms.DataGridViewTextBoxColumn BreedName;
		private System.Windows.Forms.DataGridViewTextBoxColumn PetName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn Age;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn Location;
		private System.Windows.Forms.DataGridViewTextBoxColumn PetAvatar;
		private System.Windows.Forms.TextBox txtMax;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox checkBoxMax;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxSortBy;
		private System.Windows.Forms.CheckBox checkBoxDescending;
	}
}