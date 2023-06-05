namespace ISpan147.Estore.SqlDataLayer.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pet()
        {
            Adopts = new HashSet<Adopt>();
        }

        public int PetID { get; set; }

        public int SpeciesID { get; set; }

        public int BreedID { get; set; }

        [Required]
        [StringLength(15)]
        public string PetName { get; set; }

        public bool Gender { get; set; }

        public int? Age { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(30)]
        public string Location { get; set; }

        [StringLength(50)]
        public string PetAvatar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adopt> Adopts { get; set; }

        public virtual Breed Breed { get; set; }

        public virtual Species Species { get; set; }
    }
}
