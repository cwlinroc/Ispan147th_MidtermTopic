namespace prjMidtermTopic.Form_Order
{
	partial class Form_OrderListEdit
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
			this.btn_commit = new System.Windows.Forms.Button();
			this.txt_Quantity = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_MerchandiseID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_OrderID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_commit
			// 
			this.btn_commit.Location = new System.Drawing.Point(141, 208);
			this.btn_commit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_commit.Name = "btn_commit";
			this.btn_commit.Size = new System.Drawing.Size(164, 35);
			this.btn_commit.TabIndex = 5;
			this.btn_commit.Text = "確認修改";
			this.btn_commit.UseVisualStyleBackColor = true;
			this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
			// 
			// txt_Quantity
			// 
			this.txt_Quantity.Location = new System.Drawing.Point(141, 135);
			this.txt_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Quantity.Name = "txt_Quantity";
			this.txt_Quantity.Size = new System.Drawing.Size(235, 25);
			this.txt_Quantity.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(64, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 15);
			this.label3.TabIndex = 12;
			this.label3.Text = "數量";
			// 
			// txt_MerchandiseID
			// 
			this.txt_MerchandiseID.Location = new System.Drawing.Point(141, 106);
			this.txt_MerchandiseID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_MerchandiseID.Name = "txt_MerchandiseID";
			this.txt_MerchandiseID.Size = new System.Drawing.Size(235, 25);
			this.txt_MerchandiseID.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(64, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 13;
			this.label2.Text = "商品ID";
			// 
			// txt_OrderID
			// 
			this.txt_OrderID.Enabled = false;
			this.txt_OrderID.Location = new System.Drawing.Point(141, 74);
			this.txt_OrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_OrderID.Name = "txt_OrderID";
			this.txt_OrderID.Size = new System.Drawing.Size(235, 25);
			this.txt_OrderID.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 14;
			this.label1.Text = "訂單編號";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Form_OrderListEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 367);
			this.Controls.Add(this.txt_Quantity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_MerchandiseID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_OrderID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_commit);
			this.Name = "Form_OrderListEdit";
			this.Text = "Form_OrderEditOrderList";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_commit;
		private System.Windows.Forms.TextBox txt_Quantity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_MerchandiseID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_OrderID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}