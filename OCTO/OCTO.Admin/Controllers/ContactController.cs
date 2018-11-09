using Microsoft.AspNetCore.Mvc;
using OCTO.Admin.Controllers.Core;
using OCTO.Admin.Controllers.Interfaces;
using OCTO.BLL.Interfaces.Contact;
using System.Threading.Tasks;

namespace OCTO.Admin.Controllers
{
    public class ContactController : ApiControllerBase, IContactController
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<ActionResult> GetContactsAsync()
        {
            return CreateResponse(await _contactService.GetContactsAsync());
        }
    }
}
