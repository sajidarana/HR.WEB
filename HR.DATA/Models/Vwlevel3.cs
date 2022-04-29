using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    public partial class Vwlevel3
    {
        [StringLength(45)]
        public string Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
    }
}
