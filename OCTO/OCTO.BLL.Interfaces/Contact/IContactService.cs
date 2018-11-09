using OCTO.BLL.Interfaces.Core;
using OCTO.BLL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OCTO.BLL.Interfaces.Contact
{
    public interface IContactService : IServiceBase
    {
        Task<IEnumerable<ContactModel>> GetContactsAsync();
    }
}
