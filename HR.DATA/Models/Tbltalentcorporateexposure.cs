using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tbltalentcorporateexposure")]
    public partial class Tbltalentcorporateexposure
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int TalentExposureId { get; set; }
        [Column("RESUMEID")]
        public int Resumeid { get; set; }
        public int ExposureId { get; set; }
    }
}
