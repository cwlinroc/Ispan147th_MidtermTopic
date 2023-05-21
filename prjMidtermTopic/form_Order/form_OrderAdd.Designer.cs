﻿namespace prjMidtermTopic.form_Order
{
	partial class form_OrderAdd
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
			this.txt_CustomerID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox_PayMethod = new System.Windows.Forms.ComboBox();
			this.comboBox_Payed = new System.Windows.Forms.ComboBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_commit
			// 
			this.btn_commit.Location = new System.Drawing.Point(124, 206);
			this.btn_commit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_commit.Name = "btn_commit";
			this.btn_commit.Size = new System.Drawing.Size(164, 35);
			this.btn_commit.TabIndex = 0;
			this.btn_commit.Text = "確認新增";
			this.btn_commit.UseVisualStyleBackColor = true;
			this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "訂單編號";
			// 
			// txt_OrderID
			// 
			this.txt_OrderID.Enabled = false;
			this.txt_OrderID.Location = new System.Drawing.Point(124, 56);
			this.txt_OrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_OrderID.Name = "txt_OrderID";
			this.txt_OrderID.Size = new System.Drawing.Size(235, 25);
			this.txt_OrderID.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "顧客ID";
			// 
			// txt_CustomerID
			// 
			this.txt_CustomerID.Location = new System.Drawing.Point(124, 88);
			this.txt_CustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_CustomerID.Name = "txt_CustomerID";
			this.txt_CustomerID.Size = new System.Drawing.Size(235, 25);
			this.txt_CustomerID.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "付款方式";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(47, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 1;
			this.label4.Text = "成功付款";
			// 
			// comboBox_PayMethod
			// 
			this.comboBox_PayMethod.FormattingEnabled = true;
			this.comboBox_PayMethod.Location = new System.Drawing.Point(124, 119);
			this.comboBox_PayMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBox_PayMethod.Name = "comboBox_PayMethod";
			this.comboBox_PayMethod.Size = new System.Drawing.Size(197, 23);
			this.comboBox_PayMethod.TabIndex = 3;
			// 
			// comboBox_Payed
			// 
			this.comboBox_Payed.FormattingEnabled = true;
			this.comboBox_Payed.Location = new System.Drawing.Point(124, 149);
			this.comboBox_Payed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBox_Payed.Name = "comboBox_Payed";
			this.comboBox_Payed.Size = new System.Drawing.Size(197, 23);
			this.comboBox_Payed.TabIndex = 4;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// form_OrderAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 302);
			this.Controls.Add(this.comboBox_Payed);
			this.Controls.Add(this.comboBox_PayMethod);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_CustomerID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_OrderID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_commit);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "form_OrderAdd";
			this.Text = "新增訂單";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}