using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Egzamin_s18919.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Egzamin_s18919.Controllers
{
    [Route("[api/medicaments]")]
    [ApiController]
    public class MedicamentsController : ControllerBase
    {
        private IMedicamentDbService _service;

        public MedicamentsController(IMedicamentDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetMedicament(int MedicamentId)
        {
            var res = _service.GetMedicaments(MedicamentId);

            if (res!=null)
            {
                return Ok(res);
            }
            else
            {
                return NotFound("Nie ma takiego leku");
            }

        }
    }
}
