using OCTO.DAL.Core;
using OCTO.DAL.Models;
using OCTO.DAL.Repositories.Interfaces;

namespace OCTO.DAL.Repositories
{
    public class AccountRepository : RepositoryBase<Account, OctoContext>, IAccountRepository
    {
        public AccountRepository(OctoContext dbContext) : base(dbContext) { }
    }
}
