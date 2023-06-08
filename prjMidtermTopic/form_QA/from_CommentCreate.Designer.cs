namespace prjMidtermTopic.form_QA
{
	partial class from_CommentCreate
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
			this.components = new System.ComponentModel.Container();
			this.buttonConfirmComment = new System.Windows.Forms.Button();
			this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
			this.labelCommentRole = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.labelCommentRoleID = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonConfirmComment
			// 
			this.buttonConfirmComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonConfirmComment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonConfirmComment.Location = new System.Drawing.Point(300, 289);
			this.buttonConfirmComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonConfirmComment.Name = "buttonConfirmComment";
			this.buttonConfirmComment.Size = new System.Drawing.Size(96, 35);
			this.buttonConfirmComment.TabIndex = 24;
			this.buttonConfirmComment.Text = "確認送出";
			this.buttonConfirmComment.UseVisualStyleBackColor = true;
			this.buttonConfirmComment.Click += new System.EventHandler(this.buttonConfirmComment_Click);
			// 
			// richTextBoxComment
			// 
			this.richTextBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxComment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.richTextBoxComment.Location = new System.Drawing.Point(34, 72);
			this.richTextBoxComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.richTextBoxComment.Name = "richTextBoxComment";
			this.richTextBoxComment.Size = new System.Drawing.Size(362, 202);
			this.richTextBoxComment.TabIndex = 23;
			this.richTextBoxComment.Text = "";
			// 
			// labelCommentRole
			// 
			this.labelCommentRole.AutoSize = true;
			this.labelCommentRole.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelCommentRole.Location = new System.Drawing.Point(30, 45);
			this.labelCommentRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCommentRole.Name = "labelCommentRole";
			this.labelCommentRole.Size = new System.Drawing.Size(126, 21);
			this.labelCommentRole.TabIndex = 22;
			this.labelCommentRole.Text = "label留言建立者";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// labelCommentRoleID
			// 
			this.labelCommentRoleID.AutoSize = true;
			this.labelCommentRoleID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelCommentRoleID.Location = new System.Drawing.Point(30, 14);
			this.labelCommentRoleID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCommentRoleID.Name = "labelCommentRoleID";
			this.labelCommentRoleID.Size = new System.Drawing.Size(143, 21);
			this.labelCommentRoleID.TabIndex = 25;
			this.labelCommentRoleID.Text = "label留言建立者ID";
			// 
			// from_CommentCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 335);
			this.Controls.Add(this.labelCommentRoleID);
			this.Controls.Add(this.buttonConfirmComment);
			this.Controls.Add(this.richTextBoxComment);
			this.Controls.Add(this.labelCommentRole);
			this.Name = "from_CommentCreate";
			this.Text = "新增留言";
			this.Load += new System.EventHandler(this.from_CommentCreate_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonConfirmComment;
		private System.Windows.Forms.RichTextBox richTextBoxComment;
		private System.Windows.Forms.Label labelCommentRole;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label labelCommentRoleID;
	}
}