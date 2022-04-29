using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tbltalentbenefitextraearning")]
    public partial class Tbltalentbenefitextraearning
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int TalentEarningId { get; set; }
        [Column("RESUMEID")]
        public int Resumeid { get; set; }
        [Column("EarningID")]
        public int EarningId { get; set; }
    }
}
