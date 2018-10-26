using Microsoft.EntityFrameworkCore;
using OCTO.DAL.Core;
using OCTO.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCTO.DAL.Filters
{
    public class AccountFilter : IFilter<Account>
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public int? CountryId { get; set; }

        public async Task<IEnumerable<Account>> Apply(IQueryable<Account> query)
        {
            if (Id.HasValue)
                query = query.Where(x => x.Id == Id);
            if (!string.IsNullOrWhiteSpace(Name))
                query = query.Where(x => x.Name == Name);
            if (CountryId.HasValue)
                query = query.Where(x => x.CountryId == CountryId);

            return await query.ToListAsync();
        }
    }
}
