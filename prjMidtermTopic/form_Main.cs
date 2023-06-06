using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.form_Category;
using prjMidtermTopic.Form_Employee;
using prjMidtermTopic.Form_Order;
using prjMidtermTopic.MassInsert;
using prjMidtermTopic.Model;

namespace prjMidtermTopic
{
	public partial class form_Main : Form
	{
		private bool _multiMdiChild = false;
		private bool _logOut = false;
		private bool _maxed = true;
		public form_Main()
		{
			InitializeComponent();
			toolStrip_Main.Renderer = new NoEdgeRenderer();
			toolStrip_Title.Renderer = new NoEdgeRenderer();
			menuStrip_Main.Renderer = new ColoredRenderer();

			MaximizeWindow();
		}


		//closed
		private void form_Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.Owner != null)
			{
				if (!_logOut)
				{
					Application.Exit();
				}
				else
				{
					Owner.Show();
				}
			}
		}

		//toolStripButtons

		#region --toolStripTitleButtons-

		private void toolStripButton_Min_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void toolStripButton_Max_Click(object sender, EventArgs e)
		{
			if (_maxed || this.WindowState == FormWindowState.Maximized)
			{
				ResizableWindow();
				_maxed = false;
			}
			else
			{
				MaximizeWindow();
				_maxed = true;
			}
		}		

		private void toolStripButton_Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region --toolStripMainButtons--
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
			showForm(new form_SearchMerchandise());
		}

		private void toolStripButton_Category_Click(object sender, EventArgs e)
		{
			showForm(new form_SearchCategory());
		}

		private void toolStripButton_OrderForm_Click(object sender, EventArgs e)
		{
			showForm(new form_Orders());
		}

		private void toolStripButton_QAForm_Click(object sender, EventArgs e)
		{
			showForm(new form_QAList());
		}

		private void toolStripButton_LogOut_Click(object sender, EventArgs e)
		{
			_logOut = true;
			關閉所有視窗ToolStripMenuItem.PerformClick();
			this.Close();
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

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton_LogOut.PerformClick();
		}
		private void 關閉ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton_Exit.PerformClick();
		}

		private void 單一子視窗ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			多重子視窗ToolStripMenuItem.Checked = false;
			_multiMdiChild = false;
			if (ActiveMdiChild != null)
			{
				MdiChildren.Where(o => o != ActiveMdiChild).ToList().ForEach(o => o.Close());
			}
		}

		private void 多重子視窗ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			單一子視窗ToolStripMenuItem.Checked = false;
			_multiMdiChild = true;
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

		private void 大量輸入ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!PermissionCheck.Enable(2)) return;

			new MassInsert.form_MassInsert().ShowDialog();
		}

		private void 整理訂單金額ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!PermissionCheck.Enable(2)) return;

			try
			{
				DialogResult dialogResult = MessageBox.Show($"確認重整所有訂單金額？"
					, "確認重整", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.No) return;
				new MassInsertService().OrganizeAllPayments();
				DisplayGrid.DisplayAll(this, new MessageArgs { Message = "_Order_" });
				MessageBox.Show("整理完畢");
			}
			catch (Exception ex)
			{
				MessageBox.Show("整理失敗，可能原因：" + ex.Message);
			}
		}

		private void 員工管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!PermissionCheck.Enable(1)) return;

			new form_Employee().ShowDialog();
		}
		private void 修改個人資料ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Authentication.EmployeeID < 0) return;

			var dto = new EmployeeServices().Get(Authentication.EmployeeAccount);
			var frm = new form_EmployeeEdit(dto);

			frm.ShowDialog();
		}

		private void 論壇帳號ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Authentication.EmployeeID < 0) return;
			if (Authentication.ForumAccountID == null)
			{
				new form_EmployeeForumAccountAdd(Authentication.EmployeeAccount)
					.ShowDialog();
			}
			else
			{
				new form_EmployeeForumAccountEdit(Authentication.EmployeeAccount,
					Authentication.ForumAccountID.Value).ShowDialog();
			}
		}

		#endregion




		//methods
		private void showForm(Form frm)
		{
			if (!_multiMdiChild)
			{
				MdiChildren.ToList().ForEach(o => o.Close());
			}

			frm.MdiParent = this;
			frm.WindowState = FormWindowState.Maximized;
			Modifier.ModForm(frm);
			frm.Show();
		}		

		private void MaximizeWindow()
		{
			this.WindowState = FormWindowState.Normal;
			var rectangle = Screen.FromControl(this).Bounds;
			this.FormBorderStyle = FormBorderStyle.None;
			Size = new Size(rectangle.Width, rectangle.Height);
			Location = new Point(0, 0);
			Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
			this.Size = new Size(workingRectangle.Width, workingRectangle.Height);
		}

		private void ResizableWindow()
		{
			this.WindowState = FormWindowState.Normal;
			this.ControlBox = false;
			this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			this.Size = new Size(this.Width * 8 / 10, this.Height * 8 / 10);
		}


	}
}
