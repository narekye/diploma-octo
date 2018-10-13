using System.ComponentModel.DataAnnotations;

namespace OCTO.DAL.Entities
{
    public class Contact : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
