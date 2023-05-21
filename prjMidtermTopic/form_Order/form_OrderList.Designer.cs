namespace prjMidtermTopic.form_Order
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
			this.btn_EditListItem = new System.Windows.Forms.Button();
			this.btn_AddListItem = new System.Windows.Forms.Button();
			this.btn_DelteListItem = new System.Windows.Forms.Button();
			this.btn_DeleteOrder = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Main
			// 
			this.dataGridView_Main.AllowUserToAddRows = false;
			this.dataGridView_Main.AllowUserToDeleteRows = false;
			this.dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Main.Location = new System.Drawing.Point(57, 95);
			this.dataGridView_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView_Main.Name = "dataGridView_Main";
			this.dataGridView_Main.ReadOnly = true;
			this.dataGridView_Main.RowHeadersWidth = 51;
			this.dataGridView_Main.RowTemplate.Height = 27;
			this.dataGridView_Main.Size = new System.Drawing.Size(634, 358);
			this.dataGridView_Main.TabIndex = 0;
			this.dataGridView_Main.SelectionChanged += new System.EventHandler(this.dataGridView_Main_SelectionChanged);
			// 
			// btn_EditListItem
			// 
			this.btn_EditListItem.Location = new System.Drawing.Point(57, 30);
			this.btn_EditListItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_EditListItem.Name = "btn_EditListItem";
			this.btn_EditListItem.Size = new System.Drawing.Size(141, 38);
			this.btn_EditListItem.TabIndex = 1;
			this.btn_EditListItem.Text = "編輯項目";
			this.btn_EditListItem.UseVisualStyleBackColor = true;
			this.btn_EditListItem.Click += new System.EventHandler(this.btn_EditListItem_Click);
			// 
			// btn_AddListItem
			// 
			this.btn_AddListItem.Location = new System.Drawing.Point(293, 30);
			this.btn_AddListItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_AddListItem.Name = "btn_AddListItem";
			this.btn_AddListItem.Size = new System.Drawing.Size(141, 38);
			this.btn_AddListItem.TabIndex = 1;
			this.btn_AddListItem.Text = "添加項目";
			this.btn_AddListItem.UseVisualStyleBackColor = true;
			this.btn_AddListItem.Click += new System.EventHandler(this.btn_AddListItem_Click);
			// 
			// btn_DelteListItem
			// 
			this.btn_DelteListItem.Location = new System.Drawing.Point(538, 30);
			this.btn_DelteListItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_DelteListItem.Name = "btn_DelteListItem";
			this.btn_DelteListItem.Size = new System.Drawing.Size(141, 38);
			this.btn_DelteListItem.TabIndex = 1;
			this.btn_DelteListItem.Text = "刪除項目";
			this.btn_DelteListItem.UseVisualStyleBackColor = true;
			this.btn_DelteListItem.Click += new System.EventHandler(this.btn_DelteListItem_Click);
			// 
			// btn_DeleteOrder
			// 
			this.btn_DeleteOrder.Location = new System.Drawing.Point(550, 486);
			this.btn_DeleteOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_DeleteOrder.Name = "btn_DeleteOrder";
			this.btn_DeleteOrder.Size = new System.Drawing.Size(141, 38);
			this.btn_DeleteOrder.TabIndex = 1;
			this.btn_DeleteOrder.Text = "刪除此清單";
			this.btn_DeleteOrder.UseVisualStyleBackColor = true;
			this.btn_DeleteOrder.Click += new System.EventHandler(this.btn_DeleteOrder_Click);
			// 
			// form_OrderList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 552);
			this.Controls.Add(this.btn_DeleteOrder);
			this.Controls.Add(this.btn_DelteListItem);
			this.Controls.Add(this.btn_AddListItem);
			this.Controls.Add(this.btn_EditListItem);
			this.Controls.Add(this.dataGridView_Main);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "form_OrderList";
			this.Text = "formOrderList";
			this.Load += new System.EventHandler(this.form_OrderList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Main;
		private System.Windows.Forms.Button btn_EditListItem;
		private System.Windows.Forms.Button btn_AddListItem;
		private System.Windows.Forms.Button btn_DelteListItem;
		private System.Windows.Forms.Button btn_DeleteOrder;
	}
}