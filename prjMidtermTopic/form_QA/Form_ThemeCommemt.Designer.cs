namespace prjMidtermTopic.form_QA
{
	partial class Form_ThemeCommemt
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
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ThemeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThemeContext = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThemeDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonDeleteTheme = new System.Windows.Forms.Button();
			this.buttonCreateCommon = new System.Windows.Forms.Button();
			this.richTextBoxTheme = new System.Windows.Forms.RichTextBox();
			this.labelThemeDatetime = new System.Windows.Forms.Label();
			this.labelThemeRole = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 182);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 31;
			this.label1.Text = "留言回覆列";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThemeId,
            this.ThemeContext,
            this.ThemeDateTime});
			this.dataGridView1.Location = new System.Drawing.Point(34, 206);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(549, 166);
			this.dataGridView1.TabIndex = 30;
			// 
			// ThemeId
			// 
			this.ThemeId.DataPropertyName = "ThemeId";
			this.ThemeId.HeaderText = "編號";
			this.ThemeId.MinimumWidth = 6;
			this.ThemeId.Name = "ThemeId";
			this.ThemeId.ReadOnly = true;
			this.ThemeId.Width = 125;
			// 
			// ThemeContext
			// 
			this.ThemeContext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ThemeContext.DataPropertyName = "ThemeContext";
			this.ThemeContext.HeaderText = "主題";
			this.ThemeContext.MinimumWidth = 6;
			this.ThemeContext.Name = "ThemeContext";
			this.ThemeContext.ReadOnly = true;
			// 
			// ThemeDateTime
			// 
			this.ThemeDateTime.DataPropertyName = "ThemeDateTime";
			this.ThemeDateTime.HeaderText = "發佈時間";
			this.ThemeDateTime.MinimumWidth = 6;
			this.ThemeDateTime.Name = "ThemeDateTime";
			this.ThemeDateTime.ReadOnly = true;
			this.ThemeDateTime.Width = 125;
			// 
			// buttonDeleteTheme
			// 
			this.buttonDeleteTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDeleteTheme.Location = new System.Drawing.Point(514, 71);
			this.buttonDeleteTheme.Margin = new System.Windows.Forms.Padding(2);
			this.buttonDeleteTheme.Name = "buttonDeleteTheme";
			this.buttonDeleteTheme.Size = new System.Drawing.Size(70, 28);
			this.buttonDeleteTheme.TabIndex = 29;
			this.buttonDeleteTheme.Text = "刪除此筆";
			this.buttonDeleteTheme.UseVisualStyleBackColor = true;
			this.buttonDeleteTheme.Click += new System.EventHandler(this.buttonDeleteTheme_Click);
			// 
			// buttonCreateCommon
			// 
			this.buttonCreateCommon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCreateCommon.Location = new System.Drawing.Point(514, 112);
			this.buttonCreateCommon.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCreateCommon.Name = "buttonCreateCommon";
			this.buttonCreateCommon.Size = new System.Drawing.Size(70, 25);
			this.buttonCreateCommon.TabIndex = 28;
			this.buttonCreateCommon.Text = "回覆留言";
			this.buttonCreateCommon.UseVisualStyleBackColor = true;
			this.buttonCreateCommon.Click += new System.EventHandler(this.buttonCreateCommon_Click);
			// 
			// richTextBoxTheme
			// 
			this.richTextBoxTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxTheme.Location = new System.Drawing.Point(34, 71);
			this.richTextBoxTheme.Margin = new System.Windows.Forms.Padding(2);
			this.richTextBoxTheme.Name = "richTextBoxTheme";
			this.richTextBoxTheme.ReadOnly = true;
			this.richTextBoxTheme.Size = new System.Drawing.Size(464, 78);
			this.richTextBoxTheme.TabIndex = 27;
			this.richTextBoxTheme.Text = "";
			// 
			// labelThemeDatetime
			// 
			this.labelThemeDatetime.AutoSize = true;
			this.labelThemeDatetime.Location = new System.Drawing.Point(33, 47);
			this.labelThemeDatetime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelThemeDatetime.Name = "labelThemeDatetime";
			this.labelThemeDatetime.Size = new System.Drawing.Size(111, 12);
			this.labelThemeDatetime.TabIndex = 26;
			this.labelThemeDatetime.Text = "label主題建立日期間";
			// 
			// labelThemeRole
			// 
			this.labelThemeRole.AutoSize = true;
			this.labelThemeRole.Location = new System.Drawing.Point(33, 28);
			this.labelThemeRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelThemeRole.Name = "labelThemeRole";
			this.labelThemeRole.Size = new System.Drawing.Size(87, 12);
			this.labelThemeRole.TabIndex = 25;
			this.labelThemeRole.Text = "label主題建立者";
			// 
			// Form_ThemeCommemt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 401);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonDeleteTheme);
			this.Controls.Add(this.buttonCreateCommon);
			this.Controls.Add(this.richTextBoxTheme);
			this.Controls.Add(this.labelThemeDatetime);
			this.Controls.Add(this.labelThemeRole);
			this.Name = "Form_ThemeCommemt";
			this.Text = "Form_ThemeCommemt";
			this.Load += new System.EventHandler(this.Form_ThemeCommemt_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThemeId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThemeContext;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThemeDateTime;
		private System.Windows.Forms.Button buttonDeleteTheme;
		private System.Windows.Forms.Button buttonCreateCommon;
		private System.Windows.Forms.RichTextBox richTextBoxTheme;
		private System.Windows.Forms.Label labelThemeDatetime;
		private System.Windows.Forms.Label labelThemeRole;
	}
}