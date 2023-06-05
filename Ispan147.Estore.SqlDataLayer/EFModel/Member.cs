namespace ISpan147.Estore.SqlDataLayer.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            Adopts = new HashSet<Adopt>();
            Orders = new HashSet<Order>();
        }

        public int MemberID { get; set; }

        [Required]
        [StringLength(30)]
        public string MemberName { get; set; }
        		
		public int? ForumAccountID { get; set; }

		[StringLength(30)]
        public string NickName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        public bool Gender { get; set; }

        [Required]
        [StringLength(15)]
        public string Account { get; set; }

        [Required]
        [StringLength(65)]
        public string Password { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(30)]
        public string Address { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Avatar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adopt> Adopts { get; set; }

        public virtual ForumAccount ForumAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
