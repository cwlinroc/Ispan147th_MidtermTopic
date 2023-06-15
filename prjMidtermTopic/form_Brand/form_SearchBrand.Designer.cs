namespace prjMidtermTopic.form_Brand
{
	partial class form_SearchBrand
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
			this.BrandId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_DefaultSearch = new System.Windows.Forms.Button();
			this.txt_BrandName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_BrandId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Search = new System.Windows.Forms.Button();
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
			this.btn_Add.TabIndex = 25;
			this.btn_Add.Text = "新增品牌";
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
            this.BrandId,
            this.BrandName});
			this.dataGridView1.Location = new System.Drawing.Point(27, 112);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(318, 403);
			this.dataGridView1.TabIndex = 28;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// BrandId
			// 
			this.BrandId.DataPropertyName = "BrandID";
			this.BrandId.HeaderText = "品牌編號";
			this.BrandId.Name = "BrandId";
			this.BrandId.ReadOnly = true;
			// 
			// BrandName
			// 
			this.BrandName.DataPropertyName = "BrandName";
			this.BrandName.HeaderText = "品牌名稱";
			this.BrandName.Name = "BrandName";
			this.BrandName.ReadOnly = true;
			this.BrandName.Width = 170;
			// 
			// btn_DefaultSearch
			// 
			this.btn_DefaultSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_DefaultSearch.Location = new System.Drawing.Point(254, 57);
			this.btn_DefaultSearch.Name = "btn_DefaultSearch";
			this.btn_DefaultSearch.Size = new System.Drawing.Size(91, 30);
			this.btn_DefaultSearch.TabIndex = 24;
			this.btn_DefaultSearch.Text = "清空條件";
			this.btn_DefaultSearch.UseVisualStyleBackColor = true;
			this.btn_DefaultSearch.Click += new System.EventHandler(this.btn_DefaultSearch_Click);
			// 
			// txt_BrandName
			// 
			this.txt_BrandName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_BrandName.Location = new System.Drawing.Point(112, 59);
			this.txt_BrandName.Name = "txt_BrandName";
			this.txt_BrandName.Size = new System.Drawing.Size(100, 29);
			this.txt_BrandName.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(23, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 26;
			this.label2.Text = "品牌名稱：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txt_BrandId
			// 
			this.txt_BrandId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_BrandId.Location = new System.Drawing.Point(112, 24);
			this.txt_BrandId.Name = "txt_BrandId";
			this.txt_BrandId.Size = new System.Drawing.Size(100, 29);
			this.txt_BrandId.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(23, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 27;
			this.label1.Text = "品牌編號：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btn_Search
			// 
			this.btn_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Search.Location = new System.Drawing.Point(254, 23);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(91, 30);
			this.btn_Search.TabIndex = 23;
			this.btn_Search.Text = "搜尋";
			this.btn_Search.UseVisualStyleBackColor = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// form_SearchBrand
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 568);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_DefaultSearch);
			this.Controls.Add(this.txt_BrandName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_BrandId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Search);
			this.Name = "form_SearchBrand";
			this.Text = "商品品牌：檢視、搜尋";
			this.Load += new System.EventHandler(this.form_SearchBrand_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_DefaultSearch;
		private System.Windows.Forms.TextBox txt_BrandName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_BrandId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.DataGridViewTextBoxColumn BrandId;
		private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
	}
}