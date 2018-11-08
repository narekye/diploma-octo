using OCTO.Admin.Controllers.Core;
using OCTO.Admin.Controllers.Interfaces;
using OCTO.BLL.Interfaces.Contact;

namespace OCTO.Admin.Controllers
{
    public class ContactController : ApiControllerBase, IContactController
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
    }
}
