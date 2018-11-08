using Microsoft.AspNetCore.Mvc;
using OCTO.Admin.Controllers.Core;
using OCTO.Admin.Controllers.Interfaces;
using OCTO.BLL.Interfaces.Salutation;
using System.Threading.Tasks;

namespace OCTO.Admin.Controllers
{
    public class SalutationController : ApiControllerBase, ISalutationController
    {
        private readonly ISalutationService _salutationService;

        public SalutationController(ISalutationService salutationService)
        {
            _salutationService = salutationService;
        }

        public async Task<ActionResult> GetSalutationsAsync()
        {
            var salutationModels = await _salutationService.GetSalutationsAsync();
            return CreateResponse(salutationModels);
        }
    }
}
