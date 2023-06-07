using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using prjMidtermTopic.Form_Adopt;
using prjMidtermTopic.form_Merchandise;
using prjMidtermTopic.form_Order;
using prjMidtermTopic.Interfaces;
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
    public partial class form_Adopt : Form,IGrid    
    {
        private List<AdoptDto> _data;
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
        public void Display()
        {
            try
            {
                string adoptIDstring = txt_adoptID.Text;
                int? adoptID = null;
                if(string.IsNullOrEmpty(txt_adoptID.Text) == false)
                {
                    adoptID = int.Parse(txt_adoptID.Text);
                }
                string petIDstring = txt_petID.Text;
                int? petID = null;
                if(string.IsNullOrEmpty (txt_petID.Text) == false )
                {
                    petID = int.Parse(txt_petID.Text);
                }

                List<AdoptDto> gridviewlist = new AdoptRepositories().Search(adoptID, petID, null);
                _data = gridviewlist.ToList();
                dataGridView1.DataSource = _data; 
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"輸入失敗,原因是{ex.Message}");
            }
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = this._data[e.RowIndex].AdoptID;

            var frm = new form_AdoptListEdit(id);
            frm.Owner = this;
            frm.ShowDialog();
        }
        private void OrderByHeader(int columnIndex)
        {
            //if (columnIndex < 0) return;

            //string colProp = dataGridView1.Columns[columnIndex].DataPropertyName;

            //if (_sortMap.TryGetValue(colProp, out Func<OrderGridDto, OrderGridDto, int> func))
            //{
            //    if (_sortedIndex == columnIndex)
            //    {
            //        _data.Sort((x, y) => func(y, x));
            //        _sortedIndex = -1;
            //    }
            //    else
            //    {
            //        _data.Sort((x, y) => func(x, y));
            //        _sortedIndex = columnIndex;
            //    }

            //    dataGridView1.DataSource = _data.Select(dto => dto.ToVM()).ToArray();
            //}

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_Adopt_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var form = new form_AdoptAdd();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
