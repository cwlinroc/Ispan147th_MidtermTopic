namespace prjMidtermTopic.Form_Employee
{
	partial class EmployeeForumAccountAdd
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
			this.txt_Forum = new System.Windows.Forms.TextBox();
			this.btn_Confirm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_Forum
			// 
			this.txt_Forum.Location = new System.Drawing.Point(37, 36);
			this.txt_Forum.Name = "txt_Forum";
			this.txt_Forum.Size = new System.Drawing.Size(132, 22);
			this.txt_Forum.TabIndex = 0;
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.Location = new System.Drawing.Point(62, 87);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
			this.btn_Confirm.TabIndex = 1;
			this.btn_Confirm.Text = "確認新增";
			this.btn_Confirm.UseVisualStyleBackColor = true;
			// 
			// EmployeeForumAccountAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(200, 137);
			this.Controls.Add(this.btn_Confirm);
			this.Controls.Add(this.txt_Forum);
			this.Name = "EmployeeForumAccountAdd";
			this.Text = "EmployeeForumAccountAdd";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_Forum;
		private System.Windows.Forms.Button btn_Confirm;
	}
}