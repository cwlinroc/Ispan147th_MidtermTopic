namespace ISpan147.Estore.SqlDataLayer.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Adopt
    {
        public int AdoptID { get; set; }

        public int PetID { get; set; }

        public int MemberID { get; set; }

        public DateTime ApplicationTime { get; set; }

        public virtual Member Member { get; set; }

        public virtual Pet Pet { get; set; }
    }
}
