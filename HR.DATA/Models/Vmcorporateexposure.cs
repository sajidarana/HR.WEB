using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    public partial class Vmcorporateexposure
    {
        [Column("resumeId")]
        public int ResumeId { get; set; }
        [Column("exposureId")]
        public int ExposureId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
