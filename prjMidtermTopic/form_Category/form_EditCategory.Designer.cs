namespace prjMidtermTopic.form_Category
{
	partial class form_EditCategory
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
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.txt_CategoryId = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_CategoryName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// txt_CategoryId
			// 
			this.txt_CategoryId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_CategoryId.Location = new System.Drawing.Point(112, 18);
			this.txt_CategoryId.Name = "txt_CategoryId";
			this.txt_CategoryId.ReadOnly = true;
			this.txt_CategoryId.Size = new System.Drawing.Size(238, 29);
			this.txt_CategoryId.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(21, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 21);
			this.label7.TabIndex = 12;
			this.label7.Text = "類別編號：";
			// 
			// txt_CategoryName
			// 
			this.txt_CategoryName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_CategoryName.Location = new System.Drawing.Point(112, 53);
			this.txt_CategoryName.Name = "txt_CategoryName";
			this.txt_CategoryName.Size = new System.Drawing.Size(238, 29);
			this.txt_CategoryName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(21, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 13;
			this.label2.Text = "類別名稱：";
			// 
			// btn_Delete
			// 
			this.btn_Delete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Delete.Location = new System.Drawing.Point(256, 145);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(94, 38);
			this.btn_Delete.TabIndex = 2;
			this.btn_Delete.Text = "刪除類別";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Update
			// 
			this.btn_Update.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Update.Location = new System.Drawing.Point(256, 101);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(94, 38);
			this.btn_Update.TabIndex = 1;
			this.btn_Update.Text = "儲存更新";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// form_EditCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 199);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Update);
			this.Controls.Add(this.txt_CategoryId);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_CategoryName);
			this.Controls.Add(this.label2);
			this.Name = "form_EditCategory";
			this.Text = "商品管理：編輯類別名稱";
			this.Load += new System.EventHandler(this.form_EditCategory_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txt_CategoryId;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_CategoryName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Update;
	}
}