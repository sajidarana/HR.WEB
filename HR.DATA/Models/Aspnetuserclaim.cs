using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("aspnetuserclaims")]
    [Index(nameof(UserId), Name = "FK_AspNetUserClaims_AspNetUsers_UserId")]
    public partial class Aspnetuserclaim
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(95)]
        public string UserId { get; set; }
        [Column(TypeName = "longtext")]
        public string ClaimType { get; set; }
        [Column(TypeName = "longtext")]
        public string ClaimValue { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Aspnetuser.Aspnetuserclaims))]
        public virtual Aspnetuser User { get; set; }
    }
}
