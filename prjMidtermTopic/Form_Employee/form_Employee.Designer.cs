namespace prjMidtermTopic.Form_Employee
{
	partial class form_Employee
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
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_AddEmployee = new System.Windows.Forms.Button();
			this.btn_EditData = new System.Windows.Forms.Button();
			this.btn_RemoveEmployee = new System.Windows.Forms.Button();
			this.btn_ChangePermission = new System.Windows.Forms.Button();
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
            this.Column4,
            this.Column5});
			this.dataGridView_Main.Location = new System.Drawing.Point(33, 42);
			this.dataGridView_Main.Name = "dataGridView_Main";
			this.dataGridView_Main.ReadOnly = true;
			this.dataGridView_Main.RowTemplate.Height = 24;
			this.dataGridView_Main.Size = new System.Drawing.Size(445, 373);
			this.dataGridView_Main.TabIndex = 0;
			this.dataGridView_Main.SelectionChanged += new System.EventHandler(this.dataGridView_Main_SelectionChanged);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "EmployeeID";
			this.Column1.HeaderText = "編號";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "EmployeeName";
			this.Column2.HeaderText = "員工姓名";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "EmployeeAccount";
			this.Column3.HeaderText = "帳號";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "EmployeePassword";
			this.Column4.HeaderText = "密碼";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Visible = false;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Permission";
			this.Column5.HeaderText = "權限";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// btn_AddEmployee
			// 
			this.btn_AddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddEmployee.Location = new System.Drawing.Point(534, 45);
			this.btn_AddEmployee.Name = "btn_AddEmployee";
			this.btn_AddEmployee.Size = new System.Drawing.Size(100, 34);
			this.btn_AddEmployee.TabIndex = 1;
			this.btn_AddEmployee.Text = "新增帳號";
			this.btn_AddEmployee.UseVisualStyleBackColor = true;
			this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
			// 
			// btn_EditData
			// 
			this.btn_EditData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_EditData.Location = new System.Drawing.Point(534, 136);
			this.btn_EditData.Name = "btn_EditData";
			this.btn_EditData.Size = new System.Drawing.Size(100, 34);
			this.btn_EditData.TabIndex = 1;
			this.btn_EditData.Text = "修改資料";
			this.btn_EditData.UseVisualStyleBackColor = true;
			this.btn_EditData.Click += new System.EventHandler(this.btn_EdditData_Click);
			// 
			// btn_RemoveEmployee
			// 
			this.btn_RemoveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RemoveEmployee.Location = new System.Drawing.Point(534, 381);
			this.btn_RemoveEmployee.Name = "btn_RemoveEmployee";
			this.btn_RemoveEmployee.Size = new System.Drawing.Size(100, 34);
			this.btn_RemoveEmployee.TabIndex = 1;
			this.btn_RemoveEmployee.Text = "刪除帳號";
			this.btn_RemoveEmployee.UseVisualStyleBackColor = true;
			this.btn_RemoveEmployee.Click += new System.EventHandler(this.btn_RemoveEmployee_Click);
			// 
			// btn_ChangePermission
			// 
			this.btn_ChangePermission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ChangePermission.Location = new System.Drawing.Point(534, 303);
			this.btn_ChangePermission.Name = "btn_ChangePermission";
			this.btn_ChangePermission.Size = new System.Drawing.Size(100, 34);
			this.btn_ChangePermission.TabIndex = 1;
			this.btn_ChangePermission.Text = "調整權限";
			this.btn_ChangePermission.UseVisualStyleBackColor = true;
			this.btn_ChangePermission.Click += new System.EventHandler(this.btn_ChangePermission_Click);
			// 
			// form_Employee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(695, 462);
			this.Controls.Add(this.btn_ChangePermission);
			this.Controls.Add(this.btn_RemoveEmployee);
			this.Controls.Add(this.btn_EditData);
			this.Controls.Add(this.btn_AddEmployee);
			this.Controls.Add(this.dataGridView_Main);
			this.Name = "form_Employee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "form_Employee";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Main;
		private System.Windows.Forms.Button btn_AddEmployee;
		private System.Windows.Forms.Button btn_EditData;
		private System.Windows.Forms.Button btn_RemoveEmployee;
		private System.Windows.Forms.Button btn_ChangePermission;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}