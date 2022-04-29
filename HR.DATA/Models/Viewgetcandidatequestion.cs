using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    public partial class Viewgetcandidatequestion
    {
        public int No { get; set; }
        public string Question { get; set; }
        [StringLength(45)]
        public string Type { get; set; }
        [Column("idtblCandidateReply")]
        public int? IdtblCandidateReply { get; set; }
        [Column("resume_id")]
        public int? ResumeId { get; set; }
        [Column("questionid")]
        public int? Questionid { get; set; }
        [Column("priority")]
        [StringLength(45)]
        public string Priority { get; set; }
        [Column("value")]
        [StringLength(45)]
        public string Value { get; set; }
    }
}
