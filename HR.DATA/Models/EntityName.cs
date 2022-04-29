using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    [Table("entity_name")]
    public partial class EntityName
    {
        [Column("entity_id")]
        public int EntityId { get; set; }
        [Column("resume_id")]
        public int? ResumeId { get; set; }
        [Column("entity_name")]
        [StringLength(1000)]
        public string EntityName1 { get; set; }
        [Column("entity_type")]
        [StringLength(100)]
        public string EntityType { get; set; }
    }
}
