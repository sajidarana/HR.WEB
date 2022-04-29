using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("users")]
    [Index(nameof(Email), Name = "users_email_unique", IsUnique = true)]
    public partial class User
    {
        [Key]
        [Column("id", TypeName = "bigint unsigned")]
        public long Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(191)]
        public string Name { get; set; }
        [Required]
        [Column("email")]
        [StringLength(191)]
        public string Email { get; set; }
        [Required]
        [Column("password")]
        [StringLength(191)]
        public string Password { get; set; }
        [Column("remember_token")]
        [StringLength(100)]
        public string RememberToken { get; set; }
    }
}
