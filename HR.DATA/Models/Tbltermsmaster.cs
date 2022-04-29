using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tbltermsmaster")]
    public partial class Tbltermsmaster
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int TermId { get; set; }
        [StringLength(40)]
        public string Term { get; set; }
        public int? TypeId { get; set; }
    }
}
