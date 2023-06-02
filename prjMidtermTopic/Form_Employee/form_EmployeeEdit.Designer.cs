namespace prjMidtermTopic.Form_Employee
{
	partial class form_EmployeeEdit
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
			this.btn_ChangePassword = new System.Windows.Forms.Button();
			this.txt_OldPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_EmployeePassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_EmployeeName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_EmployeeAccount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
			this.checkBox_ChangePassWord = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btn_ChangePassword
			// 
			this.btn_ChangePassword.Location = new System.Drawing.Point(66, 286);
			this.btn_ChangePassword.Name = "btn_ChangePassword";
			this.btn_ChangePassword.Size = new System.Drawing.Size(124, 23);
			this.btn_ChangePassword.TabIndex = 11;
			this.btn_ChangePassword.Text = "確認更改資料";
			this.btn_ChangePassword.UseVisualStyleBackColor = true;
			this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
			// 
			// txt_OldPassword
			// 
			this.txt_OldPassword.Location = new System.Drawing.Point(90, 165);
			this.txt_OldPassword.Name = "txt_OldPassword";
			this.txt_OldPassword.PasswordChar = '*';
			this.txt_OldPassword.Size = new System.Drawing.Size(100, 22);
			this.txt_OldPassword.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "舊密碼";
			// 
			// txt_EmployeePassword
			// 
			this.txt_EmployeePassword.Location = new System.Drawing.Point(90, 193);
			this.txt_EmployeePassword.Name = "txt_EmployeePassword";
			this.txt_EmployeePassword.PasswordChar = '*';
			this.txt_EmployeePassword.Size = new System.Drawing.Size(100, 22);
			this.txt_EmployeePassword.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "新密碼";
			// 
			// txt_EmployeeName
			// 
			this.txt_EmployeeName.Location = new System.Drawing.Point(90, 36);
			this.txt_EmployeeName.Name = "txt_EmployeeName";
			this.txt_EmployeeName.Size = new System.Drawing.Size(100, 22);
			this.txt_EmployeeName.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "姓名";
			// 
			// txt_EmployeeAccount
			// 
			this.txt_EmployeeAccount.Location = new System.Drawing.Point(90, 64);
			this.txt_EmployeeAccount.Name = "txt_EmployeeAccount";
			this.txt_EmployeeAccount.Size = new System.Drawing.Size(100, 22);
			this.txt_EmployeeAccount.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "帳號";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 4;
			this.label5.Text = "確認密碼";
			// 
			// txt_ConfirmPassword
			// 
			this.txt_ConfirmPassword.Location = new System.Drawing.Point(90, 221);
			this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
			this.txt_ConfirmPassword.PasswordChar = '*';
			this.txt_ConfirmPassword.Size = new System.Drawing.Size(100, 22);
			this.txt_ConfirmPassword.TabIndex = 8;
			// 
			// checkBox_ChangePassWord
			// 
			this.checkBox_ChangePassWord.AutoSize = true;
			this.checkBox_ChangePassWord.Location = new System.Drawing.Point(31, 137);
			this.checkBox_ChangePassWord.Name = "checkBox_ChangePassWord";
			this.checkBox_ChangePassWord.Size = new System.Drawing.Size(72, 16);
			this.checkBox_ChangePassWord.TabIndex = 12;
			this.checkBox_ChangePassWord.Text = "修改密碼";
			this.checkBox_ChangePassWord.UseVisualStyleBackColor = true;
			// 
			// form_EmployeeEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(247, 343);
			this.Controls.Add(this.checkBox_ChangePassWord);
			this.Controls.Add(this.btn_ChangePassword);
			this.Controls.Add(this.txt_OldPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_ConfirmPassword);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_EmployeePassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_EmployeeName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_EmployeeAccount);
			this.Controls.Add(this.label1);
			this.Name = "form_EmployeeEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EmployeeResetPassword";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_ChangePassword;
		private System.Windows.Forms.TextBox txt_OldPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_EmployeePassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_EmployeeName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_EmployeeAccount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_ConfirmPassword;
		private System.Windows.Forms.CheckBox checkBox_ChangePassWord;
	}
}