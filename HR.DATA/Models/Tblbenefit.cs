using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblbenefits")]
    [Index(nameof(Bcategory), Name = "Fk_Bcategory_1_idx")]
    public partial class Tblbenefit
    {
        public Tblbenefit()
        {
            Tblbenefitdemands = new HashSet<Tblbenefitdemand>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(45)]
        public string BenefitName { get; set; }
        [Column("BCategory")]
        public int? Bcategory { get; set; }

        [ForeignKey(nameof(Bcategory))]
        [InverseProperty(nameof(Tblbenefitcategory.Tblbenefits))]
        public virtual Tblbenefitcategory BcategoryNavigation { get; set; }
        [InverseProperty(nameof(Tblbenefitdemand.Benefit))]
        public virtual ICollection<Tblbenefitdemand> Tblbenefitdemands { get; set; }
    }
}
