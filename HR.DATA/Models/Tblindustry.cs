using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblindustry")]
    public partial class Tblindustry
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int IndustryId { get; set; }
        [StringLength(40)]
        public string IndustryCode { get; set; }
        [Required]
        [StringLength(100)]
        public string IndustryName { get; set; }
        public int? IndustryVertical { get; set; }
    }
}
