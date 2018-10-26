using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OCTO.DAL.Models
{
    [Table("Country")]
    public partial class Country
    {
        public Country()
        {
            Accounts = new HashSet<Account>();
            Contacts = new HashSet<Contact>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [InverseProperty("Country")]
        public ICollection<Account> Accounts { get; set; }
        [InverseProperty("Country")]
        public ICollection<Contact> Contacts { get; set; }
    }
}
