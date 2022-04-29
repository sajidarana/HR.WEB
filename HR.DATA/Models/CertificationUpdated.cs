using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("certification_updated")]
    public partial class CertificationUpdated
    {
        [Key]
        [StringLength(250)]
        public string Id { get; set; }
        [Column("titleName")]
        [StringLength(250)]
        public string TitleName { get; set; }
        [Required]
        [Column(TypeName = "bit(1)")]
        public bool? IsEnabled { get; set; }
        [Column("talent_id")]
        public int TalentId { get; set; }
        [Column("institutaion")]
        [StringLength(250)]
        public string Institutaion { get; set; }
        [Column("description")]
        [StringLength(250)]
        public string Description { get; set; }
    }
}
