namespace prjMidtermTopic.Form_Employee
{
	partial class form_EmployeeAdd
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
			this.txt_EmployeeAccount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_EmployeeName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_EmployeePassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_Permission = new System.Windows.Forms.TextBox();
			this.btn_Add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "帳號";
			// 
			// txt_EmployeeAccount
			// 
			this.txt_EmployeeAccount.Location = new System.Drawing.Point(94, 67);
			this.txt_EmployeeAccount.Name = "txt_EmployeeAccount";
			this.txt_EmployeeAccount.Size = new System.Drawing.Size(100, 22);
			this.txt_EmployeeAccount.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "姓名";
			// 
			// txt_EmployeeName
			// 
			this.txt_EmployeeName.Location = new System.Drawing.Point(94, 39);
			this.txt_EmployeeName.Name = "txt_EmployeeName";
			this.txt_EmployeeName.Size = new System.Drawing.Size(100, 22);
			this.txt_EmployeeName.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "密碼";
			// 
			// txt_EmployeePassword
			// 
			this.txt_EmployeePassword.Location = new System.Drawing.Point(94, 95);
			this.txt_EmployeePassword.Name = "txt_EmployeePassword";
			this.txt_EmployeePassword.Size = new System.Drawing.Size(100, 22);
			this.txt_EmployeePassword.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(43, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "權限";
			// 
			// txt_Permission
			// 
			this.txt_Permission.Location = new System.Drawing.Point(94, 123);
			this.txt_Permission.Name = "txt_Permission";
			this.txt_Permission.Size = new System.Drawing.Size(100, 22);
			this.txt_Permission.TabIndex = 1;
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(70, 165);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(124, 23);
			this.btn_Add.TabIndex = 2;
			this.btn_Add.Text = "新增員工帳號";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// form_EmployeeAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(250, 223);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.txt_Permission);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_EmployeePassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_EmployeeName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_EmployeeAccount);
			this.Controls.Add(this.label1);
			this.Name = "form_EmployeeAdd";
			this.Text = "form_EmployeeAdd";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_EmployeeAccount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_EmployeeName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_EmployeePassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_Permission;
		private System.Windows.Forms.Button btn_Add;
	}
}