namespace prjMidtermTopic.form_Merchandise
{
	partial class form_ViewMerchandise
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
			this.pictureBox_Image = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btn_Edit = new System.Windows.Forms.Button();
			this.txt_Description = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_MerchandiseId = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_MerchandiseName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView_Spec = new System.Windows.Forms.DataGridView();
			this.SpecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SpecId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_AddSpec = new System.Windows.Forms.Button();
			this.txt_CategoryName = new System.Windows.Forms.TextBox();
			this.txt_BrandName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Spec)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_Image
			// 
			this.pictureBox_Image.Location = new System.Drawing.Point(544, 16);
			this.pictureBox_Image.Name = "pictureBox_Image";
			this.pictureBox_Image.Size = new System.Drawing.Size(266, 205);
			this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_Image.TabIndex = 34;
			this.pictureBox_Image.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(449, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 21);
			this.label8.TabIndex = 33;
			this.label8.Text = "商品圖片：";
			// 
			// btn_Edit
			// 
			this.btn_Edit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Edit.Location = new System.Drawing.Point(715, 405);
			this.btn_Edit.Name = "btn_Edit";
			this.btn_Edit.Size = new System.Drawing.Size(95, 34);
			this.btn_Edit.TabIndex = 23;
			this.btn_Edit.Text = "編輯商品";
			this.btn_Edit.UseVisualStyleBackColor = true;
			this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
			// 
			// txt_Description
			// 
			this.txt_Description.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_Description.Location = new System.Drawing.Point(544, 227);
			this.txt_Description.Multiline = true;
			this.txt_Description.Name = "txt_Description";
			this.txt_Description.ReadOnly = true;
			this.txt_Description.Size = new System.Drawing.Size(266, 172);
			this.txt_Description.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(41, 125);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 26;
			this.label1.Text = "商品品牌：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(449, 230);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 21);
			this.label5.TabIndex = 27;
			this.label5.Text = "商品描述：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(41, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 21);
			this.label3.TabIndex = 28;
			this.label3.Text = "商品類別：";
			// 
			// txt_MerchandiseId
			// 
			this.txt_MerchandiseId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MerchandiseId.Location = new System.Drawing.Point(136, 16);
			this.txt_MerchandiseId.Name = "txt_MerchandiseId";
			this.txt_MerchandiseId.ReadOnly = true;
			this.txt_MerchandiseId.Size = new System.Drawing.Size(266, 29);
			this.txt_MerchandiseId.TabIndex = 31;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(40, 19);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 21);
			this.label7.TabIndex = 30;
			this.label7.Text = "商品編號：";
			// 
			// txt_MerchandiseName
			// 
			this.txt_MerchandiseName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MerchandiseName.Location = new System.Drawing.Point(136, 51);
			this.txt_MerchandiseName.Name = "txt_MerchandiseName";
			this.txt_MerchandiseName.ReadOnly = true;
			this.txt_MerchandiseName.Size = new System.Drawing.Size(266, 29);
			this.txt_MerchandiseName.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(41, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 29;
			this.label2.Text = "商品名稱：";
			// 
			// dataGridView_Spec
			// 
			this.dataGridView_Spec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Spec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpecName,
            this.Price,
            this.Amount,
            this.SpecId});
			this.dataGridView_Spec.Location = new System.Drawing.Point(136, 157);
			this.dataGridView_Spec.Name = "dataGridView_Spec";
			this.dataGridView_Spec.RowTemplate.Height = 24;
			this.dataGridView_Spec.Size = new System.Drawing.Size(266, 245);
			this.dataGridView_Spec.TabIndex = 35;
			// 
			// SpecName
			// 
			this.SpecName.DataPropertyName = "SpecName";
			this.SpecName.HeaderText = "規格名稱";
			this.SpecName.Name = "SpecName";
			// 
			// Price
			// 
			this.Price.DataPropertyName = "Price";
			this.Price.HeaderText = "價格";
			this.Price.Name = "Price";
			this.Price.Width = 60;
			// 
			// Amount
			// 
			this.Amount.DataPropertyName = "Amount";
			this.Amount.HeaderText = "庫存";
			this.Amount.Name = "Amount";
			this.Amount.Width = 60;
			// 
			// SpecId
			// 
			this.SpecId.DataPropertyName = "SpecId";
			this.SpecId.HeaderText = "規格編號";
			this.SpecId.Name = "SpecId";
			this.SpecId.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(41, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 21);
			this.label4.TabIndex = 26;
			this.label4.Text = "商品規格：";
			// 
			// btn_AddSpec
			// 
			this.btn_AddSpec.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_AddSpec.Location = new System.Drawing.Point(323, 405);
			this.btn_AddSpec.Name = "btn_AddSpec";
			this.btn_AddSpec.Size = new System.Drawing.Size(79, 34);
			this.btn_AddSpec.TabIndex = 36;
			this.btn_AddSpec.Text = "新增規格";
			this.btn_AddSpec.UseVisualStyleBackColor = true;
			this.btn_AddSpec.Click += new System.EventHandler(this.btn_AddSpec_Click);
			// 
			// txt_CategoryName
			// 
			this.txt_CategoryName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_CategoryName.Location = new System.Drawing.Point(136, 86);
			this.txt_CategoryName.Name = "txt_CategoryName";
			this.txt_CategoryName.ReadOnly = true;
			this.txt_CategoryName.Size = new System.Drawing.Size(266, 29);
			this.txt_CategoryName.TabIndex = 17;
			// 
			// txt_BrandName
			// 
			this.txt_BrandName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_BrandName.Location = new System.Drawing.Point(136, 122);
			this.txt_BrandName.Name = "txt_BrandName";
			this.txt_BrandName.ReadOnly = true;
			this.txt_BrandName.Size = new System.Drawing.Size(266, 29);
			this.txt_BrandName.TabIndex = 17;
			// 
			// form_ViewMerchandise
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(851, 474);
			this.Controls.Add(this.btn_AddSpec);
			this.Controls.Add(this.dataGridView_Spec);
			this.Controls.Add(this.pictureBox_Image);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btn_Edit);
			this.Controls.Add(this.txt_Description);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_MerchandiseId);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_BrandName);
			this.Controls.Add(this.txt_CategoryName);
			this.Controls.Add(this.txt_MerchandiseName);
			this.Controls.Add(this.label2);
			this.Name = "form_ViewMerchandise";
			this.Text = "商品管理：檢視商品";
			this.Load += new System.EventHandler(this.form_ViewMerchandise_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Spec)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_Image;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btn_Edit;
		private System.Windows.Forms.TextBox txt_Description;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_MerchandiseId;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_MerchandiseName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView_Spec;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn SpecName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
		private System.Windows.Forms.DataGridViewTextBoxColumn SpecId;
		private System.Windows.Forms.Button btn_AddSpec;
		private System.Windows.Forms.TextBox txt_CategoryName;
		private System.Windows.Forms.TextBox txt_BrandName;
	}
}