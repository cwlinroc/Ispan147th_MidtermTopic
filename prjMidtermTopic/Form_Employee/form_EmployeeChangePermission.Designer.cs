namespace prjMidtermTopic.Form_Employee
{
	partial class form_EmployeeChangePermission
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
			this.btn_Change = new System.Windows.Forms.Button();
			this.txt_Permission = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Change
			// 
			this.btn_Change.Location = new System.Drawing.Point(52, 83);
			this.btn_Change.Name = "btn_Change";
			this.btn_Change.Size = new System.Drawing.Size(99, 23);
			this.btn_Change.TabIndex = 0;
			this.btn_Change.Text = "更改";
			this.btn_Change.UseVisualStyleBackColor = true;
			this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
			// 
			// txt_Permission
			// 
			this.txt_Permission.Location = new System.Drawing.Point(89, 40);
			this.txt_Permission.Name = "txt_Permission";
			this.txt_Permission.Size = new System.Drawing.Size(100, 22);
			this.txt_Permission.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "權限：";
			// 
			// form_EmployeeChangePermission
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 128);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_Permission);
			this.Controls.Add(this.btn_Change);
			this.Name = "form_EmployeeChangePermission";
			this.Text = "form_EmployeeChangePermission";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Change;
		private System.Windows.Forms.TextBox txt_Permission;
		private System.Windows.Forms.Label label1;
	}
}