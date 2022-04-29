using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("parent_class_level")]
    public partial class ParentClassLevel
    {
        [Key]
        [Column("parent_level_id")]
        public int ParentLevelId { get; set; }
        [Column("Level_1_Code")]
        [StringLength(45)]
        public string Level1Code { get; set; }
        [Column("Level_1_Description")]
        [StringLength(200)]
        public string Level1Description { get; set; }
        [Column("Level_2_Code")]
        [StringLength(45)]
        public string Level2Code { get; set; }
        [Column("Level_2_Description")]
        [StringLength(200)]
        public string Level2Description { get; set; }
        [Column("Level_3_Code")]
        [StringLength(45)]
        public string Level3Code { get; set; }
        [Column("Level_3_Description")]
        [StringLength(200)]
        public string Level3Description { get; set; }
        [Column("Level_4_code")]
        [StringLength(45)]
        public string Level4Code { get; set; }
        [Column("Level_4_Description")]
        [StringLength(200)]
        public string Level4Description { get; set; }
        [Column("Level_5_code")]
        [StringLength(45)]
        public string Level5Code { get; set; }
        [Column("Level_5_Description")]
        [StringLength(200)]
        public string Level5Description { get; set; }
    }
}
