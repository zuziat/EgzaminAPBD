using Egzamin_s18919.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Egzamin_s18919.DAL
{
    public class EFServerDbService : IMedicamentDbService
    {
        private CFContext _context;

        public EFServerDbService(CFContext context)
        {
            _context = context;
        }

        public List<Medicament> GetMedicaments(int IdMedicament)
        {
            
                var medicament = _context.Medicament.Where(x => x.IdMedicament == IdMedicament).Select(x => x.IdMedicament).FirstOrDefault();
                var res = _context.Medicament.Where(x => x.IdMedicament == medicament).ToList();
                return res;
            
        }
    }
}
