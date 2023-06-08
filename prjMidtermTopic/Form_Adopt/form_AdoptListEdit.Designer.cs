namespace prjMidtermTopic.Form_Adopt
{
    partial class form_AdoptListEdit
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
			this.adopttime = new System.Windows.Forms.Label();
			this.txt_MemberID = new System.Windows.Forms.TextBox();
			this.memberId = new System.Windows.Forms.Label();
			this.txt_petID = new System.Windows.Forms.TextBox();
			this.petId = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// adopttime
			// 
			this.adopttime.AutoSize = true;
			this.adopttime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.adopttime.Location = new System.Drawing.Point(31, 105);
			this.adopttime.Name = "adopttime";
			this.adopttime.Size = new System.Drawing.Size(90, 21);
			this.adopttime.TabIndex = 19;
			this.adopttime.Text = "申請時間：";
			// 
			// txt_MemberID
			// 
			this.txt_MemberID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_MemberID.Location = new System.Drawing.Point(121, 67);
			this.txt_MemberID.Name = "txt_MemberID";
			this.txt_MemberID.Size = new System.Drawing.Size(100, 29);
			this.txt_MemberID.TabIndex = 18;
			// 
			// memberId
			// 
			this.memberId.AutoSize = true;
			this.memberId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.memberId.Location = new System.Drawing.Point(31, 70);
			this.memberId.Name = "memberId";
			this.memberId.Size = new System.Drawing.Size(90, 21);
			this.memberId.TabIndex = 17;
			this.memberId.Text = "會員編號：";
			// 
			// txt_petID
			// 
			this.txt_petID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_petID.Location = new System.Drawing.Point(121, 32);
			this.txt_petID.Name = "txt_petID";
			this.txt_petID.Size = new System.Drawing.Size(100, 29);
			this.txt_petID.TabIndex = 16;
			// 
			// petId
			// 
			this.petId.AutoSize = true;
			this.petId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.petId.Location = new System.Drawing.Point(31, 35);
			this.petId.Name = "petId";
			this.petId.Size = new System.Drawing.Size(90, 21);
			this.petId.TabIndex = 15;
			this.petId.Text = "寵物編號：";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(221, 150);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 40);
			this.button1.TabIndex = 21;
			this.button1.Text = "儲存更新";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePicker1.Location = new System.Drawing.Point(121, 105);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 22;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// form_AdoptListEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 219);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.adopttime);
			this.Controls.Add(this.txt_MemberID);
			this.Controls.Add(this.memberId);
			this.Controls.Add(this.txt_petID);
			this.Controls.Add(this.petId);
			this.Name = "form_AdoptListEdit";
			this.Text = "修改領養申請";
			this.Load += new System.EventHandler(this.form_AdoptListEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label adopttime;
        private System.Windows.Forms.TextBox txt_MemberID;
        private System.Windows.Forms.Label memberId;
        private System.Windows.Forms.TextBox txt_petID;
        private System.Windows.Forms.Label petId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}