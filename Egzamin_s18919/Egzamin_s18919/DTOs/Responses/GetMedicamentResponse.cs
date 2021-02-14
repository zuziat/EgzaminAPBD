using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Egzamin_s18919.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Egzamin_s18919.DTOs.Responses
{
    [Route("api/medicaments")]
    [ApiController]
    public class GetMedicamentResponse : ControllerBase
    {
        
        public int IdMedicament { get; set; }
        public DateTime DataRealizacji { get; set; }
        public string Uwagi { get; set; }

        
        public List<Prescription> Prescriptions { get; set; }
    }
}
