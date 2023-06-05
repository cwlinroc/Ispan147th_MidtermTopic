using ISpan147.Estore.SqlDataLayer.Dtos;
using prjMidtermTopic.form_Order;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prjMidtermTopic
{
    public partial class form_Adopt : Form
    {
        private List<AdoptGridDto> _data;
        private int _row = -1;

        private int _sortedIndex = 0;
        private readonly Dictionary<string, Func<AdoptGridDto, AdoptGridDto, int>> _sortMap;
        public form_Adopt()
        {
            InitializeComponent();
            _sortMap = new Dictionary<string, Func<AdoptGridDto, AdoptGridDto, int>>
            {
                { "AdoptID", (prev, next) => prev.AdoptID.CompareTo(next.AdoptID) },
                { "PetID", (prev, next) => prev.PetID.CompareTo(next.PetID)},
                { "MemberID", (prev, next) => prev.MemberID.CompareTo(next.MemberID) },
                {"ApplicationTime", (prev, next) => prev.ApplicationTime.CompareTo(next.ApplicationTime) },
                {"MemberName", (prev, next) => prev.MemberName.CompareTo(next.MemberName) },
                { "PetName", (prev, next) => prev.PetName.CompareTo(next.PetName)}

            };

            
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                OrderByHeader(e.ColumnIndex);
                return;
            }
            var frm = new form_OrderList(_data[_row].OrderID);
            frm.Owner = this;
            frm.ShowDialog();
        }
        private void OrderByHeader(int columnIndex)
        {
            if (columnIndex < 0) return;

            string colProp = dataGridView_Main.Columns[columnIndex].DataPropertyName;

            if (_sortMap.TryGetValue(colProp, out Func<OrderGridDto, OrderGridDto, int> func))
            {
                if (_sortedIndex == columnIndex)
                {
                    _data.Sort((x, y) => func(y, x));
                    _sortedIndex = -1;
                }
                else
                {
                    _data.Sort((x, y) => func(x, y));
                    _sortedIndex = columnIndex;
                }

                dataGridView_Main.DataSource = _data.Select(dto => dto.ToVM()).ToArray();
            }

        }
        //private void AutoDisplay(object sender, EventArgs e)
        //{
        //    string message = (e as MessageArgs).Message;
        //    if (!string.IsNullOrEmpty(message) && !message.Contains("_Order_")) return;

        //    Display();
        //}
    }
}
