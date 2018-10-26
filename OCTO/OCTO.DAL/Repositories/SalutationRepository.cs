using OCTO.DAL.Core;
using OCTO.DAL.Models;
using OCTO.DAL.Repositories.Interfaces;

namespace OCTO.DAL.Repositories
{
    public class SalutationRepository : RepositoryBase<Salutation, OctoContext>, ISalutationRepository
    {
        public SalutationRepository(OctoContext dbContext) : base(dbContext) { }
    }
}
