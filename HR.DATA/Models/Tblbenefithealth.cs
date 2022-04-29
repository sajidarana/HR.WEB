using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblbenefithealth")]
    public partial class Tblbenefithealth
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int HealthId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
