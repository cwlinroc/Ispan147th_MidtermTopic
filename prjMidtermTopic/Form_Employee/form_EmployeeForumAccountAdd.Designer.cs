namespace prjMidtermTopic.Form_Employee
{
	partial class form_EmployeeForumAccountAdd
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
			this.txt_ForumName = new System.Windows.Forms.TextBox();
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_ForumName
			// 
			this.txt_ForumName.Location = new System.Drawing.Point(58, 65);
			this.txt_ForumName.Name = "txt_ForumName";
			this.txt_ForumName.Size = new System.Drawing.Size(146, 22);
			this.txt_ForumName.TabIndex = 0;
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.Location = new System.Drawing.Point(88, 110);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
			this.btn_Confirm.TabIndex = 1;
			this.btn_Confirm.Text = "確認新增";
			this.btn_Confirm.UseVisualStyleBackColor = true;
			this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "帳號名稱";
			// 
			// form_EmployeeForumAccountAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 163);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Confirm);
			this.Controls.Add(this.txt_ForumName);
			this.Name = "form_EmployeeForumAccountAdd";
			this.Text = "新增論壇帳號";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_ForumName;
		private System.Windows.Forms.Button btn_Confirm;
		private System.Windows.Forms.Label label1;
	}
}