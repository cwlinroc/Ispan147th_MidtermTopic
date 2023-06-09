﻿namespace prjMidtermTopic.Form_Order
{
    partial class form_Orders
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
			this.txt_MemberID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView_Main = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_Edit = new System.Windows.Forms.Button();
			this.txt_MemberName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox_PurchaseTime = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox_Payed = new System.Windows.Forms.ComboBox();
			this.txt_MaxPaymentAmount = new System.Windows.Forms.TextBox();
			this.txt_MinPaymentAmount = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox_PaymentMethod = new System.Windows.Forms.ComboBox();
			this.btn_ClearSearch = new System.Windows.Forms.Button();
			this.checkBox_MaxData = new System.Windows.Forms.CheckBox();
			this.comboBox_SortBy = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_MaxQuery = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.checkBox_desc = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Search
			// 
			this.btn_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Search.Location = new System.Drawing.Point(1121, 21);
			this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(100, 30);
			this.btn_Search.TabIndex = 12;
			this.btn_Search.Text = "搜尋";
			this.btn_Search.UseVisualStyleBackColor = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Add.Location = new System.Drawing.Point(153, 464);
			this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(100, 30);
			this.btn_Add.TabIndex = 15;
			this.btn_Add.Text = "新增訂單";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// txt_OrderID
			// 
			this.txt_OrderID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_OrderID.Location = new System.Drawing.Point(127, 22);
			this.txt_OrderID.Margin = new System.Windows.Forms.Padding(2);
			this.txt_OrderID.Name = "txt_OrderID";
			this.txt_OrderID.Size = new System.Drawing.Size(100, 29);
			this.txt_OrderID.TabIndex = 0;
			// 
			// txt_MemberID
			// 
			this.txt_MemberID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MemberID.Location = new System.Drawing.Point(332, 22);
			this.txt_MemberID.Margin = new System.Windows.Forms.Padding(2);
			this.txt_MemberID.Name = "txt_MemberID";
			this.txt_MemberID.Size = new System.Drawing.Size(82, 29);
			this.txt_MemberID.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(33, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 7;
			this.label1.Text = "訂單編號：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(237, 26);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 21);
			this.label2.TabIndex = 8;
			this.label2.Text = "顧客ID：";
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
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column7});
			this.dataGridView_Main.Location = new System.Drawing.Point(37, 129);
			this.dataGridView_Main.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView_Main.Name = "dataGridView_Main";
			this.dataGridView_Main.ReadOnly = true;
			this.dataGridView_Main.RowHeadersWidth = 51;
			this.dataGridView_Main.RowTemplate.Height = 27;
			this.dataGridView_Main.Size = new System.Drawing.Size(1194, 318);
			this.dataGridView_Main.TabIndex = 9;
			this.dataGridView_Main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Main_CellDoubleClick);
			this.dataGridView_Main.SelectionChanged += new System.EventHandler(this.dataGridView_Main_SelectionChanged);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "OrderID";
			this.Column1.HeaderText = "編號";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "MemberID";
			this.Column2.HeaderText = "顧客編號";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "MemberName";
			this.Column5.HeaderText = "顧客姓名";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 125;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "PurchaseTime";
			this.Column6.HeaderText = "購買時間";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 125;
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
			// Column7
			// 
			this.Column7.DataPropertyName = "PaymentAmount";
			this.Column7.HeaderText = "實付金額";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 125;
			// 
			// btn_Edit
			// 
			this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Edit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_Edit.Location = new System.Drawing.Point(35, 464);
			this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Edit.Name = "btn_Edit";
			this.btn_Edit.Size = new System.Drawing.Size(100, 30);
			this.btn_Edit.TabIndex = 14;
			this.btn_Edit.Text = "修改訂單";
			this.btn_Edit.UseVisualStyleBackColor = true;
			this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
			// 
			// txt_MemberName
			// 
			this.txt_MemberName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MemberName.Location = new System.Drawing.Point(332, 68);
			this.txt_MemberName.Margin = new System.Windows.Forms.Padding(2);
			this.txt_MemberName.Name = "txt_MemberName";
			this.txt_MemberName.Size = new System.Drawing.Size(82, 29);
			this.txt_MemberName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(237, 72);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 21);
			this.label3.TabIndex = 8;
			this.label3.Text = "顧客姓名：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(33, 72);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 21);
			this.label4.TabIndex = 8;
			this.label4.Text = "購買時間：";
			// 
			// comboBox_PurchaseTime
			// 
			this.comboBox_PurchaseTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox_PurchaseTime.FormattingEnabled = true;
			this.comboBox_PurchaseTime.Items.AddRange(new object[] {
            "一個星期內",
            "一個月內",
            "三個月內",
            "一年內",
            "不限制"});
			this.comboBox_PurchaseTime.Location = new System.Drawing.Point(127, 68);
			this.comboBox_PurchaseTime.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox_PurchaseTime.Name = "comboBox_PurchaseTime";
			this.comboBox_PurchaseTime.Size = new System.Drawing.Size(100, 28);
			this.comboBox_PurchaseTime.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(429, 72);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 21);
			this.label5.TabIndex = 8;
			this.label5.Text = "付款完畢：";
			// 
			// comboBox_Payed
			// 
			this.comboBox_Payed.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox_Payed.FormattingEnabled = true;
			this.comboBox_Payed.Items.AddRange(new object[] {
            "已付款",
            "尚未付款"});
			this.comboBox_Payed.Location = new System.Drawing.Point(523, 68);
			this.comboBox_Payed.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox_Payed.Name = "comboBox_Payed";
			this.comboBox_Payed.Size = new System.Drawing.Size(96, 28);
			this.comboBox_Payed.TabIndex = 5;
			// 
			// txt_MaxPaymentAmount
			// 
			this.txt_MaxPaymentAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MaxPaymentAmount.Location = new System.Drawing.Point(730, 68);
			this.txt_MaxPaymentAmount.Margin = new System.Windows.Forms.Padding(2);
			this.txt_MaxPaymentAmount.Name = "txt_MaxPaymentAmount";
			this.txt_MaxPaymentAmount.Size = new System.Drawing.Size(92, 29);
			this.txt_MaxPaymentAmount.TabIndex = 7;
			// 
			// txt_MinPaymentAmount
			// 
			this.txt_MinPaymentAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MinPaymentAmount.Location = new System.Drawing.Point(730, 22);
			this.txt_MinPaymentAmount.Margin = new System.Windows.Forms.Padding(2);
			this.txt_MinPaymentAmount.Name = "txt_MinPaymentAmount";
			this.txt_MinPaymentAmount.Size = new System.Drawing.Size(92, 29);
			this.txt_MinPaymentAmount.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(636, 26);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 21);
			this.label6.TabIndex = 8;
			this.label6.Text = "最小金額：";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(636, 72);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 21);
			this.label7.TabIndex = 8;
			this.label7.Text = "最大金額：";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(429, 26);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 21);
			this.label8.TabIndex = 8;
			this.label8.Text = "付款方式：";
			// 
			// comboBox_PaymentMethod
			// 
			this.comboBox_PaymentMethod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox_PaymentMethod.FormattingEnabled = true;
			this.comboBox_PaymentMethod.Location = new System.Drawing.Point(523, 22);
			this.comboBox_PaymentMethod.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox_PaymentMethod.Name = "comboBox_PaymentMethod";
			this.comboBox_PaymentMethod.Size = new System.Drawing.Size(96, 28);
			this.comboBox_PaymentMethod.TabIndex = 4;
			// 
			// btn_ClearSearch
			// 
			this.btn_ClearSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_ClearSearch.Location = new System.Drawing.Point(1121, 67);
			this.btn_ClearSearch.Margin = new System.Windows.Forms.Padding(2);
			this.btn_ClearSearch.Name = "btn_ClearSearch";
			this.btn_ClearSearch.Size = new System.Drawing.Size(100, 30);
			this.btn_ClearSearch.TabIndex = 13;
			this.btn_ClearSearch.Text = "條件清空";
			this.btn_ClearSearch.UseVisualStyleBackColor = true;
			this.btn_ClearSearch.Click += new System.EventHandler(this.btn_ClearSearch_Click);
			// 
			// checkBox_MaxData
			// 
			this.checkBox_MaxData.AutoSize = true;
			this.checkBox_MaxData.Checked = true;
			this.checkBox_MaxData.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_MaxData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.checkBox_MaxData.Location = new System.Drawing.Point(840, 24);
			this.checkBox_MaxData.Name = "checkBox_MaxData";
			this.checkBox_MaxData.Size = new System.Drawing.Size(93, 25);
			this.checkBox_MaxData.TabIndex = 8;
			this.checkBox_MaxData.Text = "最多顯示";
			this.checkBox_MaxData.UseVisualStyleBackColor = true;
			// 
			// comboBox_SortBy
			// 
			this.comboBox_SortBy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox_SortBy.FormattingEnabled = true;
			this.comboBox_SortBy.Location = new System.Drawing.Point(935, 68);
			this.comboBox_SortBy.Name = "comboBox_SortBy";
			this.comboBox_SortBy.Size = new System.Drawing.Size(68, 28);
			this.comboBox_SortBy.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label9.Location = new System.Drawing.Point(843, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(90, 21);
			this.label9.TabIndex = 13;
			this.label9.Text = "排序依據：";
			// 
			// txt_MaxQuery
			// 
			this.txt_MaxQuery.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MaxQuery.Location = new System.Drawing.Point(935, 22);
			this.txt_MaxQuery.Name = "txt_MaxQuery";
			this.txt_MaxQuery.Size = new System.Drawing.Size(68, 29);
			this.txt_MaxQuery.TabIndex = 9;
			this.txt_MaxQuery.Text = "500";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label10.Location = new System.Drawing.Point(1007, 25);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 21);
			this.label10.TabIndex = 15;
			this.label10.Text = "筆資料";
			// 
			// checkBox_desc
			// 
			this.checkBox_desc.AutoSize = true;
			this.checkBox_desc.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.checkBox_desc.Location = new System.Drawing.Point(1013, 76);
			this.checkBox_desc.Name = "checkBox_desc";
			this.checkBox_desc.Size = new System.Drawing.Size(52, 17);
			this.checkBox_desc.TabIndex = 11;
			this.checkBox_desc.Text = "降冪";
			this.checkBox_desc.UseVisualStyleBackColor = true;
			// 
			// form_Orders
			// 
			this.AcceptButton = this.btn_Search;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 520);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txt_MaxQuery);
			this.Controls.Add(this.comboBox_SortBy);
			this.Controls.Add(this.checkBox_desc);
			this.Controls.Add(this.checkBox_MaxData);
			this.Controls.Add(this.comboBox_PaymentMethod);
			this.Controls.Add(this.comboBox_Payed);
			this.Controls.Add(this.comboBox_PurchaseTime);
			this.Controls.Add(this.btn_Edit);
			this.Controls.Add(this.dataGridView_Main);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_MinPaymentAmount);
			this.Controls.Add(this.txt_MemberName);
			this.Controls.Add(this.txt_MaxPaymentAmount);
			this.Controls.Add(this.txt_MemberID);
			this.Controls.Add(this.txt_OrderID);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.btn_ClearSearch);
			this.Controls.Add(this.btn_Search);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "form_Orders";
			this.ShowIcon = false;
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
		private System.Windows.Forms.TextBox txt_MemberID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView_Main;
		private System.Windows.Forms.Button btn_Edit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.TextBox txt_MemberName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox_PurchaseTime;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox_Payed;
		private System.Windows.Forms.TextBox txt_MaxPaymentAmount;
		private System.Windows.Forms.TextBox txt_MinPaymentAmount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBox_PaymentMethod;
		private System.Windows.Forms.Button btn_ClearSearch;
		private System.Windows.Forms.CheckBox checkBox_MaxData;
		private System.Windows.Forms.ComboBox comboBox_SortBy;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_MaxQuery;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox checkBox_desc;
	}
}