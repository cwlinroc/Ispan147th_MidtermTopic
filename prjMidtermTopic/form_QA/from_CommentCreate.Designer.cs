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
			this.buttonConfirmComment.Location = new System.Drawing.Point(363, 225);
			this.buttonConfirmComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonConfirmComment.Name = "buttonConfirmComment";
			this.buttonConfirmComment.Size = new System.Drawing.Size(112, 32);
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
			this.richTextBoxComment.Location = new System.Drawing.Point(45, 65);
			this.richTextBoxComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.richTextBoxComment.Name = "richTextBoxComment";
			this.richTextBoxComment.Size = new System.Drawing.Size(428, 140);
			this.richTextBoxComment.TabIndex = 23;
			this.richTextBoxComment.Text = "";
			// 
			// labelCommentRole
			// 
			this.labelCommentRole.AutoSize = true;
			this.labelCommentRole.Location = new System.Drawing.Point(42, 32);
			this.labelCommentRole.Name = "labelCommentRole";
			this.labelCommentRole.Size = new System.Drawing.Size(109, 15);
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
			this.labelCommentRoleID.Location = new System.Drawing.Point(42, 9);
			this.labelCommentRoleID.Name = "labelCommentRoleID";
			this.labelCommentRoleID.Size = new System.Drawing.Size(124, 15);
			this.labelCommentRoleID.TabIndex = 25;
			this.labelCommentRoleID.Text = "label留言建立者ID";
			// 
			// from_CommentCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 282);
			this.Controls.Add(this.labelCommentRoleID);
			this.Controls.Add(this.buttonConfirmComment);
			this.Controls.Add(this.richTextBoxComment);
			this.Controls.Add(this.labelCommentRole);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "from_CommentCreate";
			this.Text = "from_CommentCreate";
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