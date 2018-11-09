using AutoMapper;
using OCTO.BLL.Core;
using OCTO.BLL.Interfaces.Contact;
using OCTO.BLL.Models;
using OCTO.BLL.Models.Filters;
using OCTO.DAL.Filters;
using OCTO.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OCTO.BLL.Contact
{
    public class ContactService : ServiceBase, IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;

        public ContactService(IContactRepository contactRepository, IMapper mapper) : base(contactRepository)
        {
            _contactRepository = contactRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ContactModel>> GetContactsAsync()
        {
            var filter = _mapper.Map<ContactFilter>(new ContactFilterModel()); // remove

            var contacts = await _contactRepository.GetByFilterAsync(filter, x => x.Account, x => x.Salutation);

            return _mapper.Map<IEnumerable<ContactModel>>(contacts);
        }
    }
}
