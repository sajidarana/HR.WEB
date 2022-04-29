using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Table("profile_updated")]
    public partial class ProfileUpdated
    {
        [Key]
        [Column("id")]
        [StringLength(250)]
        public string Id { get; set; }
        [Column("titleName")]
        [StringLength(250)]
        public string TitleName { get; set; }
        [Column("Talent_id")]
        public int TalentId { get; set; }
        [Column("firstName")]
        [StringLength(250)]
        public string FirstName { get; set; }
        [Column("middleName")]
        [StringLength(250)]
        public string MiddleName { get; set; }
        [Column("lastName")]
        [StringLength(250)]
        public string LastName { get; set; }
        [Column("emailaddress")]
        [StringLength(250)]
        public string Emailaddress { get; set; }
        [Column("phoneNumber")]
        [StringLength(250)]
        public string PhoneNumber { get; set; }
        [Column("homeCountryPhoneNumber")]
        [StringLength(250)]
        public string HomeCountryPhoneNumber { get; set; }
        [Column("alternateNumber")]
        [StringLength(250)]
        public string AlternateNumber { get; set; }
        [Column("address1")]
        [StringLength(250)]
        public string Address1 { get; set; }
        [Column("address2")]
        [StringLength(250)]
        public string Address2 { get; set; }
        [Column("cityName")]
        [StringLength(250)]
        public string CityName { get; set; }
        [Column("stateName")]
        [StringLength(250)]
        public string StateName { get; set; }
        [Column("postalCode")]
        [StringLength(250)]
        public string PostalCode { get; set; }
        [Column("countryId")]
        public int? CountryId { get; set; }
        [Column("nationality")]
        [StringLength(30)]
        public string Nationality { get; set; }
        [Column("countryReesdinceId")]
        public int? CountryReesdinceId { get; set; }
        [Column("summary")]
        [StringLength(30)]
        public string Summary { get; set; }
    }
}
