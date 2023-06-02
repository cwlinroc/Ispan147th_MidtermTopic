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
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonConfirmComment
			// 
			this.buttonConfirmComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonConfirmComment.Location = new System.Drawing.Point(272, 180);
			this.buttonConfirmComment.Margin = new System.Windows.Forms.Padding(2);
			this.buttonConfirmComment.Name = "buttonConfirmComment";
			this.buttonConfirmComment.Size = new System.Drawing.Size(84, 26);
			this.buttonConfirmComment.TabIndex = 24;
			this.buttonConfirmComment.Text = "確認送出";
			this.buttonConfirmComment.UseVisualStyleBackColor = true;
			// 
			// richTextBoxComment
			// 
			this.richTextBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxComment.Location = new System.Drawing.Point(34, 52);
			this.richTextBoxComment.Margin = new System.Windows.Forms.Padding(2);
			this.richTextBoxComment.Name = "richTextBoxComment";
			this.richTextBoxComment.Size = new System.Drawing.Size(322, 113);
			this.richTextBoxComment.TabIndex = 23;
			this.richTextBoxComment.Text = "";
			// 
			// labelCommentRole
			// 
			this.labelCommentRole.AutoSize = true;
			this.labelCommentRole.Location = new System.Drawing.Point(32, 21);
			this.labelCommentRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCommentRole.Name = "labelCommentRole";
			this.labelCommentRole.Size = new System.Drawing.Size(87, 12);
			this.labelCommentRole.TabIndex = 22;
			this.labelCommentRole.Text = "label留言建立者";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// from_CommentCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 226);
			this.Controls.Add(this.buttonConfirmComment);
			this.Controls.Add(this.richTextBoxComment);
			this.Controls.Add(this.labelCommentRole);
			this.Name = "from_CommentCreate";
			this.Text = "from_CommentCreate";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonConfirmComment;
		private System.Windows.Forms.RichTextBox richTextBoxComment;
		private System.Windows.Forms.Label labelCommentRole;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}