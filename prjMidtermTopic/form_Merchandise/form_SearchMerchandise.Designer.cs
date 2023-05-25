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
			this.comboBox_Category = new System.Windows.Forms.ComboBox();
			this.MerchandiseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MerchandiseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImageURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Add
			// 
			this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Add.Location = new System.Drawing.Point(683, 408);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(91, 30);
			this.btn_Add.TabIndex = 4;
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
            this.MerchandiseName,
            this.Column1,
            this.Price,
            this.Column2,
            this.Column3,
            this.ImageURL});
			this.dataGridView1.Location = new System.Drawing.Point(23, 76);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(751, 326);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// txt_MerchandiseName
			// 
			this.txt_MerchandiseName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MerchandiseName.Location = new System.Drawing.Point(297, 25);
			this.txt_MerchandiseName.Name = "txt_MerchandiseName";
			this.txt_MerchandiseName.Size = new System.Drawing.Size(100, 29);
			this.txt_MerchandiseName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(208, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "商品名稱：";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txt_MerchandiseId
			// 
			this.txt_MerchandiseId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MerchandiseId.Location = new System.Drawing.Point(92, 25);
			this.txt_MerchandiseId.Name = "txt_MerchandiseId";
			this.txt_MerchandiseId.Size = new System.Drawing.Size(100, 29);
			this.txt_MerchandiseId.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(19, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "商品ID：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btn_Search
			// 
			this.btn_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Search.Location = new System.Drawing.Point(683, 23);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(91, 30);
			this.btn_Search.TabIndex = 3;
			this.btn_Search.Text = "Search";
			this.btn_Search.UseVisualStyleBackColor = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// labCategoryName
			// 
			this.labCategoryName.AutoSize = true;
			this.labCategoryName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labCategoryName.Location = new System.Drawing.Point(415, 28);
			this.labCategoryName.Name = "labCategoryName";
			this.labCategoryName.Size = new System.Drawing.Size(89, 20);
			this.labCategoryName.TabIndex = 12;
			this.labCategoryName.Text = "商品類別：";
			this.labCategoryName.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboBox_Category
			// 
			this.comboBox_Category.FormattingEnabled = true;
			this.comboBox_Category.Location = new System.Drawing.Point(510, 28);
			this.comboBox_Category.Name = "comboBox_Category";
			this.comboBox_Category.Size = new System.Drawing.Size(121, 20);
			this.comboBox_Category.TabIndex = 2;
			// 
			// MerchandiseId
			// 
			this.MerchandiseId.DataPropertyName = "MerchandiseId";
			this.MerchandiseId.HeaderText = "商品編號";
			this.MerchandiseId.Name = "MerchandiseId";
			this.MerchandiseId.ReadOnly = true;
			// 
			// MerchandiseName
			// 
			this.MerchandiseName.DataPropertyName = "MerchandiseName";
			this.MerchandiseName.HeaderText = "商品名稱";
			this.MerchandiseName.Name = "MerchandiseName";
			this.MerchandiseName.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "CategoryID";
			this.Column1.HeaderText = "商品類別";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Price
			// 
			this.Price.DataPropertyName = "Price";
			this.Price.HeaderText = "價格";
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Amount";
			this.Column2.HeaderText = "庫存數量";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Description";
			this.Column3.HeaderText = "商品描述";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// ImageURL
			// 
			this.ImageURL.DataPropertyName = "ImageURL";
			this.ImageURL.HeaderText = "商品圖片";
			this.ImageURL.Name = "ImageURL";
			this.ImageURL.ReadOnly = true;
			// 
			// form_SearchMerchandise
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBox_Category);
			this.Controls.Add(this.labCategoryName);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txt_MerchandiseName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_MerchandiseId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Search);
			this.Name = "form_SearchMerchandise";
			this.Text = "商品管理：總覽、搜尋頁";
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
		private System.Windows.Forms.ComboBox comboBox_Category;
		private System.Windows.Forms.DataGridViewTextBoxColumn MerchandiseId;
		private System.Windows.Forms.DataGridViewTextBoxColumn MerchandiseName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn ImageURL;
	}
}