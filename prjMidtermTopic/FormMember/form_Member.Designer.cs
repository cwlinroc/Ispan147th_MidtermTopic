namespace prjMidtermTopic
{
    partial class form_Member
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtMemberID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMemberName = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.txtMaxQuery = new System.Windows.Forms.TextBox();
			this.checkBoxMaxQuery = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(12, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "會員編號：";
			// 
			// txtMemberID
			// 
			this.txtMemberID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtMemberID.Location = new System.Drawing.Point(108, 37);
			this.txtMemberID.Name = "txtMemberID";
			this.txtMemberID.Size = new System.Drawing.Size(100, 29);
			this.txtMemberID.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(259, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "姓名：";
			// 
			// txtMemberName
			// 
			this.txtMemberName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtMemberName.Location = new System.Drawing.Point(323, 38);
			this.txtMemberName.Name = "txtMemberName";
			this.txtMemberName.Size = new System.Drawing.Size(100, 29);
			this.txtMemberName.TabIndex = 1;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.AutoSize = true;
			this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSearch.Location = new System.Drawing.Point(901, 33);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(109, 36);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "搜尋";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column12,
            this.Column11,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
			this.dataGridView1.Location = new System.Drawing.Point(12, 102);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1164, 334);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MemberID";
			this.Column1.HeaderText = "編號";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 60;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "MemberName";
			this.Column2.HeaderText = "姓名";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column12
			// 
			this.Column12.DataPropertyName = "ForumAccountID";
			this.Column12.HeaderText = "論壇帳戶編號";
			this.Column12.Name = "Column12";
			this.Column12.ReadOnly = true;
			// 
			// Column11
			// 
			this.Column11.DataPropertyName = "NickName";
			this.Column11.HeaderText = "暱稱";
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "DateOfBirth";
			this.Column3.HeaderText = "生日";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Gender";
			this.Column4.HeaderText = "性別";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 60;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Account";
			this.Column5.HeaderText = "帳號";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "Password";
			this.Column6.HeaderText = "密碼";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "Phone";
			this.Column7.HeaderText = "電話";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "Address";
			this.Column8.HeaderText = "地址";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// Column9
			// 
			this.Column9.DataPropertyName = "Email";
			this.Column9.HeaderText = "Email";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			// 
			// Column10
			// 
			this.Column10.DataPropertyName = "Avatar";
			this.Column10.HeaderText = "頭像";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.AutoSize = true;
			this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnAdd.Location = new System.Drawing.Point(1067, 459);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(109, 36);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "新增會員";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.AutoSize = true;
			this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnReset.Location = new System.Drawing.Point(1041, 33);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(109, 36);
			this.btnReset.TabIndex = 4;
			this.btnReset.Text = "重設";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// txtMaxQuery
			// 
			this.txtMaxQuery.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtMaxQuery.Location = new System.Drawing.Point(583, 38);
			this.txtMaxQuery.Name = "txtMaxQuery";
			this.txtMaxQuery.Size = new System.Drawing.Size(100, 29);
			this.txtMaxQuery.TabIndex = 5;
			this.txtMaxQuery.Text = "100";
			// 
			// checkBoxMaxQuery
			// 
			this.checkBoxMaxQuery.AutoSize = true;
			this.checkBoxMaxQuery.Checked = true;
			this.checkBoxMaxQuery.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxMaxQuery.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.checkBoxMaxQuery.Location = new System.Drawing.Point(484, 40);
			this.checkBoxMaxQuery.Name = "checkBoxMaxQuery";
			this.checkBoxMaxQuery.Size = new System.Drawing.Size(93, 25);
			this.checkBoxMaxQuery.TabIndex = 6;
			this.checkBoxMaxQuery.Text = "最多顯示";
			this.checkBoxMaxQuery.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(689, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 21);
			this.label3.TabIndex = 7;
			this.label3.Text = "筆資料";
			// 
			// form_Member
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1188, 520);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.checkBoxMaxQuery);
			this.Controls.Add(this.txtMaxQuery);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtMemberName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMemberID);
			this.Controls.Add(this.label1);
			this.Name = "form_Member";
			this.Text = "會員管理：檢視、搜尋";
			this.Load += new System.EventHandler(this.form_Member_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMemberID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMemberName;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.TextBox txtMaxQuery;
		private System.Windows.Forms.CheckBox checkBoxMaxQuery;
		private System.Windows.Forms.Label label3;
	}
}