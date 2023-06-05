namespace prjMidtermTopic.FormMember
{
	partial class form_EditMember
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtAvatar = new System.Windows.Forms.TextBox();
			this.radbtnFemale = new System.Windows.Forms.RadioButton();
			this.radbtnMale = new System.Windows.Forms.RadioButton();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMemberName = new System.Windows.Forms.TextBox();
			this.labName = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtNickName = new System.Windows.Forms.TextBox();
			this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnUploadAvatar = new System.Windows.Forms.Button();
			this.btnDeleteAvatar = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtForumAccountID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnApplyForumMember = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.btnEditForumName = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDelete.AutoSize = true;
			this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDelete.Location = new System.Drawing.Point(7, 591);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(71, 30);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "刪除";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnUpdate.AutoSize = true;
			this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUpdate.Location = new System.Drawing.Point(7, 555);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(71, 30);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "修改";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txtAvatar
			// 
			this.txtAvatar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAvatar.Location = new System.Drawing.Point(114, 460);
			this.txtAvatar.Name = "txtAvatar";
			this.txtAvatar.Size = new System.Drawing.Size(164, 29);
			this.txtAvatar.TabIndex = 8;
			// 
			// radbtnFemale
			// 
			this.radbtnFemale.AutoSize = true;
			this.radbtnFemale.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radbtnFemale.Location = new System.Drawing.Point(81, 9);
			this.radbtnFemale.Name = "radbtnFemale";
			this.radbtnFemale.Size = new System.Drawing.Size(66, 28);
			this.radbtnFemale.TabIndex = 1;
			this.radbtnFemale.Text = "女性";
			this.radbtnFemale.UseVisualStyleBackColor = true;
			this.radbtnFemale.CheckedChanged += new System.EventHandler(this.radbtnFemale_CheckedChanged);
			// 
			// radbtnMale
			// 
			this.radbtnMale.AutoSize = true;
			this.radbtnMale.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.radbtnMale.Location = new System.Drawing.Point(3, 9);
			this.radbtnMale.Name = "radbtnMale";
			this.radbtnMale.Size = new System.Drawing.Size(66, 28);
			this.radbtnMale.TabIndex = 0;
			this.radbtnMale.Text = "男性";
			this.radbtnMale.UseVisualStyleBackColor = true;
			this.radbtnMale.CheckedChanged += new System.EventHandler(this.radbtnMale_CheckedChanged);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtEmail.Location = new System.Drawing.Point(114, 407);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(164, 29);
			this.txtEmail.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(63, 458);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 20);
			this.label8.TabIndex = 32;
			this.label8.Text = "頭像:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(54, 403);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 20);
			this.label5.TabIndex = 33;
			this.label5.Text = "Email:";
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAddress.Location = new System.Drawing.Point(114, 354);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(164, 29);
			this.txtAddress.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(63, 348);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 20);
			this.label7.TabIndex = 35;
			this.label7.Text = "地址:";
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPhone.Location = new System.Drawing.Point(114, 301);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(164, 29);
			this.txtPhone.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(31, 293);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 20);
			this.label4.TabIndex = 34;
			this.label4.Text = "手機號碼:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(63, 183);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 20);
			this.label6.TabIndex = 37;
			this.label6.Text = "性別:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(15, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 20);
			this.label2.TabIndex = 36;
			this.label2.Text = "出生年月日:";
			// 
			// txtAccount
			// 
			this.txtAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAccount.Location = new System.Drawing.Point(114, 248);
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new System.Drawing.Size(164, 29);
			this.txtAccount.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(63, 238);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 20);
			this.label3.TabIndex = 39;
			this.label3.Text = "帳戶:";
			// 
			// txtMemberName
			// 
			this.txtMemberName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtMemberName.Location = new System.Drawing.Point(114, 15);
			this.txtMemberName.Name = "txtMemberName";
			this.txtMemberName.Size = new System.Drawing.Size(164, 29);
			this.txtMemberName.TabIndex = 0;
			// 
			// labName
			// 
			this.labName.AutoSize = true;
			this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labName.Location = new System.Drawing.Point(63, 18);
			this.labName.Name = "labName";
			this.labName.Size = new System.Drawing.Size(45, 20);
			this.labName.TabIndex = 40;
			this.labName.Text = "姓名:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label10.Location = new System.Drawing.Point(63, 73);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(45, 20);
			this.label10.TabIndex = 40;
			this.label10.Text = "暱稱:";
			// 
			// txtNickName
			// 
			this.txtNickName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtNickName.Location = new System.Drawing.Point(114, 68);
			this.txtNickName.Name = "txtNickName";
			this.txtNickName.Size = new System.Drawing.Size(164, 29);
			this.txtNickName.TabIndex = 2;
			// 
			// DateOfBirthPicker
			// 
			this.DateOfBirthPicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.DateOfBirthPicker.Location = new System.Drawing.Point(114, 121);
			this.DateOfBirthPicker.Name = "DateOfBirthPicker";
			this.DateOfBirthPicker.Size = new System.Drawing.Size(164, 29);
			this.DateOfBirthPicker.TabIndex = 3;
			this.DateOfBirthPicker.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
			this.DateOfBirthPicker.ValueChanged += new System.EventHandler(this.DateOfBirthPicker_ValueChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radbtnMale);
			this.panel1.Controls.Add(this.radbtnFemale);
			this.panel1.Location = new System.Drawing.Point(114, 174);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(176, 50);
			this.panel1.TabIndex = 41;
			// 
			// btnUploadAvatar
			// 
			this.btnUploadAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnUploadAvatar.AutoSize = true;
			this.btnUploadAvatar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUploadAvatar.Location = new System.Drawing.Point(291, 555);
			this.btnUploadAvatar.Name = "btnUploadAvatar";
			this.btnUploadAvatar.Size = new System.Drawing.Size(127, 30);
			this.btnUploadAvatar.TabIndex = 9;
			this.btnUploadAvatar.Text = "上傳頭像";
			this.btnUploadAvatar.UseVisualStyleBackColor = true;
			this.btnUploadAvatar.Click += new System.EventHandler(this.btnSelectAvatar_Click);
			// 
			// btnDeleteAvatar
			// 
			this.btnDeleteAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDeleteAvatar.AutoSize = true;
			this.btnDeleteAvatar.Enabled = false;
			this.btnDeleteAvatar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDeleteAvatar.Location = new System.Drawing.Point(291, 591);
			this.btnDeleteAvatar.Name = "btnDeleteAvatar";
			this.btnDeleteAvatar.Size = new System.Drawing.Size(127, 30);
			this.btnDeleteAvatar.TabIndex = 10;
			this.btnDeleteAvatar.Text = "刪除頭像";
			this.btnDeleteAvatar.UseVisualStyleBackColor = true;
			this.btnDeleteAvatar.Click += new System.EventHandler(this.btnDeleteAvatar_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// txtForumAccountID
			// 
			this.txtForumAccountID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtForumAccountID.Location = new System.Drawing.Point(638, 15);
			this.txtForumAccountID.Name = "txtForumAccountID";
			this.txtForumAccountID.Size = new System.Drawing.Size(173, 29);
			this.txtForumAccountID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(523, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 20);
			this.label1.TabIndex = 43;
			this.label1.Text = "論壇帳戶編號:";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPassword.Location = new System.Drawing.Point(638, 68);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(173, 29);
			this.txtPassword.TabIndex = 44;
			// 
			// btnApplyForumMember
			// 
			this.btnApplyForumMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnApplyForumMember.AutoSize = true;
			this.btnApplyForumMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnApplyForumMember.Location = new System.Drawing.Point(114, 555);
			this.btnApplyForumMember.Name = "btnApplyForumMember";
			this.btnApplyForumMember.Size = new System.Drawing.Size(154, 30);
			this.btnApplyForumMember.TabIndex = 45;
			this.btnApplyForumMember.Text = "申請論壇帳戶";
			this.btnApplyForumMember.UseVisualStyleBackColor = true;
			this.btnApplyForumMember.Click += new System.EventHandler(this.btnApplyForumMember_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label9.Location = new System.Drawing.Point(587, 71);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 20);
			this.label9.TabIndex = 46;
			this.label9.Text = "密碼:";
			// 
			// btnEditForumName
			// 
			this.btnEditForumName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEditForumName.AutoSize = true;
			this.btnEditForumName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnEditForumName.Location = new System.Drawing.Point(114, 591);
			this.btnEditForumName.Name = "btnEditForumName";
			this.btnEditForumName.Size = new System.Drawing.Size(154, 30);
			this.btnEditForumName.TabIndex = 45;
			this.btnEditForumName.Text = "修改論壇稱呼";
			this.btnEditForumName.UseVisualStyleBackColor = true;
			this.btnEditForumName.Click += new System.EventHandler(this.btnEditForumName_Click);
			// 
			// form_EditMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 628);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnEditForumName);
			this.Controls.Add(this.btnApplyForumMember);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtForumAccountID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDeleteAvatar);
			this.Controls.Add(this.btnUploadAvatar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.DateOfBirthPicker);
			this.Controls.Add(this.txtAvatar);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAccount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNickName);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtMemberName);
			this.Controls.Add(this.labName);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Name = "form_EditMember";
			this.Text = "form_EditMember";
			this.Load += new System.EventHandler(this.form_EditMember_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox txtAvatar;
		private System.Windows.Forms.RadioButton radbtnFemale;
		private System.Windows.Forms.RadioButton radbtnMale;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMemberName;
		private System.Windows.Forms.Label labName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtNickName;
		private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnUploadAvatar;
		private System.Windows.Forms.Button btnDeleteAvatar;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtForumAccountID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnApplyForumMember;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnEditForumName;
	}
}