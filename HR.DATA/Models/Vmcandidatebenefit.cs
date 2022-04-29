using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    public partial class Vmcandidatebenefit
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("benefitname")]
        [StringLength(45)]
        public string Benefitname { get; set; }
        [Column("resumeid")]
        public int? Resumeid { get; set; }
    }
}
