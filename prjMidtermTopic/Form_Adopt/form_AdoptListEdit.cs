using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Services;
using prjMidtermTopic.Interfaces;
using prjMidtermTopic.Model;
using prjMidtermTopic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMidtermTopic.Form_Adopt
{
    public partial class form_AdoptListEdit : Form
    {
        private int _id;

       
        public form_AdoptListEdit(int id)
        {
            this._id = id;
            InitializeComponent();
        }

        private void form_AdoptListEdit_Load(object sender, EventArgs e)
        {
            var repo = new AdoptRepositories();
            AdoptDto dto = repo.GetById(_id);
            if(dto == null)
            {
                MessageBox.Show("無此紀錄");
                return;
            }
            txt_MemberID.Text = dto.MemberID.ToString();
            txt_petID.Text = dto.PetID.ToString();
            dateTimePicker1.Value = dto.ApplicationTime;

			if (Authentication.Permission > 4)
			{
				button1.Enabled = false;
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
                {
                    { "PetID",txt_petID },
                    {"MemberID", txt_MemberID },
                    {"ApplicationTime",dateTimePicker1 }
                };
                bool pet_id = int.TryParse(txt_petID.Text, out int petID);
                petID = pet_id ? petID : 0;
                bool member_id = int.TryParse(txt_MemberID.Text, out int memberID);
                memberID = member_id ? memberID : 0;
                var vm = new AdoptVM()
                {
                    AdoptID = _id,
                    PetID = petID,
                    MemberID = memberID,
                    ApplicationTime = dateTimePicker1.Value
                };
                bool hasError = MyValidator.ValidateAndDisplay(vm, errorProvider1, map);
                if (hasError)
                {
                    return;
                }
                AdoptDto dto = new AdoptDto()
                {
                    AdoptID = vm.AdoptID,
                    MemberID = vm.MemberID,
                    PetID = vm.PetID,
                    ApplicationTime = vm.ApplicationTime.Value
                };
                AdoptService adoptService = new AdoptService();
                int adoptId = adoptService.Update(dto);
                MessageBox.Show($"輸入成功");
                IGrid parent = Owner as IGrid;
                parent.Display();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"輸入失敗,原因是輸入的格式不正確");
            }
            
        }
    }
}
