using Microsoft.EntityFrameworkCore;

namespace OCTO.DAL.Entities
{
    public class OCTOContext : DbContext
    {
        public DbSet<Salutation> Salutations { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salutation>().HasIndex(x => x.Name).HasName("IX_Salutation_Name").IsUnique();
        }
    }
}
