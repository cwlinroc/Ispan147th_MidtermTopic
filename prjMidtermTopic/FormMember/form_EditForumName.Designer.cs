namespace prjMidtermTopic.FormMember
{
	partial class form_EditForumName
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
			this.btnConfirm = new System.Windows.Forms.Button();
			this.txtForumName = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConfirm
			// 
			this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConfirm.AutoSize = true;
			this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnConfirm.Location = new System.Drawing.Point(213, 143);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(83, 30);
			this.btnConfirm.TabIndex = 29;
			this.btnConfirm.Text = "確認修改";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// txtForumName
			// 
			this.txtForumName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtForumName.Location = new System.Drawing.Point(100, 28);
			this.txtForumName.Name = "txtForumName";
			this.txtForumName.Size = new System.Drawing.Size(183, 29);
			this.txtForumName.TabIndex = 27;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label9.Location = new System.Drawing.Point(17, 31);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(77, 20);
			this.label9.TabIndex = 28;
			this.label9.Text = "論壇稱呼:";
			// 
			// form_EditForumName
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 185);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.txtForumName);
			this.Controls.Add(this.label9);
			this.Name = "form_EditForumName";
			this.Text = "form_EditForumName";
			this.Load += new System.EventHandler(this.form_EditForumName_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.TextBox txtForumName;
		private System.Windows.Forms.Label label9;
	}
}