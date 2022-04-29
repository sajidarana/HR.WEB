using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("aspnetuserlogins")]
    [Index(nameof(UserId), Name = "FK_AspNetUserLogins_AspNetUsers_UserId")]
    public partial class Aspnetuserlogin
    {
        [Key]
        [StringLength(95)]
        public string LoginProvider { get; set; }
        [Key]
        [StringLength(95)]
        public string ProviderKey { get; set; }
        [Column(TypeName = "longtext")]
        public string ProviderDisplayName { get; set; }
        [Required]
        [StringLength(95)]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Aspnetuser.Aspnetuserlogins))]
        public virtual Aspnetuser User { get; set; }
    }
}
