using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.Form_Adopt
{
    public partial class form_AdoptAdd : Form
    {
        public form_AdoptAdd()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void commit_button(object sender, EventArgs e)
        {
            //try
            //{
            //    var vm = new AdoptVM()
            //    {
            //        AdoptID
            //        MemberID = txt_MemberID.Text.Trim(),
            //        PaymentMethod = comboBox_PayMethod.SelectedItem?.ToString(),
            //        Payed = comboBox_Payed.SelectedItem?.ToString(),
            //        PurchaseTime = dateTimePicker_PurchaseTime.Value,
            //        PaymentAmount = txt_PaymentAmount.Text.Trim(),
            //    };

            //    var map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase) {
            //        { "OrderID" , txt_OrderID },
            //        { "MemberID" , txt_MemberID },
            //        { "PaymentMethod" , comboBox_PayMethod },
            //        { "Payed" , comboBox_Payed },
            //        { "PurchaseTime", dateTimePicker_PurchaseTime },
            //        { "PaymentAmount", txt_PaymentAmount }
            //    };

            //    bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, map);

            //    if (hasError) return;

            //    int newId = new OrderService().Create(vm.ToDto());

            //    MessageBox.Show($"輸入成功，ID為{newId}");

            //    DisplayGrid.DisplayAll(this, new MessageArgs { Message = "_Order_" });

            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("新增失敗，可能原因：" + ex.Message);
            //}
        }
    }
}
