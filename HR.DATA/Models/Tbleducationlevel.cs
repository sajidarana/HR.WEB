using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tbleducationlevel")]
    public partial class Tbleducationlevel
    {
        [Key]
        [Column(TypeName = "mediumint")]
        public int EducationLevelId { get; set; }
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
        [StringLength(300)]
        public string Description { get; set; }
    }
}
