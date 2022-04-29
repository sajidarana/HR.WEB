using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("migrations")]
    public partial class Migration
    {
        [Key]
        [Column("id", TypeName = "int unsigned")]
        public int Id { get; set; }
        [Required]
        [Column("migration")]
        [StringLength(191)]
        public string Migration1 { get; set; }
        [Column("batch")]
        public int Batch { get; set; }
    }
}
