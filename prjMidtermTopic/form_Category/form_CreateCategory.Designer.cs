namespace prjMidtermTopic.form_Category
{
	partial class form_CreateCategory
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
			this.btn_Add = new System.Windows.Forms.Button();
			this.txt_CategoryName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(254, 43);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(75, 23);
			this.btn_Add.TabIndex = 19;
			this.btn_Add.Text = "新增類別";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// txt_CategoryName
			// 
			this.txt_CategoryName.Location = new System.Drawing.Point(91, 12);
			this.txt_CategoryName.Name = "txt_CategoryName";
			this.txt_CategoryName.Size = new System.Drawing.Size(238, 22);
			this.txt_CategoryName.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 17;
			this.label2.Text = "類別名稱：";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// form_CreateCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 80);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.txt_CategoryName);
			this.Controls.Add(this.label2);
			this.Name = "form_CreateCategory";
			this.Text = "類別管理：新增類別名稱";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.TextBox txt_CategoryName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}