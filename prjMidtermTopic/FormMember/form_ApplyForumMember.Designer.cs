namespace prjMidtermTopic.FormMember
{
	partial class form_ApplyForumMember
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
			this.txtNickName = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtMemberName = new System.Windows.Forms.TextBox();
			this.labName = new System.Windows.Forms.Label();
			this.btnApply = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNickName
			// 
			this.txtNickName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtNickName.Location = new System.Drawing.Point(168, 79);
			this.txtNickName.Name = "txtNickName";
			this.txtNickName.Size = new System.Drawing.Size(183, 29);
			this.txtNickName.TabIndex = 23;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label9.Location = new System.Drawing.Point(54, 86);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(90, 20);
			this.label9.TabIndex = 24;
			this.label9.Text = "Nickname:";
			// 
			// txtMemberName
			// 
			this.txtMemberName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtMemberName.Location = new System.Drawing.Point(168, 30);
			this.txtMemberName.Name = "txtMemberName";
			this.txtMemberName.Size = new System.Drawing.Size(183, 29);
			this.txtMemberName.TabIndex = 22;
			// 
			// labName
			// 
			this.labName.AutoSize = true;
			this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labName.Location = new System.Drawing.Point(21, 33);
			this.labName.Name = "labName";
			this.labName.Size = new System.Drawing.Size(123, 20);
			this.labName.TabIndex = 25;
			this.labName.Text = "MemberName:";
			// 
			// btnApply
			// 
			this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnApply.AutoSize = true;
			this.btnApply.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnApply.Location = new System.Drawing.Point(271, 258);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(80, 30);
			this.btnApply.TabIndex = 26;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			// 
			// form_ApplyForumMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 315);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.txtNickName);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtMemberName);
			this.Controls.Add(this.labName);
			this.Name = "form_ApplyForumMember";
			this.Text = "form_ApplyForumMember";
			this.Load += new System.EventHandler(this.form_ApplyForumMember_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNickName;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtMemberName;
		private System.Windows.Forms.Label labName;
		private System.Windows.Forms.Button btnApply;
	}
}