using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    [Table("term_on_resume")]
    public partial class TermOnResume
    {
        [Column("resume_id")]
        public int ResumeId { get; set; }
        [Column("term_id")]
        public int TermId { get; set; }
    }
}
