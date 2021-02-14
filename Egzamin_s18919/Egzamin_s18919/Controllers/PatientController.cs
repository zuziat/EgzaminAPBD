using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Egzamin_s18919.Controllers
{
    [Route("api/patient")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        [HttpDelete("{IdPatient}")]

        public IActionResult DeleteStudent(int IdPatient)
        {

            return Ok("");

        }

    }
}
