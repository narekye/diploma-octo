using System.ComponentModel.DataAnnotations;

namespace OCTO.DAL.Entities
{
    public class Salutation : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
