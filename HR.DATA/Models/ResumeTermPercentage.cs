using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("resume_term_percentage")]
    public partial class ResumeTermPercentage
    {
        [Key]
        [Column("resume_term_id")]
        public int ResumeTermId { get; set; }
        [Column("resume_id")]
        public int? ResumeId { get; set; }
        [Column("parent_level_id")]
        public int? ParentLevelId { get; set; }
        [Column("level_1_code")]
        [StringLength(45)]
        public string Level1Code { get; set; }
        [Column("level_2_code")]
        [StringLength(45)]
        public string Level2Code { get; set; }
        [Column("level_3_code")]
        [StringLength(45)]
        public string Level3Code { get; set; }
        [Column("level_4_code")]
        [StringLength(45)]
        public string Level4Code { get; set; }
        [Column("level_5_code")]
        [StringLength(45)]
        public string Level5Code { get; set; }
        [Column("term_percentage")]
        public int? TermPercentage { get; set; }
    }
}
