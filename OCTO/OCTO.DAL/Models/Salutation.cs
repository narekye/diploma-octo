using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OCTO.DAL.Models
{
    [Table("Salutation")]
    public partial class Salutation
    {
        public Salutation()
        {
            Contacts = new HashSet<Contact>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        [InverseProperty("Salutation")]
        public ICollection<Contact> Contacts { get; set; }
    }
}
