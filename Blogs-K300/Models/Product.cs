namespace Blogs_K300.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductPhotoes = new HashSet<ProductPhoto>();
        }

        public int Id { get; set; }

        [StringLength(70)]
        public string ProductName { get; set; }

        [StringLength(800)]
        public string Photo { get; set; }

        public string Description { get; set; }

        public int? CategoryId { get; set; }

        public int? LanguageId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Language Language { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductPhoto> ProductPhotoes { get; set; }
    }
}
