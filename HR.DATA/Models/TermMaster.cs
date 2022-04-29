using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    [Table("term_master")]
    public partial class TermMaster
    {
        [Column("term_id")]
        public int TermId { get; set; }
        [Column("term")]
        [StringLength(1000)]
        public string Term { get; set; }
        public int? TypeId { get; set; }
    }
}
