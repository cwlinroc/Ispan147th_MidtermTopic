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
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(307, 339);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 13;
			this.btnCreate.Text = "新增商品";
			this.btnCreate.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "商品類別：";
			// 
			// txt_MerchandiseName
			// 
			this.txt_MerchandiseName.Location = new System.Drawing.Point(116, 21);
			this.txt_MerchandiseName.Name = "txt_MerchandiseName";
			this.txt_MerchandiseName.Size = new System.Drawing.Size(266, 22);
			this.txt_MerchandiseName.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 10;
			this.label2.Text = "商品名稱：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "價格：";
			// 
			// txt_Price
			// 
			this.txt_Price.Location = new System.Drawing.Point(116, 77);
			this.txt_Price.Name = "txt_Price";
			this.txt_Price.Size = new System.Drawing.Size(266, 22);
			this.txt_Price.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 9;
			this.label4.Text = "庫存數量：";
			// 
			// txt_Amount
			// 
			this.txt_Amount.Location = new System.Drawing.Point(116, 105);
			this.txt_Amount.Name = "txt_Amount";
			this.txt_Amount.Size = new System.Drawing.Size(266, 22);
			this.txt_Amount.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 12);
			this.label5.TabIndex = 9;
			this.label5.Text = "商品描述：";
			// 
			// txt_Description
			// 
			this.txt_Description.Location = new System.Drawing.Point(116, 133);
			this.txt_Description.Multiline = true;
			this.txt_Description.Name = "txt_Description";
			this.txt_Description.Size = new System.Drawing.Size(266, 172);
			this.txt_Description.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(40, 314);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 12);
			this.label6.TabIndex = 9;
			this.label6.Text = "商品圖片：";
			// 
			// txt_ImageURL
			// 
			this.txt_ImageURL.Location = new System.Drawing.Point(116, 311);
			this.txt_ImageURL.Name = "txt_ImageURL";
			this.txt_ImageURL.Size = new System.Drawing.Size(266, 22);
			this.txt_ImageURL.TabIndex = 12;
			// 
			// comboBox_CategoryId
			// 
			this.comboBox_CategoryId.FormattingEnabled = true;
			this.comboBox_CategoryId.Location = new System.Drawing.Point(116, 50);
			this.comboBox_CategoryId.Name = "comboBox_CategoryId";
			this.comboBox_CategoryId.Size = new System.Drawing.Size(266, 20);
			this.comboBox_CategoryId.TabIndex = 14;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// form_EditMerchandise
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 392);
			this.Controls.Add(this.comboBox_CategoryId);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txt_ImageURL);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_Description);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_Amount);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_Price);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_MerchandiseName);
			this.Controls.Add(this.label2);
			this.Name = "form_EditMerchandise";
			this.Text = "商品管理：新增商品";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCreate;
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
	}
}