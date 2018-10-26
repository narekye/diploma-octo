using Microsoft.AspNetCore.Mvc;
using OCTO.Admin.Controllers.Core;
using OCTO.BLL.Interfaces.Salutation;
using System.Threading.Tasks;

namespace OCTO.Admin.Controllers
{
    public class SalutationController : ApiControllerBase
    {
        private readonly ISalutationService _salutationService;

        public SalutationController(ISalutationService salutationService)
        {
            _salutationService = salutationService;
        }

        [HttpGet]
        public async Task<ActionResult> GetSalutations()
        {
            return CreateResponse<object>(null);
        }
    }
}
