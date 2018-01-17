namespace MyBookStore.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookTable")]
    public partial class BookTable
    {
        [Key]
        public int b_id { get; set; }

        [Required]
        [StringLength(30)]
        public string b_nm { get; set; }

        [StringLength(25)]
        public string b_subcat { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string b_desc { get; set; }

        [Required]
        [StringLength(40)]
        public string b_publisher { get; set; }

        [Required]
        [StringLength(20)]
        public string b_edition { get; set; }

        [Required]
        [StringLength(10)]
        public string b_isbn { get; set; }

        public int b_page { get; set; }

        public int b_price { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string b_img { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string b_pdf { get; set; }

        [StringLength(20)]
        public string b_author { get; set; }
    }
}
