namespace MyBookStore.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubcatTable")]
    public partial class SubcatTable
    {
        [Key]
        public int subcat_id { get; set; }

        public int parent_id { get; set; }

        [Required]
        [StringLength(35)]
        public string subcat_nm { get; set; }
    }
}
