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
			this.dataGridViewTheme = new System.Windows.Forms.DataGridView();
			this.ThemeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThemeContext = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThemeDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheme)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSearch.Location = new System.Drawing.Point(223, 23);
			this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(71, 29);
			this.buttonSearch.TabIndex = 1;
			this.buttonSearch.Text = "搜尋";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxSearch.Location = new System.Drawing.Point(55, 23);
			this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(164, 29);
			this.textBoxSearch.TabIndex = 0;
			// 
			// buttonCreateTheme
			// 
			this.buttonCreateTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCreateTheme.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonCreateTheme.Location = new System.Drawing.Point(510, 353);
			this.buttonCreateTheme.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCreateTheme.Name = "buttonCreateTheme";
			this.buttonCreateTheme.Size = new System.Drawing.Size(94, 38);
			this.buttonCreateTheme.TabIndex = 2;
			this.buttonCreateTheme.Text = "新增主題";
			this.buttonCreateTheme.UseVisualStyleBackColor = true;
			this.buttonCreateTheme.Click += new System.EventHandler(this.buttonCreateTheme_Click_1);
			// 
			// dataGridViewTheme
			// 
			this.dataGridViewTheme.AllowUserToAddRows = false;
			this.dataGridViewTheme.AllowUserToDeleteRows = false;
			this.dataGridViewTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewTheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTheme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThemeId,
            this.ThemeContext,
            this.ThemeDateTime});
			this.dataGridViewTheme.Location = new System.Drawing.Point(55, 69);
			this.dataGridViewTheme.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridViewTheme.Name = "dataGridViewTheme";
			this.dataGridViewTheme.ReadOnly = true;
			this.dataGridViewTheme.RowHeadersWidth = 51;
			this.dataGridViewTheme.RowTemplate.Height = 27;
			this.dataGridViewTheme.Size = new System.Drawing.Size(549, 267);
			this.dataGridViewTheme.TabIndex = 9;
			this.dataGridViewTheme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTheme_CellClick);
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
			this.Controls.Add(this.dataGridViewTheme);
			this.Name = "form_QAList";
			this.Text = "主留言列表";
			this.Load += new System.EventHandler(this.form_QAList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheme)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonCreateTheme;
		private System.Windows.Forms.DataGridView dataGridViewTheme;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThemeId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThemeContext;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThemeDateTime;
	}
}