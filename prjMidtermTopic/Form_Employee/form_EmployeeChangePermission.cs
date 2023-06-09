﻿using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
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

namespace prjMidtermTopic.Form_Employee
{
	public partial class form_EmployeeChangePermission : Form
	{
		private EmployeeDto _dto;

		private readonly string[] _permissions = new string[] { "1", "2", "3", "4", "5" };
		public form_EmployeeChangePermission(EmployeeDto dto)
		{
			InitializeComponent();

			comboBox_Permission.Items.AddRange(_permissions);
			comboBox_Permission.SelectedIndex = dto.Permission - 1;
			_dto = dto;
		}

		private void btn_Change_Click(object sender, EventArgs e)
		{
			try
			{
				var permission = comboBox_Permission.SelectedIndex + 1;

				DialogResult dialogResult = MessageBox.Show($"確定更改{_dto.EmployeeName}的權限為{permission}？",
					"確認更改權限", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.No) return;

				_dto.Permission = permission;

				new EmployeeRepositoy().Update(_dto);

				MessageBox.Show("更改成功!!");

				var parent = Owner as IGrid;

				if (parent != null) parent.Display();

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("更改失敗，可能原因：" + ex.Message);
			}

		}


	}
}
