using OCTO.DAL.Core;
using OCTO.DAL.Models;
using OCTO.DAL.Repositories.Interfaces;

namespace OCTO.DAL.Repositories
{
    public class ContactRepository : RepositoryBase<Contact, OctoContext>, IContactRepository
    {
        public ContactRepository(OctoContext dbContext) : base(dbContext) { }
    }
}
