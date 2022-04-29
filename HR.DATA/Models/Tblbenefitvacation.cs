using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblbenefitvacation")]
    public partial class Tblbenefitvacation
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int VacationId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
