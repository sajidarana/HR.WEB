using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tbltalenttool")]
    [Index(nameof(Resumeid), Name = "FK_ResumeId_idx")]
    public partial class Tbltalenttool
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int TalentToolId { get; set; }
        [Column("RESUMEID")]
        public int Resumeid { get; set; }
        [Column(TypeName = "mediumint")]
        public int ToolId { get; set; }

        [ForeignKey(nameof(Resumeid))]
        [InverseProperty(nameof(ResumeHeader.Tbltalenttools))]
        public virtual ResumeHeader Resume { get; set; }
    }
}
