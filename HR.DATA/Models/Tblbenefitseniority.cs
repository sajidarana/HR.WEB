using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblbenefitseniority")]
    public partial class Tblbenefitseniority
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int SeniorityId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
