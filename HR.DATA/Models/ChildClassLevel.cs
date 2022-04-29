using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("child_class_level")]
    public partial class ChildClassLevel
    {
        [Key]
        [Column("child_level_id")]
        public int ChildLevelId { get; set; }
        [Column("parent_level_id")]
        public int? ParentLevelId { get; set; }
        [Column("Level_1_Code")]
        [StringLength(45)]
        public string Level1Code { get; set; }
        [Column("Level_2_Code")]
        [StringLength(45)]
        public string Level2Code { get; set; }
        [Column("Level_3_Code")]
        [StringLength(45)]
        public string Level3Code { get; set; }
        [Column("Level_4_code")]
        [StringLength(45)]
        public string Level4Code { get; set; }
        [Column("Level_5_code")]
        [StringLength(45)]
        public string Level5Code { get; set; }
        [Column("term_id")]
        public int? TermId { get; set; }
        [Column("child_term")]
        [StringLength(200)]
        public string ChildTerm { get; set; }
        [Column("type")]
        [StringLength(15)]
        public string Type { get; set; }
    }
}
