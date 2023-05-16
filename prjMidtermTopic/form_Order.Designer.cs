namespace prjMidtermTopic
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
			this.listView_Main = new System.Windows.Forms.ListView();
			this.btn_Search = new System.Windows.Forms.Button();
			this.btn_ShowList = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txt_OrderID = new System.Windows.Forms.TextBox();
			this.txt_CustomerID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listView_Main
			// 
			this.listView_Main.BackgroundImageTiled = true;
			this.listView_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.listView_Main.GridLines = true;
			this.listView_Main.HideSelection = false;
			this.listView_Main.Location = new System.Drawing.Point(91, 104);
			this.listView_Main.MultiSelect = false;
			this.listView_Main.Name = "listView_Main";
			this.listView_Main.ShowItemToolTips = true;
			this.listView_Main.Size = new System.Drawing.Size(824, 394);
			this.listView_Main.TabIndex = 0;
			this.listView_Main.UseCompatibleStateImageBehavior = false;
			this.listView_Main.View = System.Windows.Forms.View.Details;
			// 
			// btn_Search
			// 
			this.btn_Search.Location = new System.Drawing.Point(833, 26);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(134, 57);
			this.btn_Search.TabIndex = 1;
			this.btn_Search.Text = "搜尋";
			this.btn_Search.UseVisualStyleBackColor = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// btn_ShowList
			// 
			this.btn_ShowList.Location = new System.Drawing.Point(91, 520);
			this.btn_ShowList.Name = "btn_ShowList";
			this.btn_ShowList.Size = new System.Drawing.Size(134, 57);
			this.btn_ShowList.TabIndex = 2;
			this.btn_ShowList.Text = "顯示訂單詳情";
			this.btn_ShowList.UseVisualStyleBackColor = true;
			this.btn_ShowList.Click += new System.EventHandler(this.btn_ShowList_Click);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(767, 520);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(134, 57);
			this.btn_Delete.TabIndex = 3;
			this.btn_Delete.Text = "刪除訂單";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(434, 520);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(134, 57);
			this.btn_Add.TabIndex = 4;
			this.btn_Add.Text = "新增訂單";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "訂單編號";
			this.columnHeader1.Width = 120;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "顧客ID";
			this.columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "付款方式";
			this.columnHeader3.Width = 120;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "成功付款";
			this.columnHeader4.Width = 120;
			// 
			// txt_OrderID
			// 
			this.txt_OrderID.Location = new System.Drawing.Point(231, 44);
			this.txt_OrderID.Name = "txt_OrderID";
			this.txt_OrderID.Size = new System.Drawing.Size(100, 25);
			this.txt_OrderID.TabIndex = 5;
			// 
			// txt_CustomerID
			// 
			this.txt_CustomerID.Location = new System.Drawing.Point(515, 44);
			this.txt_CustomerID.Name = "txt_CustomerID";
			this.txt_CustomerID.Size = new System.Drawing.Size(100, 25);
			this.txt_CustomerID.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(97, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "訂單編號";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(394, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "顧客ID";
			// 
			// form_MerchandiseOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 589);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_CustomerID);
			this.Controls.Add(this.txt_OrderID);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_ShowList);
			this.Controls.Add(this.btn_Search);
			this.Controls.Add(this.listView_Main);
			this.Name = "form_MerchandiseOrder";
			this.Text = "訂單管理";
			this.Load += new System.EventHandler(this.form_MerchandiseOrder_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Main;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ShowList;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TextBox txt_OrderID;
		private System.Windows.Forms.TextBox txt_CustomerID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}