namespace prjMidtermTopic.form_Pets
{
	partial class form_PetCreate
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
			this.radioButtonFemale = new System.Windows.Forms.RadioButton();
			this.radioButtonMale = new System.Windows.Forms.RadioButton();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.btnPetAvatar = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtPetAvatar = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtLocation = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPetName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnCancelPicture = new System.Windows.Forms.Button();
			this.pbPet = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBoxSpeciesID = new System.Windows.Forms.ComboBox();
			this.comboBoxBreedID = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPet)).BeginInit();
			this.SuspendLayout();
			// 
			// radioButtonFemale
			// 
			this.radioButtonFemale.AutoSize = true;
			this.radioButtonFemale.Location = new System.Drawing.Point(80, 7);
			this.radioButtonFemale.Name = "radioButtonFemale";
			this.radioButtonFemale.Size = new System.Drawing.Size(43, 24);
			this.radioButtonFemale.TabIndex = 21;
			this.radioButtonFemale.Text = "母";
			this.radioButtonFemale.UseVisualStyleBackColor = true;
			this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
			// 
			// radioButtonMale
			// 
			this.radioButtonMale.AutoSize = true;
			this.radioButtonMale.Location = new System.Drawing.Point(10, 7);
			this.radioButtonMale.Name = "radioButtonMale";
			this.radioButtonMale.Size = new System.Drawing.Size(43, 24);
			this.radioButtonMale.TabIndex = 20;
			this.radioButtonMale.Text = "公";
			this.radioButtonMale.UseVisualStyleBackColor = true;
			this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDescription.Location = new System.Drawing.Point(433, 28);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(292, 282);
			this.txtDescription.TabIndex = 10;
			// 
			// btnPetAvatar
			// 
			this.btnPetAvatar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnPetAvatar.Location = new System.Drawing.Point(433, 316);
			this.btnPetAvatar.Name = "btnPetAvatar";
			this.btnPetAvatar.Size = new System.Drawing.Size(87, 36);
			this.btnPetAvatar.TabIndex = 8;
			this.btnPetAvatar.Text = "上傳照片";
			this.btnPetAvatar.UseVisualStyleBackColor = true;
			this.btnPetAvatar.Click += new System.EventHandler(this.btnPetAvatar_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCreate.Location = new System.Drawing.Point(38, 294);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(96, 36);
			this.btnCreate.TabIndex = 7;
			this.btnCreate.Text = "新增資料";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtPetAvatar
			// 
			this.txtPetAvatar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPetAvatar.Location = new System.Drawing.Point(126, 258);
			this.txtPetAvatar.Name = "txtPetAvatar";
			this.txtPetAvatar.ReadOnly = true;
			this.txtPetAvatar.Size = new System.Drawing.Size(184, 29);
			this.txtPetAvatar.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(30, 259);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 21);
			this.label6.TabIndex = 5;
			this.label6.Text = "寵物照片：";
			// 
			// txtLocation
			// 
			this.txtLocation.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtLocation.Location = new System.Drawing.Point(126, 220);
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.Size = new System.Drawing.Size(184, 29);
			this.txtLocation.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(42, 223);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 21);
			this.label5.TabIndex = 9;
			this.label5.Text = "所在地：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(337, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 21);
			this.label4.TabIndex = 8;
			this.label4.Text = "寵物簡介：";
			// 
			// txtAge
			// 
			this.txtAge.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAge.Location = new System.Drawing.Point(126, 182);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(184, 29);
			this.txtAge.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(54, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 21);
			this.label3.TabIndex = 7;
			this.label3.Text = "年齡：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(54, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 21);
			this.label2.TabIndex = 6;
			this.label2.Text = "性別：";
			// 
			// txtPetName
			// 
			this.txtPetName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPetName.Location = new System.Drawing.Point(126, 100);
			this.txtPetName.Name = "txtPetName";
			this.txtPetName.Size = new System.Drawing.Size(184, 29);
			this.txtPetName.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(30, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 10;
			this.label1.Text = "寵物名稱：";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButtonFemale);
			this.panel1.Controls.Add(this.radioButtonMale);
			this.panel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.panel1.Location = new System.Drawing.Point(126, 138);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(129, 38);
			this.panel1.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(30, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 21);
			this.label7.TabIndex = 10;
			this.label7.Text = "血統編號：";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(30, 31);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 21);
			this.label8.TabIndex = 10;
			this.label8.Text = "物種編號：";
			// 
			// btnCancelPicture
			// 
			this.btnCancelPicture.Enabled = false;
			this.btnCancelPicture.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCancelPicture.Location = new System.Drawing.Point(526, 316);
			this.btnCancelPicture.Name = "btnCancelPicture";
			this.btnCancelPicture.Size = new System.Drawing.Size(87, 36);
			this.btnCancelPicture.TabIndex = 9;
			this.btnCancelPicture.Text = "取消照片";
			this.btnCancelPicture.UseVisualStyleBackColor = true;
			this.btnCancelPicture.Click += new System.EventHandler(this.btnCancelPicture_Click);
			// 
			// pbPet
			// 
			this.pbPet.Image = global::prjMidtermTopic.Properties.Resources.CryCat;
			this.pbPet.Location = new System.Drawing.Point(772, 28);
			this.pbPet.Name = "pbPet";
			this.pbPet.Size = new System.Drawing.Size(256, 256);
			this.pbPet.TabIndex = 23;
			this.pbPet.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label9.Location = new System.Drawing.Point(841, 298);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(143, 16);
			this.label9.TabIndex = 24;
			this.label9.Text = "(圖片建議大小 256 * 256)";
			// 
			// comboBoxSpeciesID
			// 
			this.comboBoxSpeciesID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxSpeciesID.FormattingEnabled = true;
			this.comboBoxSpeciesID.Location = new System.Drawing.Point(126, 28);
			this.comboBoxSpeciesID.Name = "comboBoxSpeciesID";
			this.comboBoxSpeciesID.Size = new System.Drawing.Size(184, 28);
			this.comboBoxSpeciesID.TabIndex = 25;
			// 
			// comboBoxBreedID
			// 
			this.comboBoxBreedID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxBreedID.FormattingEnabled = true;
			this.comboBoxBreedID.Location = new System.Drawing.Point(126, 64);
			this.comboBoxBreedID.Name = "comboBoxBreedID";
			this.comboBoxBreedID.Size = new System.Drawing.Size(184, 28);
			this.comboBoxBreedID.TabIndex = 25;
			// 
			// form_PetCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1066, 379);
			this.Controls.Add(this.comboBoxBreedID);
			this.Controls.Add(this.comboBoxSpeciesID);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pbPet);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.btnCancelPicture);
			this.Controls.Add(this.btnPetAvatar);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtPetAvatar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtLocation);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtPetName);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(1004, 389);
			this.Name = "form_PetCreate";
			this.Text = "寵物管理：新增寵物資料";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton radioButtonFemale;
		private System.Windows.Forms.RadioButton radioButtonMale;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button btnPetAvatar;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtPetAvatar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtLocation;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPetName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnCancelPicture;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pbPet;
		private System.Windows.Forms.ComboBox comboBoxBreedID;
		private System.Windows.Forms.ComboBox comboBoxSpeciesID;
	}
}