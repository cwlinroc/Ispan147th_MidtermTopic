using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prjMidtermTopic.Form_Employee
{

	public partial class form_Employee : Form, IGrid
	{
		private List<EmployeeDto> _data;
		private int _row = 0;
		public form_Employee()
		{
			
			InitializeComponent();
			Load += Form_Employee_Load;
		}

		private void Form_Employee_Load(object sender, EventArgs e)
		{			
			Display();
		}

		private void dataGridView_Main_SelectionChanged(object sender, EventArgs e)
		{
			_row = dataGridView_Main.CurrentCell.RowIndex;
		}

		private void btn_AddEmployee_Click(object sender, EventArgs e)
		{
			var frm = new form_EmployeeAdd();
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void btn_ResetPassword_Click(object sender, EventArgs e)
		{
			var dto = _data[_row];
			var frm = new form_EmployeeResetPassword(dto);
			frm.ShowDialog();
		}

		private void btn_ChangePermission_Click(object sender, EventArgs e)
		{
			var dto = _data[_row];
			var frm = new form_EmployeeChangePermission(dto);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void btn_RemoveEmployee_Click(object sender, EventArgs e)
		{
			try
			{
				var dto = _data[_row];
				new EmployeeRepositoy().Delete(dto.EmployeeAccount);
				MessageBox.Show("刪除成功!");
				Display();
			}
			catch (Exception ex)
			{
				MessageBox.Show("刪除失敗，可能原因：" + ex.Message);
			}
		}

		public void Display()
		{
			try
			{
				_data = new EmployeeRepositoy().GetAll();

				dataGridView_Main.DataSource = _data;
			}
			catch (Exception ex)
			{
				MessageBox.Show("資料查詢失敗，可能原因：" + ex.Message);
			}
		}

	}
}
