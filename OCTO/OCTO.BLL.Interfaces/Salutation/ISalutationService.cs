using OCTO.BLL.Interfaces.Core;
using OCTO.BLL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OCTO.BLL.Interfaces.Salutation
{
    public interface ISalutationService : IServiceBase
    {
        Task<IEnumerable<SalutationModel>> GetSalutationsAsync();
    }
}
