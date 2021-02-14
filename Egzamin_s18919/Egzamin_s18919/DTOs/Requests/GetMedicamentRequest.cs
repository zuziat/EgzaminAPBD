using Egzamin_s18919.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Egzamin_s18919.DTOs.Requests
{
    public class GetMedicamentRequest
    {
        [Required]
        public int IdMedicament { get; set; }
        public DateTime DataRealizacji { get; set; }
        public string Uwagi { get; set; }

        [Required]
        public List<Prescription> Prescriptions { get; set; }

    }
}
