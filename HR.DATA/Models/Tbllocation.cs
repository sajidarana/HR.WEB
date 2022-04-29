using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    [Table("tbllocation")]
    public partial class Tbllocation
    {
        [Column("postal_code")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [Column("us_county_fips_code")]
        [StringLength(255)]
        public string UsCountyFipsCode { get; set; }
        [Column("us_county_name")]
        [StringLength(255)]
        public string UsCountyName { get; set; }
        [Column("us_state")]
        [StringLength(255)]
        public string UsState { get; set; }
        [Column("us_state_postal_code")]
        [StringLength(255)]
        public string UsStatePostalCode { get; set; }
        [Column("us_csa_code")]
        public float? UsCsaCode { get; set; }
        [Column("us_cbsa_code")]
        public float? UsCbsaCode { get; set; }
        [Column("us_combined_sa_name")]
        [StringLength(255)]
        public string UsCombinedSaName { get; set; }
        [Column("us_cbsa_name")]
        [StringLength(255)]
        public string UsCbsaName { get; set; }
    }
}
