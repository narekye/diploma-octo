using Microsoft.AspNetCore.Mvc;
using OCTO.Admin.Models;

namespace OCTO.Admin.Controllers.Core
{
    [ApiController, Produces("application/json"), Route("api/[controller]/[action]")]
    public class ApiControllerBase : ControllerBase
    {
        [NonAction]
        protected ActionResult CreateResponse<T>(T result)
        {
            return Ok(new ResponseWrapper<T>
            {
                Data = result,
                HasError = false,
                State = "Success"
            });
        }
    }
}
