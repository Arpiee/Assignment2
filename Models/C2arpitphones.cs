namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("2arpitphones")]
    public partial class C2arpitphones
    {
        public int s_no { get; set; }

        [Key]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(100)]
        public string Condition { get; set; }

        public int Rating { get; set; }
    }
}
