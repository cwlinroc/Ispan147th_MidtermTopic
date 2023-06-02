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
			this.SuspendLayout();
			// 
			// txt_Forum
			// 
			this.txt_ForumName.Location = new System.Drawing.Point(49, 45);
			this.txt_ForumName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_ForumName.Name = "txt_Forum";
			this.txt_ForumName.Size = new System.Drawing.Size(175, 25);
			this.txt_ForumName.TabIndex = 0;
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.Location = new System.Drawing.Point(83, 109);
			this.btn_Confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(100, 29);
			this.btn_Confirm.TabIndex = 1;
			this.btn_Confirm.Text = "確認新增";
			this.btn_Confirm.UseVisualStyleBackColor = true;
			this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
			// 
			// form_EmployeeForumAccountAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(267, 171);
			this.Controls.Add(this.btn_Confirm);
			this.Controls.Add(this.txt_ForumName);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "form_EmployeeForumAccountAdd";
			this.Text = "EmployeeForumAccountAdd";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_ForumName;
		private System.Windows.Forms.Button btn_Confirm;
	}
}