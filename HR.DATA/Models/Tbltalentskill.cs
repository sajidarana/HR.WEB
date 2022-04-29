using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tbltalentskill")]
    [Index(nameof(Resumeid), Name = "FK_ResumeId_idx")]
    public partial class Tbltalentskill
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int TalentSkillId { get; set; }
        [Column("RESUMEID")]
        public int Resumeid { get; set; }
        [Column(TypeName = "mediumint")]
        public int SkillId { get; set; }

        [ForeignKey(nameof(Resumeid))]
        [InverseProperty(nameof(ResumeHeader.Tbltalentskills))]
        public virtual ResumeHeader Resume { get; set; }
    }
}
