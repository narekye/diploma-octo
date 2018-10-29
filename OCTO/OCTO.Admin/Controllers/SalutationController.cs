using OCTO.Admin.Controllers.Core;
using OCTO.Admin.Controllers.Interfaces;
using OCTO.BLL.Interfaces.Salutation;

namespace OCTO.Admin.Controllers
{
    public class SalutationController : ApiControllerBase, ISalutationController
    {
        private readonly ISalutationService _salutationService;

        public SalutationController(ISalutationService salutationService)
        {
            _salutationService = salutationService;
        }
    }
}
