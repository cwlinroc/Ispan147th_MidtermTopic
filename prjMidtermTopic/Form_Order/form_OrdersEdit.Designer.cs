namespace prjMidtermTopic.Form_Order
{
	partial class form_OrdersEdit
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
			this.components = new System.ComponentModel.Container();
			this.btn_commit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_OrderID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_MemberID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox_PayMethod = new System.Windows.Forms.ComboBox();
			this.comboBox_Payed = new System.Windows.Forms.ComboBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.dateTimePicker_PurchaseTime = new System.Windows.Forms.DateTimePicker();
			this.txt_PaymentAmount = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_commit
			// 
			this.btn_commit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_commit.Location = new System.Drawing.Point(122, 240);
			this.btn_commit.Margin = new System.Windows.Forms.Padding(2);
			this.btn_commit.Name = "btn_commit";
			this.btn_commit.Size = new System.Drawing.Size(100, 30);
			this.btn_commit.TabIndex = 6;
			this.btn_commit.Text = "確認修改";
			this.btn_commit.UseVisualStyleBackColor = true;
			this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(29, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "訂單編號：";
			// 
			// txt_OrderID
			// 
			this.txt_OrderID.Enabled = false;
			this.txt_OrderID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_OrderID.Location = new System.Drawing.Point(122, 28);
			this.txt_OrderID.Margin = new System.Windows.Forms.Padding(2);
			this.txt_OrderID.Name = "txt_OrderID";
			this.txt_OrderID.Size = new System.Drawing.Size(177, 29);
			this.txt_OrderID.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(29, 64);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "顧客ID：";
			// 
			// txt_MemberID
			// 
			this.txt_MemberID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MemberID.Location = new System.Drawing.Point(122, 61);
			this.txt_MemberID.Margin = new System.Windows.Forms.Padding(2);
			this.txt_MemberID.Name = "txt_MemberID";
			this.txt_MemberID.Size = new System.Drawing.Size(177, 29);
			this.txt_MemberID.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(29, 98);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "付款方式：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(29, 131);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 21);
			this.label4.TabIndex = 1;
			this.label4.Text = "成功付款：";
			// 
			// comboBox_PayMethod
			// 
			this.comboBox_PayMethod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox_PayMethod.FormattingEnabled = true;
			this.comboBox_PayMethod.Location = new System.Drawing.Point(122, 94);
			this.comboBox_PayMethod.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox_PayMethod.Name = "comboBox_PayMethod";
			this.comboBox_PayMethod.Size = new System.Drawing.Size(177, 28);
			this.comboBox_PayMethod.TabIndex = 2;
			// 
			// comboBox_Payed
			// 
			this.comboBox_Payed.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox_Payed.FormattingEnabled = true;
			this.comboBox_Payed.Location = new System.Drawing.Point(122, 126);
			this.comboBox_Payed.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox_Payed.Name = "comboBox_Payed";
			this.comboBox_Payed.Size = new System.Drawing.Size(177, 28);
			this.comboBox_Payed.TabIndex = 3;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// dateTimePicker_PurchaseTime
			// 
			this.dateTimePicker_PurchaseTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePicker_PurchaseTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker_PurchaseTime.Location = new System.Drawing.Point(122, 158);
			this.dateTimePicker_PurchaseTime.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePicker_PurchaseTime.Name = "dateTimePicker_PurchaseTime";
			this.dateTimePicker_PurchaseTime.Size = new System.Drawing.Size(177, 29);
			this.dateTimePicker_PurchaseTime.TabIndex = 4;
			// 
			// txt_PaymentAmount
			// 
			this.txt_PaymentAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_PaymentAmount.Location = new System.Drawing.Point(122, 191);
			this.txt_PaymentAmount.Margin = new System.Windows.Forms.Padding(2);
			this.txt_PaymentAmount.Name = "txt_PaymentAmount";
			this.txt_PaymentAmount.Size = new System.Drawing.Size(177, 29);
			this.txt_PaymentAmount.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(29, 197);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 21);
			this.label6.TabIndex = 6;
			this.label6.Text = "付款金額：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(29, 165);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 21);
			this.label5.TabIndex = 7;
			this.label5.Text = "購買時間：";
			// 
			// form_OrdersEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 304);
			this.Controls.Add(this.dateTimePicker_PurchaseTime);
			this.Controls.Add(this.txt_PaymentAmount);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox_Payed);
			this.Controls.Add(this.comboBox_PayMethod);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_MemberID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_OrderID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_commit);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "form_OrdersEdit";
			this.Text = "修改訂單";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_commit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_OrderID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_MemberID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox_PayMethod;
		private System.Windows.Forms.ComboBox comboBox_Payed;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.DateTimePicker dateTimePicker_PurchaseTime;
		private System.Windows.Forms.TextBox txt_PaymentAmount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
	}
}