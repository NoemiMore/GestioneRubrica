using GestioneRubrica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica.Core.BusinessLayer
{
   public interface IBusinessLayer
    {
        public List<Indirizzo> GetAllIndirizziContatto();

        public string InserisciNuovoContatto(Contatto newContatto);

        public string EliminaContatto(int IdContattoDaEliminare);

        public string InserisciNuovoIndirizzoContatto(Indirizzo newIndirizzo);

        public List<Contatto> GetAllContatti();
    }
}
