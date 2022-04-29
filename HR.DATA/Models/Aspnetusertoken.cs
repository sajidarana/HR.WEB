using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("aspnetusertokens")]
    public partial class Aspnetusertoken
    {
        [Key]
        [StringLength(95)]
        public string UserId { get; set; }
        [Key]
        [StringLength(95)]
        public string LoginProvider { get; set; }
        [Key]
        [StringLength(95)]
        public string Name { get; set; }
        [Column(TypeName = "longtext")]
        public string Value { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Aspnetuser.Aspnetusertokens))]
        public virtual Aspnetuser User { get; set; }
    }
}
