using OCTO.DAL.Core;
using OCTO.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCTO.DAL.Filters
{
    public class ContactFilter : IFilter<Contact>
    {
        public Task<IEnumerable<Contact>> Apply(IQueryable<Contact> query)
        {
            throw new NotImplementedException();
        }
    }
}
