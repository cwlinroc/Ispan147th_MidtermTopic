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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.adopttime = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.memberId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.petId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.adoptid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(117, 216);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 24;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(40, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "寵物名稱";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(117, 184);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(40, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "會員名稱";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 20;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 18;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 16;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 14;
            // 
            // adoptid
            // 
            this.adoptid.AutoSize = true;
            this.adoptid.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.adoptid.Location = new System.Drawing.Point(40, 62);
            this.adoptid.Name = "adoptid";
            this.adoptid.Size = new System.Drawing.Size(71, 16);
            this.adoptid.TabIndex = 13;
            this.adoptid.Text = "領養編號";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.commit_button);
            // 
            // form_AdoptAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.adopttime);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.memberId);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.petId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.adoptid);
            this.Name = "form_AdoptAdd";
            this.Text = "form_AdoptAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label adopttime;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label memberId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label petId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label adoptid;
        private System.Windows.Forms.Button button1;
    }
}