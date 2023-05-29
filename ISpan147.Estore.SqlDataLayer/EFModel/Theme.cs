namespace ISpan147.Estore.SqlDataLayer.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Theme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Theme()
        {
            comments = new HashSet<comment>();
        }

        public int ThemeID { get; set; }

        [Required]
        [StringLength(15)]
        public string ThemeName { get; set; }

        public DateTime ThemeDateTime { get; set; }

        [Required]
        [StringLength(500)]
        public string ThemeContext { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comments { get; set; }
    }
}
