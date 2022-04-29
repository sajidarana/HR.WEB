using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblbenefitdemand")]
    [Index(nameof(BenefitId), Name = "fk_BeenfitId_idx")]
    [Index(nameof(ResumeId), Name = "fk_ResumeID1_idx")]
    public partial class Tblbenefitdemand
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int? ResumeId { get; set; }
        public int? BenefitId { get; set; }

        [ForeignKey(nameof(BenefitId))]
        [InverseProperty(nameof(Tblbenefit.Tblbenefitdemands))]
        public virtual Tblbenefit Benefit { get; set; }
        [ForeignKey(nameof(ResumeId))]
        [InverseProperty(nameof(ResumeHeader.Tblbenefitdemands))]
        public virtual ResumeHeader Resume { get; set; }
    }
}
