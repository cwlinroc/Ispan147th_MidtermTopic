namespace prjMidtermTopic.form_Spec
{
	partial class form_CreateSpec
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
			this.btn_Add = new System.Windows.Forms.Button();
			this.txt_MerchandiseName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_SpecName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Price = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_Amount = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Add
			// 
			this.btn_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Add.Location = new System.Drawing.Point(371, 178);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(115, 37);
			this.btn_Add.TabIndex = 22;
			this.btn_Add.Text = "新增商品規格";
			this.btn_Add.UseVisualStyleBackColor = true;
			// 
			// txt_MerchandiseName
			// 
			this.txt_MerchandiseName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MerchandiseName.Location = new System.Drawing.Point(124, 22);
			this.txt_MerchandiseName.Name = "txt_MerchandiseName";
			this.txt_MerchandiseName.ReadOnly = true;
			this.txt_MerchandiseName.Size = new System.Drawing.Size(362, 29);
			this.txt_MerchandiseName.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(28, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 21);
			this.label2.TabIndex = 23;
			this.label2.Text = "商品名稱：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(28, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 23;
			this.label1.Text = "規格名稱：";
			// 
			// txt_SpecName
			// 
			this.txt_SpecName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_SpecName.Location = new System.Drawing.Point(124, 57);
			this.txt_SpecName.Name = "txt_SpecName";
			this.txt_SpecName.Size = new System.Drawing.Size(362, 29);
			this.txt_SpecName.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(28, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 21);
			this.label3.TabIndex = 23;
			this.label3.Text = "單位價格：";
			// 
			// txt_Price
			// 
			this.txt_Price.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_Price.Location = new System.Drawing.Point(124, 92);
			this.txt_Price.Name = "txt_Price";
			this.txt_Price.Size = new System.Drawing.Size(362, 29);
			this.txt_Price.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(28, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 21);
			this.label4.TabIndex = 23;
			this.label4.Text = "庫存數量：";
			// 
			// txt_Amount
			// 
			this.txt_Amount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_Amount.Location = new System.Drawing.Point(124, 127);
			this.txt_Amount.Name = "txt_Amount";
			this.txt_Amount.Size = new System.Drawing.Size(362, 29);
			this.txt_Amount.TabIndex = 21;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// form_CreateSpec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 246);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.txt_Amount);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_Price);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_SpecName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_MerchandiseName);
			this.Controls.Add(this.label2);
			this.Name = "form_CreateSpec";
			this.Text = "商品管理：新增商品規格";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.TextBox txt_MerchandiseName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_SpecName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_Price;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_Amount;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}