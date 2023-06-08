namespace prjMidtermTopic
{
    partial class form_Adopt
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adoptid = new System.Windows.Forms.Label();
			this.txt_adoptID = new System.Windows.Forms.TextBox();
			this.txt_petID = new System.Windows.Forms.TextBox();
			this.petId = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.memberId = new System.Windows.Forms.Label();
			this.txt_datetime = new System.Windows.Forms.TextBox();
			this.adopttime = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Add = new System.Windows.Forms.Button();
			this.search = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(40, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(625, 342);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "AdoptID";
            this.Column1.HeaderText = "編號";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PetID";
            this.Column2.HeaderText = "寵物編號";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MemberID";
            this.Column3.HeaderText = "會員編號";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ApplicationTime";
            this.Column4.HeaderText = "領養申請時間";
            this.Column4.Name = "Column4";
            // 
            // adoptid
            // 
            this.adoptid.AutoSize = true;
            this.adoptid.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.adoptid.Location = new System.Drawing.Point(3, 17);
            this.adoptid.Name = "adoptid";
            this.adoptid.Size = new System.Drawing.Size(71, 16);
            this.adoptid.TabIndex = 1;
            this.adoptid.Text = "領養編號";
            this.adoptid.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_adoptID
            // 
            this.txt_adoptID.Location = new System.Drawing.Point(80, 11);
            this.txt_adoptID.Name = "txt_adoptID";
            this.txt_adoptID.Size = new System.Drawing.Size(100, 22);
            this.txt_adoptID.TabIndex = 2;
            this.txt_adoptID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_petID
            // 
            this.txt_petID.Location = new System.Drawing.Point(80, 43);
            this.txt_petID.Name = "txt_petID";
            this.txt_petID.Size = new System.Drawing.Size(100, 22);
            this.txt_petID.TabIndex = 4;
            // 
            // petId
            // 
            this.petId.AutoSize = true;
            this.petId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.petId.Location = new System.Drawing.Point(3, 49);
            this.petId.Name = "petId";
            this.petId.Size = new System.Drawing.Size(71, 16);
            this.petId.TabIndex = 3;
            this.petId.Text = "寵物編號";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(267, 11);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // memberId
            // 
            this.memberId.AutoSize = true;
            this.memberId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.memberId.Location = new System.Drawing.Point(190, 17);
            this.memberId.Name = "memberId";
            this.memberId.Size = new System.Drawing.Size(71, 16);
            this.memberId.TabIndex = 5;
            this.memberId.Text = "會員編號";
            // 
            // txt_datetime
            // 
            this.txt_datetime.Location = new System.Drawing.Point(267, 43);
            this.txt_datetime.Name = "txt_datetime";
            this.txt_datetime.Size = new System.Drawing.Size(100, 22);
            this.txt_datetime.TabIndex = 8;
            // 
            // adopttime
            // 
            this.adopttime.AutoSize = true;
            this.adopttime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.adopttime.Location = new System.Drawing.Point(190, 49);
            this.adopttime.Name = "adopttime";
            this.adopttime.Size = new System.Drawing.Size(71, 16);
            this.adopttime.TabIndex = 7;
            this.adopttime.Text = "申請時間";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(441, 11);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(373, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "會員名稱";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(441, 43);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(373, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "寵物名稱";
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Location = new System.Drawing.Point(571, 487);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(101, 33);
            this.Add.TabIndex = 13;
            this.Add.Text = "新增領養";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(571, 43);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 14;
            this.search.Text = "查詢";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // form_Adopt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 535);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_datetime);
            this.Controls.Add(this.adopttime);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.memberId);
            this.Controls.Add(this.txt_petID);
            this.Controls.Add(this.petId);
            this.Controls.Add(this.txt_adoptID);
            this.Controls.Add(this.adoptid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_Adopt";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.form_Adopt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label adoptid;
        private System.Windows.Forms.TextBox txt_adoptID;
        private System.Windows.Forms.TextBox txt_petID;
        private System.Windows.Forms.Label petId;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label memberId;
        private System.Windows.Forms.TextBox txt_datetime;
        private System.Windows.Forms.Label adopttime;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button search;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
	}
}