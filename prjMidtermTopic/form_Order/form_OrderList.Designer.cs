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
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.dataGridView_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
			this.dataGridView_Main.Location = new System.Drawing.Point(57, 95);
			this.dataGridView_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView_Main.Name = "dataGridView_Main";
			this.dataGridView_Main.ReadOnly = true;
			this.dataGridView_Main.RowHeadersWidth = 51;
			this.dataGridView_Main.RowTemplate.Height = 27;
			this.dataGridView_Main.Size = new System.Drawing.Size(1066, 358);
			this.dataGridView_Main.TabIndex = 0;
			this.dataGridView_Main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Main_CellDoubleClick);
			this.dataGridView_Main.SelectionChanged += new System.EventHandler(this.dataGridView_Main_SelectionChanged);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "OrderListID";
			this.Column1.HeaderText = "訂單明細編號";
			this.Column1.MinimumWidth = 40;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "OrderID";
			this.Column2.HeaderText = "訂單編號";
			this.Column2.MinimumWidth = 40;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "MerchandiseID";
			this.Column3.HeaderText = "商品編號";
			this.Column3.MinimumWidth = 40;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 125;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "MerchandiseName";
			this.Column5.HeaderText = "商品名稱";
			this.Column5.MinimumWidth = 40;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 150;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Quantity";
			this.Column4.HeaderText = "數量";
			this.Column4.MinimumWidth = 40;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 125;
			// 
			// btn_EditListItem
			// 
			this.btn_EditListItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_EditListItem.Location = new System.Drawing.Point(807, 30);
			this.btn_EditListItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_EditListItem.Name = "btn_EditListItem";
			this.btn_EditListItem.Size = new System.Drawing.Size(141, 38);
			this.btn_EditListItem.TabIndex = 1;
			this.btn_EditListItem.Text = "修改項目";
			this.btn_EditListItem.UseVisualStyleBackColor = true;
			this.btn_EditListItem.Click += new System.EventHandler(this.btn_EditListItem_Click);
			// 
			// btn_AddListItem
			// 
			this.btn_AddListItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddListItem.Location = new System.Drawing.Point(982, 30);
			this.btn_AddListItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_AddListItem.Name = "btn_AddListItem";
			this.btn_AddListItem.Size = new System.Drawing.Size(141, 38);
			this.btn_AddListItem.TabIndex = 1;
			this.btn_AddListItem.Text = "新增項目";
			this.btn_AddListItem.UseVisualStyleBackColor = true;
			this.btn_AddListItem.Click += new System.EventHandler(this.btn_AddListItem_Click);
			// 
			// btn_DelteListItem
			// 
			this.btn_DelteListItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_DelteListItem.Location = new System.Drawing.Point(807, 486);
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
			this.btn_DeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_DeleteOrder.Location = new System.Drawing.Point(982, 486);
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
			this.ClientSize = new System.Drawing.Size(1168, 552);
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
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
	}
}