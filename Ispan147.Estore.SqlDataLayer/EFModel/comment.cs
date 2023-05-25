namespace ISpan147.Estore.SqlDataLayer.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comment
    {
        [Key]
        public int CommonID { get; set; }

        [Required]
        [StringLength(15)]
        public string CommonName { get; set; }

        public DateTime CommonTime { get; set; }

        [StringLength(500)]
        public string CommonContext { get; set; }

        public int ThemeID { get; set; }

        public virtual Theme Theme { get; set; }
    }
}
