namespace prjMidtermTopic.form_Merchandise
{
	partial class form_EditMerchandise
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
			this.btn_Update = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_MerchandiseName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_Description = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_ImageURL = new System.Windows.Forms.TextBox();
			this.comboBox_CategoryId = new System.Windows.Forms.ComboBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.txt_MerchandiseId = new System.Windows.Forms.TextBox();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_SelectNewImage = new System.Windows.Forms.Button();
			this.btn_DeleteImage = new System.Windows.Forms.Button();
			this.pictureBox_Image = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox_BrandId = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Update
			// 
			this.btn_Update.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Update.Location = new System.Drawing.Point(714, 328);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(95, 34);
			this.btn_Update.TabIndex = 7;
			this.btn_Update.Text = "更新商品";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(40, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 21);
			this.label3.TabIndex = 9;
			this.label3.Text = "商品類別：";
			// 
			// txt_MerchandiseName
			// 
			this.txt_MerchandiseName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MerchandiseName.Location = new System.Drawing.Point(135, 51);
			this.txt_MerchandiseName.Name = "txt_MerchandiseName";
			this.txt_MerchandiseName.Size = new System.Drawing.Size(266, 29);
			this.txt_MerchandiseName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(40, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 10;
			this.label2.Text = "商品名稱：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(40, 157);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 21);
			this.label5.TabIndex = 9;
			this.label5.Text = "商品描述：";
			// 
			// txt_Description
			// 
			this.txt_Description.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_Description.Location = new System.Drawing.Point(135, 154);
			this.txt_Description.Multiline = true;
			this.txt_Description.Name = "txt_Description";
			this.txt_Description.Size = new System.Drawing.Size(266, 172);
			this.txt_Description.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(448, 236);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 21);
			this.label6.TabIndex = 9;
			this.label6.Text = "匯入圖片：";
			// 
			// txt_ImageURL
			// 
			this.txt_ImageURL.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_ImageURL.Location = new System.Drawing.Point(543, 233);
			this.txt_ImageURL.Name = "txt_ImageURL";
			this.txt_ImageURL.ReadOnly = true;
			this.txt_ImageURL.Size = new System.Drawing.Size(266, 29);
			this.txt_ImageURL.TabIndex = 12;
			// 
			// comboBox_CategoryId
			// 
			this.comboBox_CategoryId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox_CategoryId.FormattingEnabled = true;
			this.comboBox_CategoryId.Location = new System.Drawing.Point(135, 86);
			this.comboBox_CategoryId.Name = "comboBox_CategoryId";
			this.comboBox_CategoryId.Size = new System.Drawing.Size(266, 28);
			this.comboBox_CategoryId.TabIndex = 1;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(40, 19);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 21);
			this.label7.TabIndex = 10;
			this.label7.Text = "商品編號：";
			// 
			// txt_MerchandiseId
			// 
			this.txt_MerchandiseId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MerchandiseId.Location = new System.Drawing.Point(135, 16);
			this.txt_MerchandiseId.Name = "txt_MerchandiseId";
			this.txt_MerchandiseId.ReadOnly = true;
			this.txt_MerchandiseId.Size = new System.Drawing.Size(266, 29);
			this.txt_MerchandiseId.TabIndex = 11;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Delete.Location = new System.Drawing.Point(613, 328);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(95, 34);
			this.btn_Delete.TabIndex = 8;
			this.btn_Delete.Text = "刪除商品";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_SelectNewImage
			// 
			this.btn_SelectNewImage.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_SelectNewImage.Location = new System.Drawing.Point(660, 268);
			this.btn_SelectNewImage.Name = "btn_SelectNewImage";
			this.btn_SelectNewImage.Size = new System.Drawing.Size(74, 23);
			this.btn_SelectNewImage.TabIndex = 5;
			this.btn_SelectNewImage.Text = "選擇新圖片";
			this.btn_SelectNewImage.UseVisualStyleBackColor = true;
			this.btn_SelectNewImage.Click += new System.EventHandler(this.btn_SelectNewImage_Click);
			// 
			// btn_DeleteImage
			// 
			this.btn_DeleteImage.Enabled = false;
			this.btn_DeleteImage.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_DeleteImage.Location = new System.Drawing.Point(740, 268);
			this.btn_DeleteImage.Name = "btn_DeleteImage";
			this.btn_DeleteImage.Size = new System.Drawing.Size(69, 23);
			this.btn_DeleteImage.TabIndex = 6;
			this.btn_DeleteImage.Text = "刪除圖片";
			this.btn_DeleteImage.UseVisualStyleBackColor = true;
			this.btn_DeleteImage.Click += new System.EventHandler(this.btn_DeleteImage_Click);
			// 
			// pictureBox_Image
			// 
			this.pictureBox_Image.Location = new System.Drawing.Point(543, 16);
			this.pictureBox_Image.Name = "pictureBox_Image";
			this.pictureBox_Image.Size = new System.Drawing.Size(266, 205);
			this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_Image.TabIndex = 16;
			this.pictureBox_Image.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(448, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 21);
			this.label8.TabIndex = 15;
			this.label8.Text = "商品圖片：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(40, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 9;
			this.label1.Text = "商品品牌：";
			// 
			// comboBox_BrandId
			// 
			this.comboBox_BrandId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox_BrandId.FormattingEnabled = true;
			this.comboBox_BrandId.Location = new System.Drawing.Point(135, 120);
			this.comboBox_BrandId.Name = "comboBox_BrandId";
			this.comboBox_BrandId.Size = new System.Drawing.Size(266, 28);
			this.comboBox_BrandId.TabIndex = 1;
			// 
			// form_EditMerchandise
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(851, 382);
			this.Controls.Add(this.pictureBox_Image);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btn_DeleteImage);
			this.Controls.Add(this.btn_SelectNewImage);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.comboBox_BrandId);
			this.Controls.Add(this.comboBox_CategoryId);
			this.Controls.Add(this.btn_Update);
			this.Controls.Add(this.txt_ImageURL);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_Description);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_MerchandiseId);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_MerchandiseName);
			this.Controls.Add(this.label2);
			this.Name = "form_EditMerchandise";
			this.Text = "商品管理：編輯商品";
			this.Load += new System.EventHandler(this.form_EditMerchandise_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_MerchandiseName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_Description;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_ImageURL;
		private System.Windows.Forms.ComboBox comboBox_CategoryId;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txt_MerchandiseId;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_SelectNewImage;
		private System.Windows.Forms.Button btn_DeleteImage;
		private System.Windows.Forms.PictureBox pictureBox_Image;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBox_BrandId;
		private System.Windows.Forms.Label label1;
	}
}