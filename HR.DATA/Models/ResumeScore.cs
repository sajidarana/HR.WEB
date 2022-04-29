using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("resume_score")]
    public partial class ResumeScore
    {
        [Key]
        [Column("score_id")]
        public int ScoreId { get; set; }
        [Column("resume_id")]
        public int? ResumeId { get; set; }
        [Column("Variable_Name")]
        [StringLength(200)]
        public string VariableName { get; set; }
        [Column("Score_Matrix")]
        public int? ScoreMatrix { get; set; }
        [Column("Variable_Score")]
        public int? VariableScore { get; set; }
        [Column("Variable_Behaviour")]
        [StringLength(45)]
        public string VariableBehaviour { get; set; }
        [Required]
        public string Remarks { get; set; }
    }
}
