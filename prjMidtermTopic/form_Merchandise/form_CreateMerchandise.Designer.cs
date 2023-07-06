namespace prjMidtermTopic.form_Merchandise
{
	partial class form_CreateMerchandise
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
			this.btnCreate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_MerchandiseName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_Description = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_ImageURL = new System.Windows.Forms.TextBox();
			this.comboBox_CategoryId = new System.Windows.Forms.ComboBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btn_SelectImage = new System.Windows.Forms.Button();
			this.btn_CancelImage = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox_Image = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox_BrandId = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCreate.Location = new System.Drawing.Point(687, 302);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(99, 30);
			this.btnCreate.TabIndex = 7;
			this.btnCreate.Text = "新增商品";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(40, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 21);
			this.label3.TabIndex = 9;
			this.label3.Text = "商品類別：";
			// 
			// txt_MerchandiseName
			// 
			this.txt_MerchandiseName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MerchandiseName.Location = new System.Drawing.Point(135, 21);
			this.txt_MerchandiseName.Name = "txt_MerchandiseName";
			this.txt_MerchandiseName.Size = new System.Drawing.Size(266, 29);
			this.txt_MerchandiseName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(40, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 10;
			this.label2.Text = "商品名稱：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(40, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 21);
			this.label5.TabIndex = 9;
			this.label5.Text = "商品描述：";
			// 
			// txt_Description
			// 
			this.txt_Description.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_Description.Location = new System.Drawing.Point(135, 124);
			this.txt_Description.Multiline = true;
			this.txt_Description.Name = "txt_Description";
			this.txt_Description.Size = new System.Drawing.Size(266, 172);
			this.txt_Description.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(424, 235);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 21);
			this.label6.TabIndex = 9;
			this.label6.Text = "匯入圖片：";
			// 
			// txt_ImageURL
			// 
			this.txt_ImageURL.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_ImageURL.Location = new System.Drawing.Point(520, 232);
			this.txt_ImageURL.Name = "txt_ImageURL";
			this.txt_ImageURL.ReadOnly = true;
			this.txt_ImageURL.Size = new System.Drawing.Size(266, 29);
			this.txt_ImageURL.TabIndex = 12;
			// 
			// comboBox_CategoryId
			// 
			this.comboBox_CategoryId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox_CategoryId.FormattingEnabled = true;
			this.comboBox_CategoryId.Location = new System.Drawing.Point(135, 56);
			this.comboBox_CategoryId.Name = "comboBox_CategoryId";
			this.comboBox_CategoryId.Size = new System.Drawing.Size(266, 28);
			this.comboBox_CategoryId.TabIndex = 1;
			this.comboBox_CategoryId.SelectedIndexChanged += new System.EventHandler(this.comboBox_CategoryId_SelectedIndexChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btn_SelectImage
			// 
			this.btn_SelectImage.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_SelectImage.Location = new System.Drawing.Point(642, 267);
			this.btn_SelectImage.Name = "btn_SelectImage";
			this.btn_SelectImage.Size = new System.Drawing.Size(69, 23);
			this.btn_SelectImage.TabIndex = 5;
			this.btn_SelectImage.Text = "選擇圖片";
			this.btn_SelectImage.UseVisualStyleBackColor = true;
			this.btn_SelectImage.Click += new System.EventHandler(this.btn_SelectImage_Click);
			// 
			// btn_CancelImage
			// 
			this.btn_CancelImage.Enabled = false;
			this.btn_CancelImage.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_CancelImage.Location = new System.Drawing.Point(717, 267);
			this.btn_CancelImage.Name = "btn_CancelImage";
			this.btn_CancelImage.Size = new System.Drawing.Size(69, 23);
			this.btn_CancelImage.TabIndex = 6;
			this.btn_CancelImage.Text = "刪除選擇";
			this.btn_CancelImage.UseVisualStyleBackColor = true;
			this.btn_CancelImage.Click += new System.EventHandler(this.btn_CancelImage_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(424, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 21);
			this.label7.TabIndex = 13;
			this.label7.Text = "商品圖片：";
			// 
			// pictureBox_Image
			// 
			this.pictureBox_Image.Location = new System.Drawing.Point(520, 21);
			this.pictureBox_Image.Name = "pictureBox_Image";
			this.pictureBox_Image.Size = new System.Drawing.Size(266, 205);
			this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_Image.TabIndex = 14;
			this.pictureBox_Image.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(40, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 9;
			this.label1.Text = "商品品牌：";
			// 
			// comboBox_BrandId
			// 
			this.comboBox_BrandId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox_BrandId.FormattingEnabled = true;
			this.comboBox_BrandId.Location = new System.Drawing.Point(135, 90);
			this.comboBox_BrandId.Name = "comboBox_BrandId";
			this.comboBox_BrandId.Size = new System.Drawing.Size(266, 28);
			this.comboBox_BrandId.TabIndex = 1;
			this.comboBox_BrandId.SelectedIndexChanged += new System.EventHandler(this.comboBox_BrandId_SelectedIndexChanged);
			// 
			// form_CreateMerchandise
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 364);
			this.Controls.Add(this.pictureBox_Image);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btn_CancelImage);
			this.Controls.Add(this.btn_SelectImage);
			this.Controls.Add(this.comboBox_BrandId);
			this.Controls.Add(this.comboBox_CategoryId);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txt_ImageURL);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_Description);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_MerchandiseName);
			this.Controls.Add(this.label2);
			this.Name = "form_CreateMerchandise";
			this.Text = "商品管理：新增商品";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_MerchandiseName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_Description;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_ImageURL;
		private System.Windows.Forms.ComboBox comboBox_CategoryId;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btn_SelectImage;
		private System.Windows.Forms.Button btn_CancelImage;
		private System.Windows.Forms.PictureBox pictureBox_Image;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox_BrandId;
		private System.Windows.Forms.Label label1;
	}
}