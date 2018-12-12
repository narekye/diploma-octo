using OCTO.BLL.Interfaces.Core;
using OCTO.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OCTO.BLL.Interfaces.Country
{
    public interface ICountryService : IServiceBase
    {
        Task<IEnumerable<CountryModel>> GetCountriesAsync();
    }
}
