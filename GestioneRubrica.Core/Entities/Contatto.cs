using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica.Core.Entities
{
   public class Contatto
    {
        public int ContattoID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        // lista indirizzi associati
        public List<Indirizzo> Indirizzi { get; set; } = new List<Indirizzo>();



        public override string ToString()
        {
            return $"{Nome}\t{Cognome}\t ha i seguenti indirizzi associati: {Indirizzi}";
        }
    }
}
