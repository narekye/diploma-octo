using OCTO.BLL.Core;
using OCTO.BLL.Interfaces.Salutation;
using OCTO.DAL.Repositories.Interfaces;

namespace OCTO.BLL.Salutation
{
    public class SalutationService : ServiceBase, ISalutationService
    {
        private readonly ISalutationRepository _salutationRepository;

        public SalutationService(ISalutationRepository salutationRepository) : base(salutationRepository)
        {
            _salutationRepository = salutationRepository;
        }
    }
}
