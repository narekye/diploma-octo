using Microsoft.AspNetCore.Mvc;
using OCTO.Admin.Controllers.Core;
using OCTO.Admin.Controllers.Interfaces;
using OCTO.BLL.Interfaces.Country;
using System.Threading.Tasks;

namespace OCTO.Admin.Controllers
{
    public class ReferenceController : ApiControllerBase, IReferenceController
    {
        private readonly ICountryService _countryService;

        public ReferenceController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<ActionResult> GetCountriesAsync()
        {
            var countries = await _countryService.GetCountriesAsync();
            return CreateResponse(countries);
        }
    }
}
