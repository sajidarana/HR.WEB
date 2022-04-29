using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tbltool")]
    public partial class Tbltool
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int ToolId { get; set; }
        [StringLength(40)]
        public string IndustryCodE { get; set; }
        [StringLength(40)]
        public string ToolName { get; set; }
        [StringLength(40)]
        public string Vendor { get; set; }
        [StringLength(10)]
        public string Generation { get; set; }
        [StringLength(80)]
        public string ToolDescription { get; set; }
        [StringLength(40)]
        public string ToolClass { get; set; }
        [StringLength(40)]
        public string DisciplineId { get; set; }
    }
}
