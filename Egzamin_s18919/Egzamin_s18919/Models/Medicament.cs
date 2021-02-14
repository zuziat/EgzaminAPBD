using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Egzamin_s18919.Models
{
    public class Medicament
    {
        public Medicament()
        {
            Prescriptions = new HashSet<Prescription>();
        }

        public int IdMedicament { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Prescription_Medicament> Prescription_Medicament { get; set; }
    }
}
