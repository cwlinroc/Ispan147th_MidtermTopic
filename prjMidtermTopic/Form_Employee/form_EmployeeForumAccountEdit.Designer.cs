namespace prjMidtermTopic.Form_Employee
{
	partial class form_EmployeeForumAccountEdit
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
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.txt_ForumName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.Location = new System.Drawing.Point(77, 106);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
			this.btn_Confirm.TabIndex = 3;
			this.btn_Confirm.Text = "確認修改";
			this.btn_Confirm.UseVisualStyleBackColor = true;
			this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
			// 
			// txt_ForumName
			// 
			this.txt_ForumName.Location = new System.Drawing.Point(36, 64);
			this.txt_ForumName.Name = "txt_ForumName";
			this.txt_ForumName.Size = new System.Drawing.Size(157, 22);
			this.txt_ForumName.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "帳號名稱";
			// 
			// form_EmployeeForumAccountEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(230, 151);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Confirm);
			this.Controls.Add(this.txt_ForumName);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "form_EmployeeForumAccountEdit";
			this.Text = "修改論壇帳號";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Confirm;
		private System.Windows.Forms.TextBox txt_ForumName;
		private System.Windows.Forms.Label label1;
	}
}