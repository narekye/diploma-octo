using AutoMapper;
using OCTO.BLL.Core;
using OCTO.BLL.Interfaces.Salutation;
using OCTO.BLL.Models;
using OCTO.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OCTO.BLL.Salutation
{
    public class SalutationService : ServiceBase, ISalutationService
    {
        private readonly ISalutationRepository _salutationRepository;
        private readonly IMapper _mapper;

        public SalutationService(ISalutationRepository salutationRepository, IMapper mapper) : base(salutationRepository)
        {
            _salutationRepository = salutationRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SalutationModel>> GetSalutationsAsync()
        {
            var salutations = await _salutationRepository.GetAllAsync();
            var models = _mapper.Map<IEnumerable<SalutationModel>>(salutations);
            return models;
        }
    }
}
