namespace prjMidtermTopic
{
    partial class form_Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
			this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
			this.系統ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.會員管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.寵物列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.領養清單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.訂單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.留言QAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.關閉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.水平排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.垂直排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.階梯排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.關閉當前視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.關閉所有視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip_Main = new System.Windows.Forms.ToolStrip();
			this.toolStripButton_MemberForm = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_PetForm = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_AdoptForm = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_MerchandiseForm = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_OrderForm = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_QAForm = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
			this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.大量輸入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip_Main.SuspendLayout();
			this.toolStrip_Main.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip_Main
			// 
			this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系統ToolStripMenuItem,
            this.視窗ToolStripMenuItem,
            this.功能ToolStripMenuItem});
			this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
			this.menuStrip_Main.Name = "menuStrip_Main";
			this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip_Main.Size = new System.Drawing.Size(699, 24);
			this.menuStrip_Main.TabIndex = 1;
			this.menuStrip_Main.Text = "menuStrip1";
			// 
			// 系統ToolStripMenuItem
			// 
			this.系統ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.會員管理ToolStripMenuItem,
            this.寵物列表ToolStripMenuItem,
            this.領養清單ToolStripMenuItem,
            this.商品ToolStripMenuItem,
            this.訂單ToolStripMenuItem,
            this.留言QAToolStripMenuItem,
            this.toolStripMenuItem1,
            this.關閉ToolStripMenuItem});
			this.系統ToolStripMenuItem.Name = "系統ToolStripMenuItem";
			this.系統ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.系統ToolStripMenuItem.Text = "系統";
			// 
			// 會員管理ToolStripMenuItem
			// 
			this.會員管理ToolStripMenuItem.Name = "會員管理ToolStripMenuItem";
			this.會員管理ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.會員管理ToolStripMenuItem.Text = "會員管理";
			this.會員管理ToolStripMenuItem.Click += new System.EventHandler(this.會員管理ToolStripMenuItem_Click);
			// 
			// 寵物列表ToolStripMenuItem
			// 
			this.寵物列表ToolStripMenuItem.Name = "寵物列表ToolStripMenuItem";
			this.寵物列表ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.寵物列表ToolStripMenuItem.Text = "寵物列表管理";
			this.寵物列表ToolStripMenuItem.Click += new System.EventHandler(this.寵物列表ToolStripMenuItem_Click);
			// 
			// 領養清單ToolStripMenuItem
			// 
			this.領養清單ToolStripMenuItem.Name = "領養清單ToolStripMenuItem";
			this.領養清單ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.領養清單ToolStripMenuItem.Text = "領養清單管理";
			this.領養清單ToolStripMenuItem.Click += new System.EventHandler(this.領養清單ToolStripMenuItem_Click);
			// 
			// 商品ToolStripMenuItem
			// 
			this.商品ToolStripMenuItem.Name = "商品ToolStripMenuItem";
			this.商品ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.商品ToolStripMenuItem.Text = "商品管理";
			this.商品ToolStripMenuItem.Click += new System.EventHandler(this.商品ToolStripMenuItem_Click);
			// 
			// 訂單ToolStripMenuItem
			// 
			this.訂單ToolStripMenuItem.Name = "訂單ToolStripMenuItem";
			this.訂單ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.訂單ToolStripMenuItem.Text = "訂單管理";
			this.訂單ToolStripMenuItem.Click += new System.EventHandler(this.訂單ToolStripMenuItem_Click);
			// 
			// 留言QAToolStripMenuItem
			// 
			this.留言QAToolStripMenuItem.Name = "留言QAToolStripMenuItem";
			this.留言QAToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.留言QAToolStripMenuItem.Text = "留言QA管理";
			this.留言QAToolStripMenuItem.Click += new System.EventHandler(this.留言QAToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
			// 
			// 關閉ToolStripMenuItem
			// 
			this.關閉ToolStripMenuItem.Name = "關閉ToolStripMenuItem";
			this.關閉ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.關閉ToolStripMenuItem.Text = "關閉";
			this.關閉ToolStripMenuItem.Click += new System.EventHandler(this.關閉ToolStripMenuItem_Click);
			// 
			// 視窗ToolStripMenuItem
			// 
			this.視窗ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平排列ToolStripMenuItem,
            this.垂直排列ToolStripMenuItem,
            this.階梯排列ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.關閉當前視窗ToolStripMenuItem,
            this.關閉所有視窗ToolStripMenuItem});
			this.視窗ToolStripMenuItem.Name = "視窗ToolStripMenuItem";
			this.視窗ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.視窗ToolStripMenuItem.Text = "視窗";
			// 
			// 水平排列ToolStripMenuItem
			// 
			this.水平排列ToolStripMenuItem.Name = "水平排列ToolStripMenuItem";
			this.水平排列ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.水平排列ToolStripMenuItem.Text = "水平排列";
			this.水平排列ToolStripMenuItem.Click += new System.EventHandler(this.水平排列ToolStripMenuItem_Click);
			// 
			// 垂直排列ToolStripMenuItem
			// 
			this.垂直排列ToolStripMenuItem.Name = "垂直排列ToolStripMenuItem";
			this.垂直排列ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.垂直排列ToolStripMenuItem.Text = "垂直排列";
			this.垂直排列ToolStripMenuItem.Click += new System.EventHandler(this.垂直排列ToolStripMenuItem_Click);
			// 
			// 階梯排列ToolStripMenuItem
			// 
			this.階梯排列ToolStripMenuItem.Name = "階梯排列ToolStripMenuItem";
			this.階梯排列ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.階梯排列ToolStripMenuItem.Text = "階梯排列";
			this.階梯排列ToolStripMenuItem.Click += new System.EventHandler(this.階梯排列ToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
			// 
			// 關閉當前視窗ToolStripMenuItem
			// 
			this.關閉當前視窗ToolStripMenuItem.Name = "關閉當前視窗ToolStripMenuItem";
			this.關閉當前視窗ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.關閉當前視窗ToolStripMenuItem.Text = "關閉當前視窗";
			this.關閉當前視窗ToolStripMenuItem.Click += new System.EventHandler(this.關閉當前視窗ToolStripMenuItem_Click);
			// 
			// 關閉所有視窗ToolStripMenuItem
			// 
			this.關閉所有視窗ToolStripMenuItem.Name = "關閉所有視窗ToolStripMenuItem";
			this.關閉所有視窗ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.關閉所有視窗ToolStripMenuItem.Text = "關閉所有視窗";
			this.關閉所有視窗ToolStripMenuItem.Click += new System.EventHandler(this.關閉所有視窗ToolStripMenuItem_Click);
			// 
			// toolStrip_Main
			// 
			this.toolStrip_Main.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_MemberForm,
            this.toolStripButton_PetForm,
            this.toolStripButton_AdoptForm,
            this.toolStripButton_MerchandiseForm,
            this.toolStripButton_OrderForm,
            this.toolStripButton_QAForm,
            this.toolStripButton_Exit});
			this.toolStrip_Main.Location = new System.Drawing.Point(0, 24);
			this.toolStrip_Main.Name = "toolStrip_Main";
			this.toolStrip_Main.Size = new System.Drawing.Size(699, 39);
			this.toolStrip_Main.TabIndex = 2;
			this.toolStrip_Main.Text = "toolStrip1";
			// 
			// toolStripButton_MemberForm
			// 
			this.toolStripButton_MemberForm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_MemberForm.Image")));
			this.toolStripButton_MemberForm.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_MemberForm.Name = "toolStripButton_MemberForm";
			this.toolStripButton_MemberForm.Size = new System.Drawing.Size(91, 36);
			this.toolStripButton_MemberForm.Text = "會員管理";
			this.toolStripButton_MemberForm.Click += new System.EventHandler(this.toolStripButton_MemberForm_Click);
			// 
			// toolStripButton_PetForm
			// 
			this.toolStripButton_PetForm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_PetForm.Image")));
			this.toolStripButton_PetForm.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_PetForm.Name = "toolStripButton_PetForm";
			this.toolStripButton_PetForm.Size = new System.Drawing.Size(91, 36);
			this.toolStripButton_PetForm.Text = "寵物列表";
			this.toolStripButton_PetForm.Click += new System.EventHandler(this.toolStripButton_PetForm_Click);
			// 
			// toolStripButton_AdoptForm
			// 
			this.toolStripButton_AdoptForm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_AdoptForm.Image")));
			this.toolStripButton_AdoptForm.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_AdoptForm.Name = "toolStripButton_AdoptForm";
			this.toolStripButton_AdoptForm.Size = new System.Drawing.Size(91, 36);
			this.toolStripButton_AdoptForm.Text = "領養清單";
			this.toolStripButton_AdoptForm.Click += new System.EventHandler(this.toolStripButton_AdoptForm_Click);
			// 
			// toolStripButton_MerchandiseForm
			// 
			this.toolStripButton_MerchandiseForm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_MerchandiseForm.Image")));
			this.toolStripButton_MerchandiseForm.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_MerchandiseForm.Name = "toolStripButton_MerchandiseForm";
			this.toolStripButton_MerchandiseForm.Size = new System.Drawing.Size(67, 36);
			this.toolStripButton_MerchandiseForm.Text = "商品";
			this.toolStripButton_MerchandiseForm.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
			this.toolStripButton_MerchandiseForm.Click += new System.EventHandler(this.toolStripButton_MerchandiseForm_Click);
			// 
			// toolStripButton_OrderForm
			// 
			this.toolStripButton_OrderForm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_OrderForm.Image")));
			this.toolStripButton_OrderForm.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_OrderForm.Name = "toolStripButton_OrderForm";
			this.toolStripButton_OrderForm.Size = new System.Drawing.Size(67, 36);
			this.toolStripButton_OrderForm.Text = "訂單";
			this.toolStripButton_OrderForm.Click += new System.EventHandler(this.toolStripButton_OrderForm_Click);
			// 
			// toolStripButton_QAForm
			// 
			this.toolStripButton_QAForm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_QAForm.Image")));
			this.toolStripButton_QAForm.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_QAForm.Name = "toolStripButton_QAForm";
			this.toolStripButton_QAForm.Size = new System.Drawing.Size(85, 36);
			this.toolStripButton_QAForm.Text = "留言QA";
			this.toolStripButton_QAForm.Click += new System.EventHandler(this.toolStripButton_QAForm_Click);
			// 
			// toolStripButton_Exit
			// 
			this.toolStripButton_Exit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Exit.Image")));
			this.toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_Exit.Name = "toolStripButton_Exit";
			this.toolStripButton_Exit.Size = new System.Drawing.Size(67, 36);
			this.toolStripButton_Exit.Text = "離開";
			this.toolStripButton_Exit.Click += new System.EventHandler(this.toolStripButton_Exit_Click);
			// 
			// 功能ToolStripMenuItem
			// 
			this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大量輸入ToolStripMenuItem});
			this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
			this.功能ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.功能ToolStripMenuItem.Text = "功能";
			// 
			// 大量輸入ToolStripMenuItem
			// 
			this.大量輸入ToolStripMenuItem.Name = "大量輸入ToolStripMenuItem";
			this.大量輸入ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.大量輸入ToolStripMenuItem.Text = "大量輸入";
			this.大量輸入ToolStripMenuItem.Click += new System.EventHandler(this.大量輸入ToolStripMenuItem_Click);
			// 
			// form_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 435);
			this.Controls.Add(this.toolStrip_Main);
			this.Controls.Add(this.menuStrip_Main);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip_Main;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "form_Main";
			this.Text = "管理系統";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Main_FormClosed);
			this.menuStrip_Main.ResumeLayout(false);
			this.menuStrip_Main.PerformLayout();
			this.toolStrip_Main.ResumeLayout(false);
			this.toolStrip_Main.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStrip toolStrip_Main;
        private System.Windows.Forms.ToolStripButton toolStripButton_MemberForm;
        private System.Windows.Forms.ToolStripButton toolStripButton_PetForm;
        private System.Windows.Forms.ToolStripButton toolStripButton_AdoptForm;
        private System.Windows.Forms.ToolStripButton toolStripButton_MerchandiseForm;
        private System.Windows.Forms.ToolStripButton toolStripButton_OrderForm;
        private System.Windows.Forms.ToolStripButton toolStripButton_QAForm;
        private System.Windows.Forms.ToolStripButton toolStripButton_Exit;
        private System.Windows.Forms.ToolStripMenuItem 系統ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 會員管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 寵物列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 領養清單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 訂單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 留言QAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 關閉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 視窗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 階梯排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 關閉當前視窗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關閉所有視窗ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 大量輸入ToolStripMenuItem;
	}
}

