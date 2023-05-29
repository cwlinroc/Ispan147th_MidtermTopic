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
			this.btn_Updata = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_MerchandiseName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Price = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_Amount = new System.Windows.Forms.TextBox();
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
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Updata
			// 
			this.btn_Updata.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Updata.Location = new System.Drawing.Point(287, 396);
			this.btn_Updata.Name = "btn_Updata";
			this.btn_Updata.Size = new System.Drawing.Size(95, 34);
			this.btn_Updata.TabIndex = 13;
			this.btn_Updata.Text = "更新商品";
			this.btn_Updata.UseVisualStyleBackColor = true;
			this.btn_Updata.Click += new System.EventHandler(this.btn_Updata_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "商品類別：";
			// 
			// txt_MerchandiseName
			// 
			this.txt_MerchandiseName.Location = new System.Drawing.Point(116, 44);
			this.txt_MerchandiseName.Name = "txt_MerchandiseName";
			this.txt_MerchandiseName.Size = new System.Drawing.Size(266, 22);
			this.txt_MerchandiseName.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 10;
			this.label2.Text = "商品名稱：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "價格：";
			// 
			// txt_Price
			// 
			this.txt_Price.Location = new System.Drawing.Point(116, 100);
			this.txt_Price.Name = "txt_Price";
			this.txt_Price.Size = new System.Drawing.Size(266, 22);
			this.txt_Price.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 9;
			this.label4.Text = "庫存數量：";
			// 
			// txt_Amount
			// 
			this.txt_Amount.Location = new System.Drawing.Point(116, 128);
			this.txt_Amount.Name = "txt_Amount";
			this.txt_Amount.Size = new System.Drawing.Size(266, 22);
			this.txt_Amount.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 12);
			this.label5.TabIndex = 9;
			this.label5.Text = "商品描述：";
			// 
			// txt_Description
			// 
			this.txt_Description.Location = new System.Drawing.Point(116, 156);
			this.txt_Description.Multiline = true;
			this.txt_Description.Name = "txt_Description";
			this.txt_Description.Size = new System.Drawing.Size(266, 172);
			this.txt_Description.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(40, 337);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 12);
			this.label6.TabIndex = 9;
			this.label6.Text = "商品圖片：";
			// 
			// txt_ImageURL
			// 
			this.txt_ImageURL.Location = new System.Drawing.Point(116, 334);
			this.txt_ImageURL.Name = "txt_ImageURL";
			this.txt_ImageURL.ReadOnly = true;
			this.txt_ImageURL.Size = new System.Drawing.Size(266, 22);
			this.txt_ImageURL.TabIndex = 12;
			// 
			// comboBox_CategoryId
			// 
			this.comboBox_CategoryId.FormattingEnabled = true;
			this.comboBox_CategoryId.Location = new System.Drawing.Point(116, 73);
			this.comboBox_CategoryId.Name = "comboBox_CategoryId";
			this.comboBox_CategoryId.Size = new System.Drawing.Size(266, 20);
			this.comboBox_CategoryId.TabIndex = 14;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(40, 19);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 12);
			this.label7.TabIndex = 10;
			this.label7.Text = "商品編號：";
			// 
			// txt_MerchandiseId
			// 
			this.txt_MerchandiseId.Location = new System.Drawing.Point(116, 16);
			this.txt_MerchandiseId.Name = "txt_MerchandiseId";
			this.txt_MerchandiseId.ReadOnly = true;
			this.txt_MerchandiseId.Size = new System.Drawing.Size(266, 22);
			this.txt_MerchandiseId.TabIndex = 11;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Delete.Location = new System.Drawing.Point(287, 436);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(95, 34);
			this.btn_Delete.TabIndex = 15;
			this.btn_Delete.Text = "刪除商品";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_SelectNewImage
			// 
			this.btn_SelectNewImage.Location = new System.Drawing.Point(233, 362);
			this.btn_SelectNewImage.Name = "btn_SelectNewImage";
			this.btn_SelectNewImage.Size = new System.Drawing.Size(74, 23);
			this.btn_SelectNewImage.TabIndex = 16;
			this.btn_SelectNewImage.Text = "選擇新圖片";
			this.btn_SelectNewImage.UseVisualStyleBackColor = true;
			this.btn_SelectNewImage.Click += new System.EventHandler(this.btn_SelectNewImage_Click);
			// 
			// btn_DeleteImage
			// 
			this.btn_DeleteImage.Enabled = false;
			this.btn_DeleteImage.Location = new System.Drawing.Point(313, 362);
			this.btn_DeleteImage.Name = "btn_DeleteImage";
			this.btn_DeleteImage.Size = new System.Drawing.Size(69, 23);
			this.btn_DeleteImage.TabIndex = 17;
			this.btn_DeleteImage.Text = "刪除圖片";
			this.btn_DeleteImage.UseVisualStyleBackColor = true;
			this.btn_DeleteImage.Click += new System.EventHandler(this.btn_DeleteImage_Click);
			// 
			// form_EditMerchandise
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 488);
			this.Controls.Add(this.btn_DeleteImage);
			this.Controls.Add(this.btn_SelectNewImage);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.comboBox_CategoryId);
			this.Controls.Add(this.btn_Updata);
			this.Controls.Add(this.txt_ImageURL);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_Description);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_Amount);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_Price);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_MerchandiseId);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_MerchandiseName);
			this.Controls.Add(this.label2);
			this.Name = "form_EditMerchandise";
			this.Text = "商品管理：編輯商品";
			this.Load += new System.EventHandler(this.form_EditMerchandise_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Updata;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_MerchandiseName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Price;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_Amount;
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
	}
}