using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCTO.Admin.Controllers.Interfaces
{
    public interface IReferenceController
    {
        Task<ActionResult> GetCountriesAsync();
    }
}
