using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    [Table("phrases_on_experience_block")]
    public partial class PhrasesOnExperienceBlock
    {
        [Column("resume_id")]
        public int ResumeId { get; set; }
        [Column("experience_id")]
        public int ExperienceId { get; set; }
        [Column("term_id")]
        [StringLength(50)]
        public string TermId { get; set; }
        [Required]
        [Column("phrases_term")]
        [StringLength(200)]
        public string PhrasesTerm { get; set; }
    }
}
