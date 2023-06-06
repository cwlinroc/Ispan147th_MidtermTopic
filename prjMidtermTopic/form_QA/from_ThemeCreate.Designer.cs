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
			this.labelThemeRoleID = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonConfirmTheme
			// 
			this.buttonConfirmTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonConfirmTheme.Location = new System.Drawing.Point(384, 235);
			this.buttonConfirmTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonConfirmTheme.Name = "buttonConfirmTheme";
			this.buttonConfirmTheme.Size = new System.Drawing.Size(84, 26);
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
			this.richTextBoxTheme.Location = new System.Drawing.Point(40, 64);
			this.richTextBoxTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.richTextBoxTheme.Name = "richTextBoxTheme";
			this.richTextBoxTheme.Size = new System.Drawing.Size(428, 156);
			this.richTextBoxTheme.TabIndex = 20;
			this.richTextBoxTheme.Text = "";
			// 
			// labelThemeRole
			// 
			this.labelThemeRole.AutoSize = true;
			this.labelThemeRole.Location = new System.Drawing.Point(37, 32);
			this.labelThemeRole.Name = "labelThemeRole";
			this.labelThemeRole.Size = new System.Drawing.Size(109, 15);
			this.labelThemeRole.TabIndex = 19;
			this.labelThemeRole.Text = "label主題建立者";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// labelThemeRoleID
			// 
			this.labelThemeRoleID.AutoSize = true;
			this.labelThemeRoleID.Location = new System.Drawing.Point(37, 7);
			this.labelThemeRoleID.Name = "labelThemeRoleID";
			this.labelThemeRoleID.Size = new System.Drawing.Size(124, 15);
			this.labelThemeRoleID.TabIndex = 22;
			this.labelThemeRoleID.Text = "label主題建立者ID";
			// 
			// from_ThemeCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 272);
			this.Controls.Add(this.labelThemeRoleID);
			this.Controls.Add(this.buttonConfirmTheme);
			this.Controls.Add(this.richTextBoxTheme);
			this.Controls.Add(this.labelThemeRole);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "from_ThemeCreate";
			this.Text = "QACreate";
			this.Load += new System.EventHandler(this.from_ThemeCreate_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonConfirmTheme;
		private System.Windows.Forms.RichTextBox richTextBoxTheme;
		private System.Windows.Forms.Label labelThemeRole;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label labelThemeRoleID;
	}
}