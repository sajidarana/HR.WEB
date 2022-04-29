using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("resume_header")]
    [Index(nameof(ResumeId), Name = "resume_id")]
    [Index(nameof(ResumeRawText), Name = "resume_raw_text")]
    public partial class ResumeHeader
    {
        public ResumeHeader()
        {
            Tblbenefitdemands = new HashSet<Tblbenefitdemand>();
            Tblcandidatereplies = new HashSet<Tblcandidatereply>();
            Tbltalentskills = new HashSet<Tbltalentskill>();
            Tbltalenttools = new HashSet<Tbltalenttool>();
        }

        [Column("talent_id", TypeName = "decimal(9,0)")]
        public decimal TalentId { get; set; }
        [Column("file_id")]
        public int? FileId { get; set; }
        [Key]
        [Column("resume_id")]
        public int ResumeId { get; set; }
        [Column("total_lines_of_text")]
        public int? TotalLinesOfText { get; set; }
        [Column("total_number_of_terms")]
        public int? TotalNumberOfTerms { get; set; }
        [Column("total_years_of_experience", TypeName = "decimal(9,2)")]
        public decimal? TotalYearsOfExperience { get; set; }
        [Column("total_no_of_employers")]
        public int? TotalNoOfEmployers { get; set; }
        [Column("primary_title_in_header")]
        [StringLength(200)]
        public string PrimaryTitleInHeader { get; set; }
        [Column("objective_or_summary_yn")]
        public string ObjectiveOrSummaryYn { get; set; }
        [Column("resume_raw_text", TypeName = "text")]
        public string ResumeRawText { get; set; }
        [Column("resume_doc_type")]
        [StringLength(10)]
        public string ResumeDocType { get; set; }
        [Column("number_of_page")]
        [StringLength(50)]
        public string NumberOfPage { get; set; }
        [Column("industry")]
        [StringLength(500)]
        public string Industry { get; set; }
        [Column("Manager_level")]
        public int? ManagerLevel { get; set; }
        [Column("postalCode")]
        [StringLength(50)]
        public string PostalCode { get; set; }
        public int? DisciplineId { get; set; }
        public int? OccupationId { get; set; }
        [Column("specialityId")]
        public int? SpecialityId { get; set; }
        [Column("subspecialityId")]
        public int? SubspecialityId { get; set; }
        public int? ExperienceLevelId { get; set; }
        public int EducationLevelId { get; set; }
        public int? ExperienceTrackId { get; set; }
        public int? IsAvailable { get; set; }
        public int? IsAtivelyLooking { get; set; }
        public int? IndustryId { get; set; }
        public int? VacationId { get; set; }
        public int? SeniorityId { get; set; }

        [InverseProperty(nameof(Tblbenefitdemand.Resume))]
        public virtual ICollection<Tblbenefitdemand> Tblbenefitdemands { get; set; }
        [InverseProperty(nameof(Tblcandidatereply.Resume))]
        public virtual ICollection<Tblcandidatereply> Tblcandidatereplies { get; set; }
        [InverseProperty(nameof(Tbltalentskill.Resume))]
        public virtual ICollection<Tbltalentskill> Tbltalentskills { get; set; }
        [InverseProperty(nameof(Tbltalenttool.Resume))]
        public virtual ICollection<Tbltalenttool> Tbltalenttools { get; set; }
    }
}
