using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tbloccupation")]
    public partial class Tbloccupation
    {
        [Key]
        public int OccupationId { get; set; }
        [Column("name")]
        [StringLength(200)]
        public string Name { get; set; }
        [Column("code")]
        [StringLength(50)]
        public string Code { get; set; }
        [Column("typeId")]
        public int? TypeId { get; set; }
        [Column("isActive", TypeName = "bit(1)")]
        public bool? IsActive { get; set; }
        [Column("disciplineId", TypeName = "mediumint")]
        public int DisciplineId { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
    }
}
