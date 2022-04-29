using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    public partial class Vmtalenttool
    {
        [Column(TypeName = "mediumint")]
        public int ToolId { get; set; }
        [Column("toolname")]
        [StringLength(40)]
        public string Toolname { get; set; }
        public int? DisciplineId { get; set; }
        [Column("specialityId")]
        public int? SpecialityId { get; set; }
        public int? OccupationId { get; set; }
        [Column("subspecialityId")]
        public int? SubspecialityId { get; set; }
        [Column("resume_id")]
        public int ResumeId { get; set; }
    }
}
