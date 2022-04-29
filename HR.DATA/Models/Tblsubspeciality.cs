using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblsubspeciality")]
    public partial class Tblsubspeciality
    {
        [Key]
        [Column("subspecialityId", TypeName = "mediumint")]
        public int SubspecialityId { get; set; }
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
        [Column("specialityId", TypeName = "mediumint")]
        public int SpecialityId { get; set; }
        [Column("description")]
        [StringLength(300)]
        public string Description { get; set; }
    }
}
