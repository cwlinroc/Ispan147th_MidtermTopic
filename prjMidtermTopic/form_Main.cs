using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic
{
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
        }

        //toolStripButtons
        #region --toolStripButtons--
        private void toolStripButton_MemberForm_Click(object sender, EventArgs e)
        {
            showForm(new form_Member());
        }

        private void toolStripButton_PetForm_Click(object sender, EventArgs e)
        {
            showForm(new form_Pet());
        }

        private void toolStripButton_AdoptForm_Click(object sender, EventArgs e)
        {
            showForm(new form_Adopt());
        }

        private void toolStripButton_MerchandiseForm_Click(object sender, EventArgs e)
        {
            showForm(new form_Merchandise());
        }

        private void toolStripButton_OrderForm_Click(object sender, EventArgs e)
        {
            showForm(new form_Order()); 
        }

        private void toolStripButton_QAForm_Click(object sender, EventArgs e)
        {
            showForm(new form_QA());
        }

        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        //menuStripButtons
        #region --menuStripButtons--
        private void 會員管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_MemberForm.PerformClick();
        }

        private void 寵物列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_PetForm.PerformClick();
        }

        private void 領養清單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_AdoptForm.PerformClick();
        }

        private void 商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_MerchandiseForm.PerformClick();
        }

        private void 訂單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_OrderForm.PerformClick();
        }

        private void 留言QAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_QAForm.PerformClick();
        }

        private void 關閉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_Exit.PerformClick();
        }

        private void 水平排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 階梯排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void 關閉當前視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
        }

        private void 關閉所有視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (ActiveMdiChild != null) ActiveMdiChild.Close();
        }
        #endregion

        private void showForm(Form frm)
        {
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
