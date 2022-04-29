using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblcampaign")]
    public partial class Tblcampaign
    {
        [Key]
        public int Id { get; set; }
        [StringLength(45)]
        public string CampaignNo { get; set; }
        public int? TotalTeam { get; set; }
        [StringLength(100)]
        public string TimeToFill { get; set; }
        public int? NoOfPosition { get; set; }
        [StringLength(128)]
        public string CreatedBy { get; set; }
        [StringLength(128)]
        public string UpdatedBy { get; set; }
        public int? ActionTypeId { get; set; }
    }
}
