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
       

    }
}
