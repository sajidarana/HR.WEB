using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("resume_word_count")]
    public partial class ResumeWordCount
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("resume_id")]
        public int? ResumeId { get; set; }
        [Column("count_of_word")]
        public int? CountOfWord { get; set; }
    }
}
