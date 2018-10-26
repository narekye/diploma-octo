using OCTO.DAL.Core;
using OCTO.DAL.Models;
using OCTO.DAL.Repositories.Interfaces;

namespace OCTO.DAL.Repositories
{
    public class CountryRepository : RepositoryBase<Country, OctoContext>, ICountryRepository
    {
        public CountryRepository(OctoContext dbContext) : base(dbContext) { }
    }
}
