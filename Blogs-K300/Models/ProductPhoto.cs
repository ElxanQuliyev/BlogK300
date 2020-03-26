namespace Blogs_K300.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductPhoto")]
    public partial class ProductPhoto
    {
        public int Id { get; set; }

        [StringLength(800)]
        public string Photo { get; set; }

        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
