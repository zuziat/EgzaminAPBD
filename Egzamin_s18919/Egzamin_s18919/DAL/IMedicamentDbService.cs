using Egzamin_s18919.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Egzamin_s18919.DAL
{
    public interface IMedicamentDbService
    {
        
        public List<Medicament> GetMedicaments(int IdMedicament);

    }
}
