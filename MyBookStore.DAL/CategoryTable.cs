namespace MyBookStore.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CategoryTable")]
    public partial class CategoryTable
    {
        [Key]
        public int cat_id { get; set; }

        [Required]
        [StringLength(30)]
        public string cat_nm { get; set; }
    }
}
