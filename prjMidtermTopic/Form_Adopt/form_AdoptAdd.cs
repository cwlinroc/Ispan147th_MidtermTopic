using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            try {
                var map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase) {
                    { "PetID" , txt_petID },
                    { "MemberID" , txt_memberID },
                    { "ApplicationTime" , dateTimePicker1 },

                };


                bool PetIDint = int.TryParse(txt_petID.Text, out int petId);
                petId = PetIDint ? petId : 0;
                bool MemberIDint = int.TryParse(txt_memberID.Text, out int MemberId);
                MemberId = MemberIDint ? MemberId : 0;

                var vm = new AdoptVM()
                {
                    PetID = petId,
                    MemberID = MemberId,
                    ApplicationTime = dateTimePicker1.Value
                };

                bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, map);
                if (hasError)
                {
                    return;
                }
                AdoptDto adoptDto = new AdoptDto()
                {
                    PetID = vm.PetID,
                    MemberID = vm.MemberID,
                    ApplicationTime = vm.ApplicationTime.Value
                };
                AdoptService adoptService = new AdoptService();
                int adoptId = adoptService.Create(adoptDto);
                MessageBox.Show($"輸入成功,ID是{adoptId}");
                IGrid parent = Owner as IGrid;
                parent.Display();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"輸入失敗,原因是{ex.Message}");
            }
            
        }
    }
}
