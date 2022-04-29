using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("experience_block")]
    public partial class ExperienceBlock
    {
        [Key]
        [Column("resume_id")]
        public int ResumeId { get; set; }
        [Key]
        [Column("experience_id")]
        public int ExperienceId { get; set; }
        [Column("title")]
        [StringLength(40)]
        public string Title { get; set; }
        [Column("employer")]
        [StringLength(40)]
        public string Employer { get; set; }
        [Column("start_date")]
        [StringLength(30)]
        public string StartDate { get; set; }
        [Column("end_date")]
        [StringLength(30)]
        public string EndDate { get; set; }
        [Column("important_terms")]
        [StringLength(2000)]
        public string ImportantTerms { get; set; }
        [Column("Total_year_experience", TypeName = "decimal(9,2)")]
        public decimal? TotalYearExperience { get; set; }
        [Column("employer_location")]
        [StringLength(200)]
        public string EmployerLocation { get; set; }
        [Column("job_experience_raw_text", TypeName = "varchar(5000)")]
        public string JobExperienceRawText { get; set; }
        [Column("exp_seq_id")]
        public int? ExpSeqId { get; set; }
    }
}
