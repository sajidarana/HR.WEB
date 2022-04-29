using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    [Table("talent")]
    public partial class Talent
    {
        [Column("talent_id")]
        public int TalentId { get; set; }
        [Required]
        [Column("email_address")]
        [StringLength(80)]
        public string EmailAddress { get; set; }
    }
}
