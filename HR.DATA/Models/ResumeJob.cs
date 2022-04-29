using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    [Table("resume_job")]
    public partial class ResumeJob
    {
        [Column("jobId")]
        public int JobId { get; set; }
        [Column("resume_id")]
        public int? ResumeId { get; set; }
        [Column("specialityId")]
        public int? SpecialityId { get; set; }
        [Column("subspecialityId")]
        public int? SubspecialityId { get; set; }
    }
}
