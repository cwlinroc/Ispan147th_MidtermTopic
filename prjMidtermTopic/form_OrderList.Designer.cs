namespace prjMidtermTopic
{
	partial class form_OrderList
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
			this.dataGridView_Main = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Main
			// 
			this.dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Main.Location = new System.Drawing.Point(57, 95);
			this.dataGridView_Main.Name = "dataGridView_Main";
			this.dataGridView_Main.RowHeadersWidth = 51;
			this.dataGridView_Main.RowTemplate.Height = 27;
			this.dataGridView_Main.Size = new System.Drawing.Size(463, 357);
			this.dataGridView_Main.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(57, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 37);
			this.button1.TabIndex = 1;
			this.button1.Text = "編輯項目";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(214, 30);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(142, 37);
			this.button2.TabIndex = 1;
			this.button2.Text = "添加項目";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(378, 30);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(142, 37);
			this.button3.TabIndex = 1;
			this.button3.Text = "刪除項目";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(378, 484);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(142, 37);
			this.button4.TabIndex = 1;
			this.button4.Text = "刪除此清單";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// form_OrderList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 553);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView_Main);
			this.Name = "form_OrderList";
			this.Text = "formOrderList";
			this.Load += new System.EventHandler(this.form_OrderList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Main;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}