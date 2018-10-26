using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OCTO.DAL.Models
{
    [Table("Campaign")]
    public partial class Campaign
    {
        public Campaign()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        public bool Active { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? BudgetedCost { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? ActualCost { get; set; }
        public int TypeId { get; set; }
        public int StatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndDate { get; set; }
        [Required]
        [StringLength(255)]
        public string Notes { get; set; }

        [InverseProperty("Campaign")]
        public ICollection<Account> Accounts { get; set; }
    }
}
