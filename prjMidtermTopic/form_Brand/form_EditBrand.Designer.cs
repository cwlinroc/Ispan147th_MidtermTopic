namespace prjMidtermTopic.form_Brand
{
	partial class form_EditBrand
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
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.txt_BrandId = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_BrandName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Delete
			// 
			this.btn_Delete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Delete.Location = new System.Drawing.Point(256, 145);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(94, 38);
			this.btn_Delete.TabIndex = 16;
			this.btn_Delete.Text = "刪除品牌";
			this.btn_Delete.UseVisualStyleBackColor = true;
			// 
			// btn_Update
			// 
			this.btn_Update.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Update.Location = new System.Drawing.Point(256, 101);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(94, 38);
			this.btn_Update.TabIndex = 15;
			this.btn_Update.Text = "儲存更新";
			this.btn_Update.UseVisualStyleBackColor = true;
			// 
			// txt_BrandId
			// 
			this.txt_BrandId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_BrandId.Location = new System.Drawing.Point(112, 18);
			this.txt_BrandId.Name = "txt_BrandId";
			this.txt_BrandId.ReadOnly = true;
			this.txt_BrandId.Size = new System.Drawing.Size(238, 29);
			this.txt_BrandId.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(21, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 21);
			this.label7.TabIndex = 18;
			this.label7.Text = "品牌編號：";
			// 
			// txt_BrandName
			// 
			this.txt_BrandName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_BrandName.Location = new System.Drawing.Point(112, 53);
			this.txt_BrandName.Name = "txt_BrandName";
			this.txt_BrandName.Size = new System.Drawing.Size(238, 29);
			this.txt_BrandName.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(21, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 19;
			this.label2.Text = "品牌名稱：";
			// 
			// form_EditBrand
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 199);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Update);
			this.Controls.Add(this.txt_BrandId);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_BrandName);
			this.Controls.Add(this.label2);
			this.Name = "form_EditBrand";
			this.Text = "商品管理：編輯品牌名稱";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.TextBox txt_BrandId;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_BrandName;
		private System.Windows.Forms.Label label2;
	}
}