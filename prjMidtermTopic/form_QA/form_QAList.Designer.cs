namespace prjMidtermTopic
{
	partial class form_QAList
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
			this.buttonSearch = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonCreateTheme = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ThemeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThemeContext = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThemeDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(148, 23);
			this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(61, 23);
			this.buttonSearch.TabIndex = 12;
			this.buttonSearch.Text = "搜尋";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(55, 23);
			this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(76, 22);
			this.textBoxSearch.TabIndex = 11;
			// 
			// buttonCreateTheme
			// 
			this.buttonCreateTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCreateTheme.Location = new System.Drawing.Point(526, 353);
			this.buttonCreateTheme.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCreateTheme.Name = "buttonCreateTheme";
			this.buttonCreateTheme.Size = new System.Drawing.Size(78, 26);
			this.buttonCreateTheme.TabIndex = 10;
			this.buttonCreateTheme.Text = "新增主題";
			this.buttonCreateTheme.UseVisualStyleBackColor = true;
			this.buttonCreateTheme.Click += new System.EventHandler(this.buttonCreateTheme_Click_1);
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
			this.dataGridView1.Location = new System.Drawing.Point(55, 69);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(549, 267);
			this.dataGridView1.TabIndex = 9;
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
			// form_QAList
			// 
			this.ClientSize = new System.Drawing.Size(658, 402);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.buttonCreateTheme);
			this.Controls.Add(this.dataGridView1);
			this.Name = "form_QAList";
			this.Text = "主留言列表";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonCreateTheme;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThemeId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThemeContext;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThemeDateTime;
	}
}