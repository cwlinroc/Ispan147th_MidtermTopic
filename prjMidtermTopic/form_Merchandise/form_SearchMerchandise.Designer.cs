namespace prjMidtermTopic
{
    partial class form_SearchMerchandise
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
			this.txt_MerchandiseName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_MerchandiseId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Search = new System.Windows.Forms.Button();
			this.labCategoryName = new System.Windows.Forms.Label();
			this.comboBox_CategoryId = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_MaxPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_MinPrice = new System.Windows.Forms.TextBox();
			this.btn_DefaultSearch = new System.Windows.Forms.Button();
			this.txt_MaxQuery = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox_SortBy = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.checkBox_desc = new System.Windows.Forms.CheckBox();
			this.checkBox_MaxData = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_BrandName = new System.Windows.Forms.TextBox();
			this.MerchandiseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MerchandiseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImageURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BrandId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Add
			// 
			this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Add.Location = new System.Drawing.Point(1154, 408);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(91, 30);
			this.btn_Add.TabIndex = 11;
			this.btn_Add.Text = "新增商品";
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
            this.MerchandiseId,
            this.BrandName,
            this.CategoryName,
            this.MerchandiseName,
            this.Description,
            this.ImageURL,
            this.CategoryId,
            this.BrandId});
			this.dataGridView1.Location = new System.Drawing.Point(23, 87);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1222, 315);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// txt_MerchandiseName
			// 
			this.txt_MerchandiseName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MerchandiseName.Location = new System.Drawing.Point(110, 49);
			this.txt_MerchandiseName.Name = "txt_MerchandiseName";
			this.txt_MerchandiseName.Size = new System.Drawing.Size(100, 29);
			this.txt_MerchandiseName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(21, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 7;
			this.label2.Text = "商品名稱：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txt_MerchandiseId
			// 
			this.txt_MerchandiseId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MerchandiseId.Location = new System.Drawing.Point(110, 13);
			this.txt_MerchandiseId.Name = "txt_MerchandiseId";
			this.txt_MerchandiseId.Size = new System.Drawing.Size(100, 29);
			this.txt_MerchandiseId.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(21, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 8;
			this.label1.Text = "商品編號：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btn_Search
			// 
			this.btn_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Search.Location = new System.Drawing.Point(1154, 11);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(91, 30);
			this.btn_Search.TabIndex = 9;
			this.btn_Search.Text = "搜尋";
			this.btn_Search.UseVisualStyleBackColor = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// labCategoryName
			// 
			this.labCategoryName.AutoSize = true;
			this.labCategoryName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labCategoryName.Location = new System.Drawing.Point(286, 52);
			this.labCategoryName.Name = "labCategoryName";
			this.labCategoryName.Size = new System.Drawing.Size(90, 21);
			this.labCategoryName.TabIndex = 12;
			this.labCategoryName.Text = "商品類別：";
			this.labCategoryName.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox_CategoryId
			// 
			this.comboBox_CategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_CategoryId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox_CategoryId.FormattingEnabled = true;
			this.comboBox_CategoryId.Location = new System.Drawing.Point(375, 49);
			this.comboBox_CategoryId.Name = "comboBox_CategoryId";
			this.comboBox_CategoryId.Size = new System.Drawing.Size(121, 28);
			this.comboBox_CategoryId.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(566, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 21);
			this.label3.TabIndex = 7;
			this.label3.Text = "最高價格：";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txt_MaxPrice
			// 
			this.txt_MaxPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MaxPrice.Location = new System.Drawing.Point(655, 12);
			this.txt_MaxPrice.Name = "txt_MaxPrice";
			this.txt_MaxPrice.Size = new System.Drawing.Size(100, 29);
			this.txt_MaxPrice.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(566, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "最低價格：";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txt_MinPrice
			// 
			this.txt_MinPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MinPrice.Location = new System.Drawing.Point(655, 47);
			this.txt_MinPrice.Name = "txt_MinPrice";
			this.txt_MinPrice.Size = new System.Drawing.Size(100, 29);
			this.txt_MinPrice.TabIndex = 4;
			// 
			// btn_DefaultSearch
			// 
			this.btn_DefaultSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_DefaultSearch.Location = new System.Drawing.Point(1154, 47);
			this.btn_DefaultSearch.Name = "btn_DefaultSearch";
			this.btn_DefaultSearch.Size = new System.Drawing.Size(91, 30);
			this.btn_DefaultSearch.TabIndex = 10;
			this.btn_DefaultSearch.Text = "清空條件";
			this.btn_DefaultSearch.UseVisualStyleBackColor = true;
			this.btn_DefaultSearch.Click += new System.EventHandler(this.btn_DefaultSearch_Click);
			// 
			// txt_MaxQuery
			// 
			this.txt_MaxQuery.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MaxQuery.Location = new System.Drawing.Point(915, 11);
			this.txt_MaxQuery.Name = "txt_MaxQuery";
			this.txt_MaxQuery.Size = new System.Drawing.Size(67, 29);
			this.txt_MaxQuery.TabIndex = 6;
			this.txt_MaxQuery.Text = "100";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(820, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 21);
			this.label6.TabIndex = 12;
			this.label6.Text = "排序依據：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox_SortBy
			// 
			this.comboBox_SortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_SortBy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox_SortBy.FormattingEnabled = true;
			this.comboBox_SortBy.Location = new System.Drawing.Point(915, 51);
			this.comboBox_SortBy.Name = "comboBox_SortBy";
			this.comboBox_SortBy.Size = new System.Drawing.Size(121, 28);
			this.comboBox_SortBy.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(988, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 21);
			this.label7.TabIndex = 13;
			this.label7.Text = "筆資料";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// checkBox_desc
			// 
			this.checkBox_desc.AutoSize = true;
			this.checkBox_desc.Location = new System.Drawing.Point(1042, 57);
			this.checkBox_desc.Name = "checkBox_desc";
			this.checkBox_desc.Size = new System.Drawing.Size(48, 16);
			this.checkBox_desc.TabIndex = 8;
			this.checkBox_desc.Text = "降冪";
			this.checkBox_desc.UseVisualStyleBackColor = true;
			// 
			// checkBox_MaxData
			// 
			this.checkBox_MaxData.AutoSize = true;
			this.checkBox_MaxData.Checked = true;
			this.checkBox_MaxData.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_MaxData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.checkBox_MaxData.Location = new System.Drawing.Point(824, 14);
			this.checkBox_MaxData.Name = "checkBox_MaxData";
			this.checkBox_MaxData.Size = new System.Drawing.Size(93, 25);
			this.checkBox_MaxData.TabIndex = 5;
			this.checkBox_MaxData.Text = "最多顯示";
			this.checkBox_MaxData.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(286, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 21);
			this.label5.TabIndex = 7;
			this.label5.Text = "最高價格：";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox1.Location = new System.Drawing.Point(375, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 29);
			this.textBox1.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(286, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 21);
			this.label8.TabIndex = 7;
			this.label8.Text = "品牌名稱：";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txt_BrandName
			// 
			this.txt_BrandName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_BrandName.Location = new System.Drawing.Point(375, 13);
			this.txt_BrandName.Name = "txt_BrandName";
			this.txt_BrandName.Size = new System.Drawing.Size(121, 29);
			this.txt_BrandName.TabIndex = 3;
			// 
			// MerchandiseId
			// 
			this.MerchandiseId.DataPropertyName = "MerchandiseId";
			this.MerchandiseId.Frozen = true;
			this.MerchandiseId.HeaderText = "商品編號";
			this.MerchandiseId.Name = "MerchandiseId";
			this.MerchandiseId.ReadOnly = true;
			// 
			// BrandName
			// 
			this.BrandName.DataPropertyName = "BrandName";
			this.BrandName.Frozen = true;
			this.BrandName.HeaderText = "品牌名稱";
			this.BrandName.Name = "BrandName";
			this.BrandName.ReadOnly = true;
			this.BrandName.Width = 120;
			// 
			// CategoryName
			// 
			this.CategoryName.DataPropertyName = "CategoryName";
			this.CategoryName.Frozen = true;
			this.CategoryName.HeaderText = "商品類別";
			this.CategoryName.Name = "CategoryName";
			this.CategoryName.ReadOnly = true;
			this.CategoryName.Width = 120;
			// 
			// MerchandiseName
			// 
			this.MerchandiseName.DataPropertyName = "MerchandiseName";
			this.MerchandiseName.Frozen = true;
			this.MerchandiseName.HeaderText = "商品名稱";
			this.MerchandiseName.Name = "MerchandiseName";
			this.MerchandiseName.ReadOnly = true;
			this.MerchandiseName.Width = 200;
			// 
			// Description
			// 
			this.Description.DataPropertyName = "Description";
			this.Description.Frozen = true;
			this.Description.HeaderText = "商品描述";
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			this.Description.Width = 250;
			// 
			// ImageURL
			// 
			this.ImageURL.DataPropertyName = "ImageURL";
			this.ImageURL.Frozen = true;
			this.ImageURL.HeaderText = "商品圖片";
			this.ImageURL.Name = "ImageURL";
			this.ImageURL.ReadOnly = true;
			this.ImageURL.Width = 150;
			// 
			// CategoryId
			// 
			this.CategoryId.DataPropertyName = "CategoryId";
			this.CategoryId.Frozen = true;
			this.CategoryId.HeaderText = "類別編號";
			this.CategoryId.Name = "CategoryId";
			this.CategoryId.ReadOnly = true;
			this.CategoryId.Visible = false;
			// 
			// BrandId
			// 
			this.BrandId.DataPropertyName = "BrandId";
			this.BrandId.Frozen = true;
			this.BrandId.HeaderText = "品牌編號";
			this.BrandId.Name = "BrandId";
			this.BrandId.ReadOnly = true;
			this.BrandId.Visible = false;
			// 
			// form_SearchMerchandise
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1271, 450);
			this.Controls.Add(this.txt_MaxQuery);
			this.Controls.Add(this.checkBox_MaxData);
			this.Controls.Add(this.checkBox_desc);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBox_SortBy);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox_CategoryId);
			this.Controls.Add(this.labCategoryName);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txt_MinPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_BrandName);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_MaxPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_MerchandiseName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_MerchandiseId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_DefaultSearch);
			this.Controls.Add(this.btn_Search);
			this.Name = "form_SearchMerchandise";
			this.Text = "商品管理：檢視、搜尋";
			this.Load += new System.EventHandler(this.FormSearchMerchandise_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txt_MerchandiseName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_MerchandiseId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.Label labCategoryName;
		private System.Windows.Forms.ComboBox comboBox_CategoryId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_MaxPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_MinPrice;
		private System.Windows.Forms.Button btn_DefaultSearch;
		private System.Windows.Forms.TextBox txt_MaxQuery;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox_SortBy;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox checkBox_desc;
		private System.Windows.Forms.CheckBox checkBox_MaxData;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_BrandName;
		private System.Windows.Forms.DataGridViewTextBoxColumn MerchandiseId;
		private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
		private System.Windows.Forms.DataGridViewTextBoxColumn MerchandiseName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn ImageURL;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
		private System.Windows.Forms.DataGridViewTextBoxColumn BrandId;
	}
}