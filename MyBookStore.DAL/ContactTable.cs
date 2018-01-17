namespace MyBookStore.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactTable")]
    public partial class ContactTable
    {
        [Key]
        public int con_id { get; set; }

        [Required]
        [StringLength(25)]
        public string con_nm { get; set; }

        [Required]
        [StringLength(35)]
        public string con_email { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string con_query { get; set; }
    }
}
