using AutoMapper;
using OCTO.BLL.Core;
using OCTO.BLL.Interfaces.Country;
using OCTO.BLL.Models;
using OCTO.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OCTO.BLL.Country
{
    public class CountryService : ServiceBase, ICountryService
    {
        private ICountryRepository _countryRepository;
        private IMapper _mapper;

        public CountryService(ICountryRepository databaseTransaction, IMapper mapper) : base(databaseTransaction)
        {
            _countryRepository = databaseTransaction;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CountryModel>> GetCountriesAsync()
        {
            var countries = await _countryRepository.GetAllAsync();
            var models = _mapper.Map<IEnumerable<CountryModel>>(countries);
            return models;
        }
    }
}
