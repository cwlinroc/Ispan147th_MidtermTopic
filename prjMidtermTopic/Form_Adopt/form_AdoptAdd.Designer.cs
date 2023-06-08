namespace prjMidtermTopic.Form_Adopt
{
    partial class form_AdoptAdd
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
            this.txt_memberID = new System.Windows.Forms.TextBox();
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
            this.adopttime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.adopttime.Location = new System.Drawing.Point(40, 157);
            this.adopttime.Name = "adopttime";
            this.adopttime.Size = new System.Drawing.Size(71, 16);
            this.adopttime.TabIndex = 19;
            this.adopttime.Text = "申請時間";
            // 
            // txt_memberID
            // 
            this.txt_memberID.Location = new System.Drawing.Point(117, 119);
            this.txt_memberID.Name = "txt_memberID";
            this.txt_memberID.Size = new System.Drawing.Size(100, 22);
            this.txt_memberID.TabIndex = 18;
            // 
            // memberId
            // 
            this.memberId.AutoSize = true;
            this.memberId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.memberId.Location = new System.Drawing.Point(40, 125);
            this.memberId.Name = "memberId";
            this.memberId.Size = new System.Drawing.Size(71, 16);
            this.memberId.TabIndex = 17;
            this.memberId.Text = "會員編號";
            // 
            // txt_petID
            // 
            this.txt_petID.Location = new System.Drawing.Point(117, 88);
            this.txt_petID.Name = "txt_petID";
            this.txt_petID.Size = new System.Drawing.Size(100, 22);
            this.txt_petID.TabIndex = 16;
            // 
            // petId
            // 
            this.petId.AutoSize = true;
            this.petId.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.petId.Location = new System.Drawing.Point(40, 94);
            this.petId.Name = "petId";
            this.petId.Size = new System.Drawing.Size(71, 16);
            this.petId.TabIndex = 15;
            this.petId.Text = "寵物編號";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.commit_button);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // form_AdoptAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 394);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adopttime);
            this.Controls.Add(this.txt_memberID);
            this.Controls.Add(this.memberId);
            this.Controls.Add(this.txt_petID);
            this.Controls.Add(this.petId);
            this.Name = "form_AdoptAdd";
            this.Text = "form_AdoptAdd";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label adopttime;
        private System.Windows.Forms.TextBox txt_memberID;
        private System.Windows.Forms.Label memberId;
        private System.Windows.Forms.TextBox txt_petID;
        private System.Windows.Forms.Label petId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}