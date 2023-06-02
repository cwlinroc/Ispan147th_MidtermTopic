namespace prjMidtermTopic.form_QA
{
	partial class from_ThemeCreate
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
			this.buttonConfirmTheme = new System.Windows.Forms.Button();
			this.richTextBoxTheme = new System.Windows.Forms.RichTextBox();
			this.labelThemeRole = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonConfirmTheme
			// 
			this.buttonConfirmTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonConfirmTheme.Location = new System.Drawing.Point(288, 180);
			this.buttonConfirmTheme.Margin = new System.Windows.Forms.Padding(2);
			this.buttonConfirmTheme.Name = "buttonConfirmTheme";
			this.buttonConfirmTheme.Size = new System.Drawing.Size(63, 21);
			this.buttonConfirmTheme.TabIndex = 21;
			this.buttonConfirmTheme.Text = "確認送出";
			this.buttonConfirmTheme.UseVisualStyleBackColor = true;
			this.buttonConfirmTheme.Click += new System.EventHandler(this.buttonConfirmTheme_Click);
			// 
			// richTextBoxTheme
			// 
			this.richTextBoxTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxTheme.Location = new System.Drawing.Point(30, 43);
			this.richTextBoxTheme.Margin = new System.Windows.Forms.Padding(2);
			this.richTextBoxTheme.Name = "richTextBoxTheme";
			this.richTextBoxTheme.Size = new System.Drawing.Size(322, 126);
			this.richTextBoxTheme.TabIndex = 20;
			this.richTextBoxTheme.Text = "";
			// 
			// labelThemeRole
			// 
			this.labelThemeRole.AutoSize = true;
			this.labelThemeRole.Location = new System.Drawing.Point(28, 18);
			this.labelThemeRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelThemeRole.Name = "labelThemeRole";
			this.labelThemeRole.Size = new System.Drawing.Size(87, 12);
			this.labelThemeRole.TabIndex = 19;
			this.labelThemeRole.Text = "label主題建立者";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// from_ThemeCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 218);
			this.Controls.Add(this.buttonConfirmTheme);
			this.Controls.Add(this.richTextBoxTheme);
			this.Controls.Add(this.labelThemeRole);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "from_ThemeCreate";
			this.Text = "QACreate";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonConfirmTheme;
		private System.Windows.Forms.RichTextBox richTextBoxTheme;
		private System.Windows.Forms.Label labelThemeRole;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}