using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblcorporateexposure")]
    public partial class Tblcorporateexposure
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int ExposureId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
