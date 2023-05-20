namespace prjMidtermTopic
{
	partial class form_OrderEdit
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
			this.btn_commit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_OrderID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_CustomerID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox_PayMethod = new System.Windows.Forms.ComboBox();
			this.comboBox_Payed = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btn_commit
			// 
			this.btn_commit.Location = new System.Drawing.Point(93, 165);
			this.btn_commit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_commit.Name = "btn_commit";
			this.btn_commit.Size = new System.Drawing.Size(123, 28);
			this.btn_commit.TabIndex = 0;
			this.btn_commit.Text = "確認修改";
			this.btn_commit.UseVisualStyleBackColor = true;
			this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 47);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "訂單編號";
			// 
			// txt_OrderID
			// 
			this.txt_OrderID.Enabled = false;
			this.txt_OrderID.Location = new System.Drawing.Point(93, 45);
			this.txt_OrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_OrderID.Name = "txt_OrderID";
			this.txt_OrderID.Size = new System.Drawing.Size(177, 22);
			this.txt_OrderID.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 72);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "顧客ID";
			// 
			// txt_CustomerID
			// 
			this.txt_CustomerID.Location = new System.Drawing.Point(93, 70);
			this.txt_CustomerID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_CustomerID.Name = "txt_CustomerID";
			this.txt_CustomerID.Size = new System.Drawing.Size(177, 22);
			this.txt_CustomerID.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 97);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "付款方式";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 122);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "成功付款";
			// 
			// comboBox_PayMethod
			// 
			this.comboBox_PayMethod.FormattingEnabled = true;
			this.comboBox_PayMethod.Items.AddRange(new object[] {
            "會員點數",
            "信用卡",
            "LinePay",
            "Bitcoin"});
			this.comboBox_PayMethod.Location = new System.Drawing.Point(93, 95);
			this.comboBox_PayMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBox_PayMethod.Name = "comboBox_PayMethod";
			this.comboBox_PayMethod.Size = new System.Drawing.Size(149, 20);
			this.comboBox_PayMethod.TabIndex = 3;
			// 
			// comboBox_Payed
			// 
			this.comboBox_Payed.FormattingEnabled = true;
			this.comboBox_Payed.Items.AddRange(new object[] {
            "是",
            "否"});
			this.comboBox_Payed.Location = new System.Drawing.Point(93, 119);
			this.comboBox_Payed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBox_Payed.Name = "comboBox_Payed";
			this.comboBox_Payed.Size = new System.Drawing.Size(149, 20);
			this.comboBox_Payed.TabIndex = 4;
			// 
			// form_OrderEditOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 242);
			this.Controls.Add(this.comboBox_Payed);
			this.Controls.Add(this.comboBox_PayMethod);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_CustomerID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_OrderID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_commit);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "form_OrderEditOrder";
			this.Text = "修改訂單";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_commit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_OrderID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_CustomerID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox_PayMethod;
		private System.Windows.Forms.ComboBox comboBox_Payed;
	}
}