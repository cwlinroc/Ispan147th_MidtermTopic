﻿namespace prjMidtermTopic
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_LogIn));
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Account = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.btn_LogIn = new System.Windows.Forms.Button();
			this.btn_Close = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(56, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "帳號：";
			// 
			// txt_Account
			// 
			this.txt_Account.Location = new System.Drawing.Point(137, 95);
			this.txt_Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Account.Name = "txt_Account";
			this.txt_Account.Size = new System.Drawing.Size(171, 25);
			this.txt_Account.TabIndex = 1;
			this.txt_Account.Text = "admin";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(56, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "密碼：";
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(137, 159);
			this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.PasswordChar = '*';
			this.txt_Password.Size = new System.Drawing.Size(171, 25);
			this.txt_Password.TabIndex = 1;
			this.txt_Password.Text = "admin";
			// 
			// btn_LogIn
			// 
			this.btn_LogIn.ForeColor = System.Drawing.Color.DimGray;
			this.btn_LogIn.Location = new System.Drawing.Point(96, 230);
			this.btn_LogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_LogIn.Name = "btn_LogIn";
			this.btn_LogIn.Size = new System.Drawing.Size(179, 44);
			this.btn_LogIn.TabIndex = 2;
			this.btn_LogIn.Text = "登入";
			this.btn_LogIn.UseVisualStyleBackColor = true;
			this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
			// 
			// btn_Close
			// 
			this.btn_Close.BackColor = System.Drawing.Color.Transparent;
			this.btn_Close.BackgroundImage = global::prjMidtermTopic.Properties.Resources.closeWin;
			this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_Close.FlatAppearance.BorderSize = 0;
			this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
			this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Close.Location = new System.Drawing.Point(320, 15);
			this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(33, 31);
			this.btn_Close.TabIndex = 3;
			this.btn_Close.UseVisualStyleBackColor = false;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// form_LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
			this.ClientSize = new System.Drawing.Size(369, 325);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.btn_LogIn);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_Account);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "form_LogIn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登入";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_LogIn_MouseDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Account;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_Password;
		private System.Windows.Forms.Button btn_LogIn;
		private System.Windows.Forms.Button btn_Close;
	}
}