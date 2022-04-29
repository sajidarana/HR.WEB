using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblbenefitextraearning")]
    public partial class Tblbenefitextraearning
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int EarningId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
