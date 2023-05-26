namespace ISpan147.Estore.SqlDataLayer.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderList
    {
        public int OrderListID { get; set; }

        public int OrderID { get; set; }

        public int MerchandiseID { get; set; }

        public int Quantity { get; set; }

        public virtual Merchandise Merchandise { get; set; }

        public virtual Order Order { get; set; }
    }
}
