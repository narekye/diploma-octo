using AutoMapper;
using OCTO.BLL.Core;
using OCTO.BLL.Interfaces.Contact;
using OCTO.DAL.Repositories.Interfaces;

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
    }
}
