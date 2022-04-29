using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("requisitioncompareresume")]
    public partial class Requisitioncompareresume
    {
        [Key]
        public int Id { get; set; }
        public int? ResumeId { get; set; }
        public int? RequisitionId { get; set; }
    }
}
