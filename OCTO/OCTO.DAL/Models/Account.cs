using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OCTO.DAL.Models
{
    [Table("Account")]
    public partial class Account
    {
        public Account()
        {
            Contacts = new HashSet<Contact>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(64)]
        public string Name { get; set; }
        [StringLength(64)]
        public string AddressLine { get; set; }
        public int CountryId { get; set; }
        [StringLength(16)]
        public string Zip { get; set; }
        [StringLength(64)]
        public string Phone { get; set; }
        [StringLength(128)]
        public string Site { get; set; }
        public int? CampaignId { get; set; }
        [StringLength(255)]
        public string Notes { get; set; }

        [ForeignKey("CampaignId")]
        [InverseProperty("Accounts")]
        public Campaign Campaign { get; set; }
        [ForeignKey("CountryId")]
        [InverseProperty("Accounts")]
        public Country Country { get; set; }
        [InverseProperty("Account")]
        public ICollection<Contact> Contacts { get; set; }
    }
}
