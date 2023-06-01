namespace ISpan147.Estore.SqlDataLayer.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        public int CommentID { get; set; }

        public DateTime CommentTime { get; set; }

        [StringLength(500)]
        public string CommentContext { get; set; }

        public int ThemeID { get; set; }

        public int ForumAccountID { get; set; }

        public virtual ForumAccount ForumAccount { get; set; }

        public virtual Theme Theme { get; set; }
    }
}
