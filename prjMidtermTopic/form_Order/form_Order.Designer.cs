namespace prjMidtermTopic.form_Order
{
    partial class form_MerchandiseOrder
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
			this.btn_Search = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.txt_OrderID = new System.Windows.Forms.TextBox();
			this.txt_CustomerID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView_Main = new System.Windows.Forms.DataGridView();
			this.btn_Edit = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Search
			// 
			this.btn_Search.Location = new System.Drawing.Point(437, 35);
			this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(124, 42);
			this.btn_Search.TabIndex = 1;
			this.btn_Search.Text = "搜尋";
			this.btn_Search.UseVisualStyleBackColor = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(787, 35);
			this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(124, 42);
			this.btn_Add.TabIndex = 4;
			this.btn_Add.Text = "新增訂單";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// txt_OrderID
			// 
			this.txt_OrderID.Location = new System.Drawing.Point(128, 44);
			this.txt_OrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_OrderID.Name = "txt_OrderID";
			this.txt_OrderID.Size = new System.Drawing.Size(100, 25);
			this.txt_OrderID.TabIndex = 5;
			// 
			// txt_CustomerID
			// 
			this.txt_CustomerID.Location = new System.Drawing.Point(309, 44);
			this.txt_CustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_CustomerID.Name = "txt_CustomerID";
			this.txt_CustomerID.Size = new System.Drawing.Size(100, 25);
			this.txt_CustomerID.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "訂單編號";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(252, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "顧客ID";
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
            this.Column4});
			this.dataGridView_Main.Location = new System.Drawing.Point(49, 99);
			this.dataGridView_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView_Main.Name = "dataGridView_Main";
			this.dataGridView_Main.ReadOnly = true;
			this.dataGridView_Main.RowHeadersWidth = 51;
			this.dataGridView_Main.RowTemplate.Height = 27;
			this.dataGridView_Main.Size = new System.Drawing.Size(867, 405);
			this.dataGridView_Main.TabIndex = 9;
			this.dataGridView_Main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Main_CellDoubleClick);
			this.dataGridView_Main.SelectionChanged += new System.EventHandler(this.dataGridView_Main_SelectionChanged);
			// 
			// btn_Edit
			// 
			this.btn_Edit.Location = new System.Drawing.Point(640, 34);
			this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Edit.Name = "btn_Edit";
			this.btn_Edit.Size = new System.Drawing.Size(124, 42);
			this.btn_Edit.TabIndex = 10;
			this.btn_Edit.Text = "修改訂單";
			this.btn_Edit.UseVisualStyleBackColor = true;
			this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "ID";
			this.Column1.HeaderText = "編號";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "CustomerID";
			this.Column2.HeaderText = "顧客編號";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "PaymentMethod";
			this.Column3.HeaderText = "付款方式";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Payed";
			this.Column4.HeaderText = "付款完畢";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 125;
			// 
			// form_MerchandiseOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(979, 546);
			this.Controls.Add(this.btn_Edit);
			this.Controls.Add(this.dataGridView_Main);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_CustomerID);
			this.Controls.Add(this.txt_OrderID);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.btn_Search);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "form_MerchandiseOrder";
			this.Text = "訂單管理";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_MerchandiseOrder_FormClosed);
			this.Load += new System.EventHandler(this.form_MerchandiseOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.TextBox txt_OrderID;
		private System.Windows.Forms.TextBox txt_CustomerID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView_Main;
		private System.Windows.Forms.Button btn_Edit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
	}
}