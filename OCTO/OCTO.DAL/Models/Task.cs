using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OCTO.DAL.Models
{
    [Table("Task")]
    public partial class Task
    {
        public int Id { get; set; }
        public bool? AllDay { get; set; }
        public int PriorityId { get; set; }
        public int TypeId { get; set; }
        [StringLength(256)]
        public string Description { get; set; }
    }
}
