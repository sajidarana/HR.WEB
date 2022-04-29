using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("education_updated")]
    public partial class EducationUpdated
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("resume_id")]
        public int ResumeId { get; set; }
        [Column("education_id")]
        public int EducationId { get; set; }
        [Column("eduction_title")]
        [StringLength(100)]
        public string EductionTitle { get; set; }
        [Column("start_date", TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column("end_date", TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column("school_or_college")]
        [StringLength(80)]
        public string SchoolOrCollege { get; set; }
        [Column("city")]
        [StringLength(40)]
        public string City { get; set; }
        [Column("state")]
        [StringLength(20)]
        public string State { get; set; }
        [Column("country")]
        [StringLength(20)]
        public string Country { get; set; }
        [Column("certificate_or_short_course_yn")]
        [StringLength(1)]
        public string CertificateOrShortCourseYn { get; set; }
        [Column("university_location")]
        [StringLength(200)]
        public string UniversityLocation { get; set; }
        [Column("isEnabled", TypeName = "bit(1)")]
        public bool? IsEnabled { get; set; }
    }
}
