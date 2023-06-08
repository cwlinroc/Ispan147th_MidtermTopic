namespace prjMidtermTopic.form_Pets
{
	partial class form_PetEdit
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPetName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtLocation = new System.Windows.Forms.TextBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.radioButtonMale = new System.Windows.Forms.RadioButton();
			this.radioButtonFemale = new System.Windows.Forms.RadioButton();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.pbPet = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPetAvatar = new System.Windows.Forms.TextBox();
			this.btnUpdatePetAvatar = new System.Windows.Forms.Button();
			this.btnDeletePetAvatar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPetID = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.comboBoxSpeciesID = new System.Windows.Forms.ComboBox();
			this.comboBoxBreedID = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPet)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 141);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "寵物名稱";
			// 
			// txtPetName
			// 
			this.txtPetName.Location = new System.Drawing.Point(109, 134);
			this.txtPetName.Name = "txtPetName";
			this.txtPetName.Size = new System.Drawing.Size(248, 22);
			this.txtPetName.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 175);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "性別";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(48, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "年齡";
			// 
			// txtAge
			// 
			this.txtAge.Location = new System.Drawing.Point(109, 202);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(248, 22);
			this.txtAge.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(375, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "寵物簡介";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(48, 243);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 12);
			this.label5.TabIndex = 0;
			this.label5.Text = "所在地";
			// 
			// txtLocation
			// 
			this.txtLocation.Location = new System.Drawing.Point(109, 236);
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.Size = new System.Drawing.Size(248, 22);
			this.txtLocation.TabIndex = 6;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(50, 308);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "修改資料";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(134, 308);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "刪除資料";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(434, 39);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(277, 256);
			this.txtDescription.TabIndex = 8;
			// 
			// radioButtonMale
			// 
			this.radioButtonMale.AutoSize = true;
			this.radioButtonMale.Location = new System.Drawing.Point(3, 6);
			this.radioButtonMale.Name = "radioButtonMale";
			this.radioButtonMale.Size = new System.Drawing.Size(35, 16);
			this.radioButtonMale.TabIndex = 4;
			this.radioButtonMale.Text = "公";
			this.radioButtonMale.UseVisualStyleBackColor = true;
			this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
			// 
			// radioButtonFemale
			// 
			this.radioButtonFemale.AutoSize = true;
			this.radioButtonFemale.Location = new System.Drawing.Point(78, 6);
			this.radioButtonFemale.Name = "radioButtonFemale";
			this.radioButtonFemale.Size = new System.Drawing.Size(35, 16);
			this.radioButtonFemale.TabIndex = 4;
			this.radioButtonFemale.Text = "母";
			this.radioButtonFemale.UseVisualStyleBackColor = true;
			this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// pbPet
			// 
			this.errorProvider1.SetIconAlignment(this.pbPet, System.Windows.Forms.ErrorIconAlignment.TopRight);
			this.pbPet.Image = global::prjMidtermTopic.Properties.Resources.CryCat;
			this.pbPet.Location = new System.Drawing.Point(755, 39);
			this.pbPet.MaximumSize = new System.Drawing.Size(256, 256);
			this.pbPet.Name = "pbPet";
			this.pbPet.Size = new System.Drawing.Size(256, 256);
			this.pbPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbPet.TabIndex = 15;
			this.pbPet.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(48, 277);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 12);
			this.label6.TabIndex = 0;
			this.label6.Text = "寵物照片";
			// 
			// txtPetAvatar
			// 
			this.txtPetAvatar.Location = new System.Drawing.Point(109, 270);
			this.txtPetAvatar.Name = "txtPetAvatar";
			this.txtPetAvatar.ReadOnly = true;
			this.txtPetAvatar.Size = new System.Drawing.Size(248, 22);
			this.txtPetAvatar.TabIndex = 7;
			// 
			// btnUpdatePetAvatar
			// 
			this.btnUpdatePetAvatar.Location = new System.Drawing.Point(434, 308);
			this.btnUpdatePetAvatar.Name = "btnUpdatePetAvatar";
			this.btnUpdatePetAvatar.Size = new System.Drawing.Size(88, 23);
			this.btnUpdatePetAvatar.TabIndex = 11;
			this.btnUpdatePetAvatar.Text = "修改照片";
			this.btnUpdatePetAvatar.UseVisualStyleBackColor = true;
			this.btnUpdatePetAvatar.Click += new System.EventHandler(this.btnUpdatePetAvatar_Click);
			// 
			// btnDeletePetAvatar
			// 
			this.btnDeletePetAvatar.Location = new System.Drawing.Point(619, 308);
			this.btnDeletePetAvatar.Name = "btnDeletePetAvatar";
			this.btnDeletePetAvatar.Size = new System.Drawing.Size(92, 23);
			this.btnDeletePetAvatar.TabIndex = 12;
			this.btnDeletePetAvatar.Text = "刪除照片";
			this.btnDeletePetAvatar.UseVisualStyleBackColor = true;
			this.btnDeletePetAvatar.Click += new System.EventHandler(this.btnDeletePetAvatar_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButtonMale);
			this.panel1.Controls.Add(this.radioButtonFemale);
			this.panel1.Location = new System.Drawing.Point(109, 168);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(248, 22);
			this.panel1.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(48, 73);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 12);
			this.label8.TabIndex = 13;
			this.label8.Text = "物種編號";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(48, 107);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 12);
			this.label7.TabIndex = 14;
			this.label7.Text = "血統編號";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(48, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 12);
			this.label9.TabIndex = 13;
			this.label9.Text = "寵物編號";
			// 
			// txtPetID
			// 
			this.txtPetID.Location = new System.Drawing.Point(109, 36);
			this.txtPetID.Name = "txtPetID";
			this.txtPetID.ReadOnly = true;
			this.txtPetID.Size = new System.Drawing.Size(248, 22);
			this.txtPetID.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(820, 319);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(128, 12);
			this.label10.TabIndex = 16;
			this.label10.Text = "圖片建議大小 256 * 256";
			// 
			// comboBoxSpeciesID
			// 
			this.comboBoxSpeciesID.FormattingEnabled = true;
			this.comboBoxSpeciesID.Location = new System.Drawing.Point(109, 70);
			this.comboBoxSpeciesID.Name = "comboBoxSpeciesID";
			this.comboBoxSpeciesID.Size = new System.Drawing.Size(248, 20);
			this.comboBoxSpeciesID.TabIndex = 17;
			// 
			// comboBoxBreedID
			// 
			this.comboBoxBreedID.FormattingEnabled = true;
			this.comboBoxBreedID.Location = new System.Drawing.Point(109, 104);
			this.comboBoxBreedID.Name = "comboBoxBreedID";
			this.comboBoxBreedID.Size = new System.Drawing.Size(248, 20);
			this.comboBoxBreedID.TabIndex = 17;
			// 
			// form_PetEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1060, 376);
			this.Controls.Add(this.comboBoxBreedID);
			this.Controls.Add(this.comboBoxSpeciesID);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.pbPet);
			this.Controls.Add(this.txtPetID);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnDeletePetAvatar);
			this.Controls.Add(this.btnUpdatePetAvatar);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtPetAvatar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtLocation);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPetName);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(1076, 415);
			this.Name = "form_PetEdit";
			this.Text = "form_PetEdit";
			this.Load += new System.EventHandler(this.form_PetEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPet)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPetName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtLocation;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.RadioButton radioButtonMale;
		private System.Windows.Forms.RadioButton radioButtonFemale;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btnDeletePetAvatar;
		private System.Windows.Forms.Button btnUpdatePetAvatar;
		private System.Windows.Forms.TextBox txtPetAvatar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPetID;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pbPet;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox comboBoxBreedID;
		private System.Windows.Forms.ComboBox comboBoxSpeciesID;
	}
}