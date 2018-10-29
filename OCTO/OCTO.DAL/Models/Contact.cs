using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OCTO.DAL.Models
{
    [Table("Contact")]
    public partial class Contact
    {
        public int Id { get; set; }
        public int SalutationId { get; set; }
        public int AccountId { get; set; }
        [Required]
        [StringLength(64)]
        public string FirstName { get; set; }
        [StringLength(64)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(64)]
        public string LastName { get; set; }
        [StringLength(64)]
        public string JobTitle { get; set; }
        [StringLength(64)]
        public string Department { get; set; }
        [StringLength(64)]
        public string Manager { get; set; }
        [StringLength(64)]
        public string Assistant { get; set; }
        [StringLength(64)]
        public string Phone { get; set; }
        [StringLength(64)]
        public string HomePhone { get; set; }
        [StringLength(64)]
        public string MobilePhone { get; set; }
        [StringLength(64)]
        public string Email { get; set; }
        [StringLength(64)]
        public string Notes { get; set; }
        public bool DecisionMaker { get; set; }
        public bool Hold { get; set; }
        public int CountryId { get; set; }
        [Required]
        [StringLength(64)]
        public string City { get; set; }

        [ForeignKey("AccountId")]
        [InverseProperty("Contacts")]
        public Account Account { get; set; }
        [ForeignKey("CountryId")]
        [InverseProperty("Contacts")]
        public Country Country { get; set; }
        [ForeignKey("SalutationId")]
        [InverseProperty("Contacts")]
        public Salutation Salutation { get; set; }
    }
}
