using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblrequisition")]
    [Index(nameof(RequisitionNo), Name = "RequisitionNo_UNIQUE", IsUnique = true)]
    [Index(nameof(DisciplineId), Name = "fk_discipid_4_idx")]
    [Index(nameof(OccupationId), Name = "fk_occ_4_idx")]
    [Index(nameof(SepcialityId), Name = "fk_speciality_5_idx")]
    [Index(nameof(SubSpeciality), Name = "fk_subspeiclaity_4_idx")]
    public partial class Tblrequisition
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int? DisciplineId { get; set; }
        public int? OccupationId { get; set; }
        public int? SepcialityId { get; set; }
        public int? SubSpeciality { get; set; }
        [StringLength(100)]
        public string RequisitionNo { get; set; }
        public int? TotalTeam { get; set; }
        public int? TeamCost { get; set; }
        public int? NoOfDays { get; set; }
        [StringLength(100)]
        public string UserId { get; set; }
        public int? SalaryFrom { get; set; }
        public int? SalaryTo { get; set; }
        public int? Bonus { get; set; }
        public int? ProfitSharing { get; set; }
        public int? StockOption { get; set; }
        public int? Vacations { get; set; }
        [Column("401Matching")]
        public int? _401matching { get; set; }
        public int? HealthInsurance { get; set; }
        public int? FlexHours { get; set; }
        public int? TutionReimbursement { get; set; }
        public int? RetirementPackage { get; set; }
        public int StatusId { get; set; }
    }
}
