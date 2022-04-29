using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("tblquestionsforcandidates")]
    [Index(nameof(No), Name = "No_UNIQUE", IsUnique = true)]
    public partial class Tblquestionsforcandidate
    {
        public Tblquestionsforcandidate()
        {
            Tblcandidatereplies = new HashSet<Tblcandidatereply>();
        }

        [Key]
        public int No { get; set; }
        public string Question { get; set; }
        [StringLength(45)]
        public string Type { get; set; }

        [InverseProperty(nameof(Tblcandidatereply.Question))]
        public virtual ICollection<Tblcandidatereply> Tblcandidatereplies { get; set; }
    }
}
