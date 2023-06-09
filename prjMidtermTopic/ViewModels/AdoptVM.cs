﻿using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prjMidtermTopic.ViewModels
{
    public class AdoptVM
    {
        [Display(Name = "領養編號")]
        [Required(ErrorMessage = "{0}必填")]        
        public int AdoptID { get; set; }
        [Display(Name = "寵物編號")]
        [Required(ErrorMessage = "{0}必填")]
        [Range(1, int.MaxValue, ErrorMessage = "{0}必須為大於0的數字")]
        public int PetID { get; set; }
        [Display(Name = "會員編號")]
        [Required(ErrorMessage = "{0}必填")]
        [Range(1, int.MaxValue, ErrorMessage = "{0}必須為大於0的數字")]
        public int MemberID { get; set; }

        [Display(Name = "顧客姓名")]
        public string MemberName { get; set; }
        [Display(Name = "申請時間")]
        [Required(ErrorMessage = "{0}必填")]
        public DateTime? ApplicationTime { get; set; }
    }
    static public class Adopt
    {

        static public AdoptDto ToDto(this AdoptVM vm)
        {
            var dto = new AdoptDto
            {
                AdoptID = vm.AdoptID,
                PetID = vm.PetID,
                MemberID = vm.MemberID,
                ApplicationTime = vm.ApplicationTime.Value,
            };



            return dto;
        }
        static public AdoptVM ToVM(this AdoptGridDto dto)
        {
            return new AdoptVM
            {
                AdoptID = dto.AdoptID,
                PetID = dto.PetID,
                MemberID = dto.MemberID,
                ApplicationTime = dto.ApplicationTime

            };
        }

    }
}
