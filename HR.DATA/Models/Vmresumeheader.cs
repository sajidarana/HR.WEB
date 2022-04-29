using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    public partial class Vmresumeheader
    {
        [Column("talent_id", TypeName = "decimal(9,0)")]
        public decimal TalentId { get; set; }
        [Column("file_id")]
        public int? FileId { get; set; }
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
        [Column("resume_raw_text")]
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
        [Column("countyname")]
        [StringLength(255)]
        public string Countyname { get; set; }
        [Column("usstate")]
        [StringLength(255)]
        public string Usstate { get; set; }
        [Column("combinedname")]
        [StringLength(255)]
        public string Combinedname { get; set; }
        [Column("cbsa_name")]
        [StringLength(255)]
        public string CbsaName { get; set; }
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
        [Column("isComapre")]
        public int IsComapre { get; set; }
        [Column("isShortlist")]
        public int IsShortlist { get; set; }
        [Column("isContacted")]
        public int IsContacted { get; set; }
    }
}
