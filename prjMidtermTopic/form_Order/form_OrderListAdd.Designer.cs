namespace prjMidtermTopic.Form_Order
{
	partial class form_OrderListAdd
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
			this.txt_MerchandiseID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_OrderID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_commit = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Quantity = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_MerchandiseID
			// 
			this.txt_MerchandiseID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MerchandiseID.Location = new System.Drawing.Point(123, 62);
			this.txt_MerchandiseID.Margin = new System.Windows.Forms.Padding(2);
			this.txt_MerchandiseID.Name = "txt_MerchandiseID";
			this.txt_MerchandiseID.Size = new System.Drawing.Size(177, 29);
			this.txt_MerchandiseID.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(29, 64);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 21);
			this.label2.TabIndex = 8;
			this.label2.Text = "商品ID：";
			// 
			// txt_OrderID
			// 
			this.txt_OrderID.Enabled = false;
			this.txt_OrderID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_OrderID.Location = new System.Drawing.Point(123, 29);
			this.txt_OrderID.Margin = new System.Windows.Forms.Padding(2);
			this.txt_OrderID.Name = "txt_OrderID";
			this.txt_OrderID.Size = new System.Drawing.Size(177, 29);
			this.txt_OrderID.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(29, 32);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 9;
			this.label1.Text = "訂單編號：";
			// 
			// btn_commit
			// 
			this.btn_commit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_commit.Location = new System.Drawing.Point(102, 148);
			this.btn_commit.Margin = new System.Windows.Forms.Padding(2);
			this.btn_commit.Name = "btn_commit";
			this.btn_commit.Size = new System.Drawing.Size(123, 28);
			this.btn_commit.TabIndex = 5;
			this.btn_commit.Text = "確認新增";
			this.btn_commit.UseVisualStyleBackColor = true;
			this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(29, 97);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 21);
			this.label3.TabIndex = 8;
			this.label3.Text = "數量：";
			// 
			// txt_Quantity
			// 
			this.txt_Quantity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_Quantity.Location = new System.Drawing.Point(123, 95);
			this.txt_Quantity.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Quantity.Name = "txt_Quantity";
			this.txt_Quantity.Size = new System.Drawing.Size(177, 29);
			this.txt_Quantity.TabIndex = 10;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// form_OrderListAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 197);
			this.Controls.Add(this.txt_Quantity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_MerchandiseID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_OrderID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_commit);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "form_OrderListAdd";
			this.Text = "新增細項";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txt_MerchandiseID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_OrderID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_commit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_Quantity;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}