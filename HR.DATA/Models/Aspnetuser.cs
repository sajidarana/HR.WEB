using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("aspnetusers")]
    public partial class Aspnetuser
    {
        public Aspnetuser()
        {
            Aspnetuserclaims = new HashSet<Aspnetuserclaim>();
            Aspnetuserlogins = new HashSet<Aspnetuserlogin>();
            Aspnetuserroles = new HashSet<Aspnetuserrole>();
            Aspnetusertokens = new HashSet<Aspnetusertoken>();
        }

        [Key]
        [StringLength(95)]
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsBlock { get; set; }
        public bool IsExtrnalLogin { get; set; }
        [StringLength(256)]
        public string UserName { get; set; }
        [StringLength(256)]
        public string NormalizedUserName { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(256)]
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        [Column(TypeName = "longtext")]
        public string PasswordHash { get; set; }
        [Column(TypeName = "longtext")]
        public string SecurityStamp { get; set; }
        [Column(TypeName = "longtext")]
        public string ConcurrencyStamp { get; set; }
        [Column(TypeName = "longtext")]
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        [InverseProperty(nameof(Aspnetuserclaim.User))]
        public virtual ICollection<Aspnetuserclaim> Aspnetuserclaims { get; set; }
        [InverseProperty(nameof(Aspnetuserlogin.User))]
        public virtual ICollection<Aspnetuserlogin> Aspnetuserlogins { get; set; }
        [InverseProperty(nameof(Aspnetuserrole.User))]
        public virtual ICollection<Aspnetuserrole> Aspnetuserroles { get; set; }
        [InverseProperty(nameof(Aspnetusertoken.User))]
        public virtual ICollection<Aspnetusertoken> Aspnetusertokens { get; set; }
    }
}
