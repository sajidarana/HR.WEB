using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    [Table("resume_section_info")]
    public partial class ResumeSectionInfo
    {
        [Column("section_info_id")]
        public int SectionInfoId { get; set; }
        [Column("resume_id")]
        public int? ResumeId { get; set; }
        [Column("section_name")]
        [StringLength(100)]
        public string SectionName { get; set; }
        [Column("section_line_number")]
        public short? SectionLineNumber { get; set; }
    }
}
