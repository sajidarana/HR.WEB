using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tbltalentbenefithealth")]
    public partial class Tbltalentbenefithealth
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int TalentHealthId { get; set; }
        [Column("RESUMEID")]
        public int Resumeid { get; set; }
        public int HealthId { get; set; }
    }
}
