﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
		private MdiLayout _mdiLayout = MdiLayout.TileHorizontal;
		public form_Main()
		{
			InitializeComponent();
			toolStrip_Main.Renderer = new NoEdgeRenderer();
			toolStrip_Title.Renderer = new NoEdgeRenderer();
			menuStrip_Main.Renderer = new ColoredRenderer();

			MaximizeWindow();

			if (!Directory.Exists(@"images/MerchandisePicture/"))
			{
				Directory.CreateDirectory(@"images/MerchandisePicture/");
			}
			if (!Directory.Exists(@"images/avatar/"))
			{
				Directory.CreateDirectory(@"images/avatar/");
			}
			if (!Directory.Exists(@"images/petavatar/"))
			{
				Directory.CreateDirectory(@"images/petavatar/");
			}
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

		private void toolStripButton_SingleForm_Click(object sender, EventArgs e)
		{
			單一子視窗ToolStripMenuItem.PerformClick();
		}

		private void toolStripButton_MultiForm_Click(object sender, EventArgs e)
		{
			多重子視窗ToolStripMenuItem.PerformClick();
		}

		private void toolStrip_CloseAllForm_Click(object sender, EventArgs e)
		{
			關閉所有視窗ToolStripMenuItem.PerformClick();
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

			toolStripButton_SingleForm.Image = Properties.Resources.selected;
			toolStripButton_MultiForm.Image = Properties.Resources.empty;

			if (ActiveMdiChild != null)
			{
				MdiChildren.Where(o => o != ActiveMdiChild).ToList().ForEach(o => o.Close());
				ActiveMdiChild.WindowState = FormWindowState.Maximized;
			}
		}

		private void 多重子視窗ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			單一子視窗ToolStripMenuItem.Checked = false;
			_multiMdiChild = true;

			toolStripButton_SingleForm.Image = Properties.Resources.empty;
			toolStripButton_MultiForm.Image = Properties.Resources.selected;
		}

		private void 水平排列ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
			_mdiLayout = MdiLayout.TileHorizontal;

			//水平排列ToolStripMenuItem.Checked = false;
			垂直排列ToolStripMenuItem.Checked = false;
			階梯排列ToolStripMenuItem.Checked = false;
		}

		private void 垂直排列ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
			_mdiLayout = MdiLayout.TileVertical;

			水平排列ToolStripMenuItem.Checked = false;
			//垂直排列ToolStripMenuItem.Checked = false;
			階梯排列ToolStripMenuItem.Checked = false;
		}

		private void 階梯排列ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
			_mdiLayout = MdiLayout.Cascade;

			水平排列ToolStripMenuItem.Checked = false;
			垂直排列ToolStripMenuItem.Checked = false;
			//階梯排列ToolStripMenuItem.Checked = false;
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

			var frm = new MassInsert.form_MassInsert();
			Modifier.ModForm(frm);
			frm.ShowDialog();
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

			var frm = new form_Employee();
			Modifier.ModForm(frm);
			frm.ShowDialog();
		}
		private void 修改個人資料ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Authentication.EmployeeID < 0) return;

			var dto = new EmployeeServices().Get(Authentication.EmployeeAccount);
			var frm = new form_EmployeeEdit(dto);

			Modifier.ModForm(frm);
			frm.ShowDialog();
		}

		private void 論壇帳號ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Authentication.EmployeeID < 0) return;
			if (Authentication.ForumAccountID == null)
			{
				var frm = new form_EmployeeForumAccountAdd(Authentication.EmployeeAccount);
				Modifier.ModForm(frm);
				frm.ShowDialog();
			}
			else
			{
				//todo 論壇帳號ID
				var frm = new form_EmployeeForumAccountEdit(Authentication.EmployeeAccount,
					Authentication.ForumAccountID.Value);
				Modifier.ModForm(frm);
				frm.ShowDialog();
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

			if (_multiMdiChild)
			{
				LayoutMdi(_mdiLayout);
			}
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
