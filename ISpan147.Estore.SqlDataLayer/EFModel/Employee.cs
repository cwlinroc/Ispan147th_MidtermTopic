namespace ISpan147.Estore.SqlDataLayer.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(20)]
        public string EmployeeName { get; set; }

        [Required]
        [StringLength(20)]
        public string EmployeeAccount { get; set; }

        [Required]
        [StringLength(65)]
        public string EmployeePassword { get; set; }

        public int Permission { get; set; }
    }
}
