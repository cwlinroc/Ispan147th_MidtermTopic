namespace prjMidtermTopic
{
	partial class form_LogIn
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
			this.txt_Account = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.btn_LogIn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// txt_Account
			// 
			this.txt_Account.Location = new System.Drawing.Point(137, 58);
			this.txt_Account.Name = "txt_Account";
			this.txt_Account.Size = new System.Drawing.Size(171, 25);
			this.txt_Account.TabIndex = 1;
			this.txt_Account.Text = "admin";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "label1";
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(137, 121);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.PasswordChar = '*';
			this.txt_Password.Size = new System.Drawing.Size(171, 25);
			this.txt_Password.TabIndex = 1;
			this.txt_Password.Text = "admin";
			// 
			// btn_LogIn
			// 
			this.btn_LogIn.Location = new System.Drawing.Point(111, 192);
			this.btn_LogIn.Name = "btn_LogIn";
			this.btn_LogIn.Size = new System.Drawing.Size(131, 30);
			this.btn_LogIn.TabIndex = 2;
			this.btn_LogIn.Text = "登入";
			this.btn_LogIn.UseVisualStyleBackColor = true;
			this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
			// 
			// form_LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 261);
			this.Controls.Add(this.btn_LogIn);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_Account);
			this.Controls.Add(this.label1);
			this.Name = "form_LogIn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "form_Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Account;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_Password;
		private System.Windows.Forms.Button btn_LogIn;
	}
}