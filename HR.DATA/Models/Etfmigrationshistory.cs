﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("__etfmigrationshistory")]
    public partial class Etfmigrationshistory
    {
        [Key]
        [StringLength(150)]
        public string MigrationId { get; set; }
        [Required]
        [StringLength(32)]
        public string ProductVersion { get; set; }
    }
}
