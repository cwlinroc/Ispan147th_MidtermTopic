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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Search
			// 
			this.btn_Search.Location = new System.Drawing.Point(328, 28);
			this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(93, 34);
			this.btn_Search.TabIndex = 1;
			this.btn_Search.Text = "搜尋";
			this.btn_Search.UseVisualStyleBackColor = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(590, 28);
			this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(93, 34);
			this.btn_Add.TabIndex = 4;
			this.btn_Add.Text = "新增訂單";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// txt_OrderID
			// 
			this.txt_OrderID.Location = new System.Drawing.Point(96, 35);
			this.txt_OrderID.Margin = new System.Windows.Forms.Padding(2);
			this.txt_OrderID.Name = "txt_OrderID";
			this.txt_OrderID.Size = new System.Drawing.Size(76, 22);
			this.txt_OrderID.TabIndex = 5;
			// 
			// txt_CustomerID
			// 
			this.txt_CustomerID.Location = new System.Drawing.Point(232, 35);
			this.txt_CustomerID.Margin = new System.Windows.Forms.Padding(2);
			this.txt_CustomerID.Name = "txt_CustomerID";
			this.txt_CustomerID.Size = new System.Drawing.Size(76, 22);
			this.txt_CustomerID.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 38);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "訂單編號";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(189, 38);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
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
			this.dataGridView_Main.Location = new System.Drawing.Point(37, 79);
			this.dataGridView_Main.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView_Main.Name = "dataGridView_Main";
			this.dataGridView_Main.ReadOnly = true;
			this.dataGridView_Main.RowHeadersWidth = 51;
			this.dataGridView_Main.RowTemplate.Height = 27;
			this.dataGridView_Main.Size = new System.Drawing.Size(650, 324);
			this.dataGridView_Main.TabIndex = 9;
			this.dataGridView_Main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Main_CellDoubleClick);
			this.dataGridView_Main.SelectionChanged += new System.EventHandler(this.dataGridView_Main_SelectionChanged);
			// 
			// btn_Edit
			// 
			this.btn_Edit.Location = new System.Drawing.Point(480, 27);
			this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Edit.Name = "btn_Edit";
			this.btn_Edit.Size = new System.Drawing.Size(93, 34);
			this.btn_Edit.TabIndex = 10;
			this.btn_Edit.Text = "修改訂單";
			this.btn_Edit.UseVisualStyleBackColor = true;
			this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
			// 
			// form_MerchandiseOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 437);
			this.Controls.Add(this.btn_Edit);
			this.Controls.Add(this.dataGridView_Main);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_CustomerID);
			this.Controls.Add(this.txt_OrderID);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.btn_Search);
			this.Margin = new System.Windows.Forms.Padding(2);
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
	}
}