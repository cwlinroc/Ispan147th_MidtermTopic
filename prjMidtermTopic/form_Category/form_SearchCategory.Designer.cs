namespace prjMidtermTopic.form_Category
{
	partial class form_SearchCategory
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
			this.btn_Add = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txt_CategoryName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_CategoryId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Search = new System.Windows.Forms.Button();
			this.btn_DefaultSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Add
			// 
			this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Add.Location = new System.Drawing.Point(254, 526);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(91, 30);
			this.btn_Add.TabIndex = 17;
			this.btn_Add.Text = "新增類別";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
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
            this.CategoryId,
            this.CategoryName});
			this.dataGridView1.Location = new System.Drawing.Point(27, 112);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(318, 403);
			this.dataGridView1.TabIndex = 20;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// CategoryId
			// 
			this.CategoryId.DataPropertyName = "CategoryID";
			this.CategoryId.HeaderText = "類別編號";
			this.CategoryId.Name = "CategoryId";
			this.CategoryId.ReadOnly = true;
			// 
			// CategoryName
			// 
			this.CategoryName.DataPropertyName = "CategoryName";
			this.CategoryName.HeaderText = "類別名稱";
			this.CategoryName.Name = "CategoryName";
			this.CategoryName.ReadOnly = true;
			this.CategoryName.Width = 170;
			// 
			// txt_CategoryName
			// 
			this.txt_CategoryName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_CategoryName.Location = new System.Drawing.Point(112, 59);
			this.txt_CategoryName.Name = "txt_CategoryName";
			this.txt_CategoryName.Size = new System.Drawing.Size(100, 29);
			this.txt_CategoryName.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(23, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 18;
			this.label2.Text = "類別名稱：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txt_CategoryId
			// 
			this.txt_CategoryId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_CategoryId.Location = new System.Drawing.Point(112, 24);
			this.txt_CategoryId.Name = "txt_CategoryId";
			this.txt_CategoryId.Size = new System.Drawing.Size(100, 29);
			this.txt_CategoryId.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(23, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 20);
			this.label1.TabIndex = 19;
			this.label1.Text = "類別編號：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btn_Search
			// 
			this.btn_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Search.Location = new System.Drawing.Point(254, 23);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(91, 30);
			this.btn_Search.TabIndex = 16;
			this.btn_Search.Text = "搜尋";
			this.btn_Search.UseVisualStyleBackColor = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// btn_DefaultSearch
			// 
			this.btn_DefaultSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_DefaultSearch.Location = new System.Drawing.Point(254, 57);
			this.btn_DefaultSearch.Name = "btn_DefaultSearch";
			this.btn_DefaultSearch.Size = new System.Drawing.Size(91, 30);
			this.btn_DefaultSearch.TabIndex = 21;
			this.btn_DefaultSearch.Text = "清空條件";
			this.btn_DefaultSearch.UseVisualStyleBackColor = true;
			this.btn_DefaultSearch.Click += new System.EventHandler(this.btn_DefaultSearch_Click);
			// 
			// form_SearchCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 568);
			this.Controls.Add(this.btn_DefaultSearch);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txt_CategoryName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_CategoryId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Search);
			this.Name = "form_SearchCategory";
			this.Text = "商品類別：檢視、搜尋";
			this.Load += new System.EventHandler(this.form_SearchCategory_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txt_CategoryName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_CategoryId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
		private System.Windows.Forms.Button btn_DefaultSearch;
	}
}