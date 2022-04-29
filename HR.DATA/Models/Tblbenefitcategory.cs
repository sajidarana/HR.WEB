using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblbenefitcategory")]
    public partial class Tblbenefitcategory
    {
        public Tblbenefitcategory()
        {
            Tblbenefits = new HashSet<Tblbenefit>();
        }

        [Key]
        public int Id { get; set; }
        [Column("BCategory")]
        [StringLength(45)]
        public string Bcategory { get; set; }

        [InverseProperty(nameof(Tblbenefit.BcategoryNavigation))]
        public virtual ICollection<Tblbenefit> Tblbenefits { get; set; }
    }
}
