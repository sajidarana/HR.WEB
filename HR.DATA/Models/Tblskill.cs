using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblskill")]
    public partial class Tblskill
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int SkillId { get; set; }
        [StringLength(40)]
        public string IndustryCodE { get; set; }
        [StringLength(40)]
        public string SkillName { get; set; }
        [StringLength(80)]
        public string SkillDescription { get; set; }
        [StringLength(10)]
        public string PreimumIndicator { get; set; }
        [StringLength(40)]
        public string HotIndicator { get; set; }
        [Column(TypeName = "float(12,4)")]
        public float? PremiumRateFactor { get; set; }
        public int? DisciplineId { get; set; }
    }
}
