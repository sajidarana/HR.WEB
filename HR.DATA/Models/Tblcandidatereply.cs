using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblcandidatereply")]
    [Index(nameof(Questionid), Name = "qid_idx")]
    [Index(nameof(ResumeId), Name = "res_id_idx")]
    public partial class Tblcandidatereply
    {
        [Key]
        [Column("idtblCandidateReply")]
        public int IdtblCandidateReply { get; set; }
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

        [ForeignKey(nameof(Questionid))]
        [InverseProperty(nameof(Tblquestionsforcandidate.Tblcandidatereplies))]
        public virtual Tblquestionsforcandidate Question { get; set; }
        [ForeignKey(nameof(ResumeId))]
        [InverseProperty(nameof(ResumeHeader.Tblcandidatereplies))]
        public virtual ResumeHeader Resume { get; set; }
    }
}
