namespace MyBookStore.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTable")]
    public partial class UserTable
    {
        [Key]
        public int u_id { get; set; }

        [Required]
        [StringLength(35)]
        public string u_fnm { get; set; }

        [Required]
        [StringLength(35)]
        public string u_lname { get; set; }

        [Required]
        [StringLength(25)]
        public string u_unm { get; set; }

        [Required]
        [StringLength(20)]
        public string u_pwd { get; set; }

        [Required]
        [StringLength(7)]
        public string u_gender { get; set; }

        [Required]
        [StringLength(35)]
        public string u_email { get; set; }

        [Required]
        [StringLength(12)]
        public string u_contact { get; set; }

        [Required]
        [StringLength(20)]
        public string u_city { get; set; }
    }
}
