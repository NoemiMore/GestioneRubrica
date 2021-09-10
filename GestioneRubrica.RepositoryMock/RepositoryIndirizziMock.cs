using GestioneRubrica.Core.Entities;
using GestioneRubrica.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica.RepositoryMock
{
    public class RepositoryIndirizziMock : IRepositoryIndirizzi

    {
        public static List<Indirizzo> Indirizzi = new List<Indirizzo>();



        public Indirizzo Add(Indirizzo item)
        {
            if (Indirizzi.Count() == 0)
            {
                item.IndirizzoID = 1;
            }
            else
            {
                item.IndirizzoID = Indirizzi.Max(x => x.IndirizzoID) + 1;
            }

            var contatto = RepositoryContattiMock.Contatti.FirstOrDefault(c => c.ContattoID == item.ContattoID);
            item.Contatto = contatto;
            

            contatto.Indirizzi.Add(item);
            

            Indirizzi.Add(item);
            return item;
        }

        public bool Delete(Indirizzo item)
        {
            throw new NotImplementedException();
        }

        public List<Indirizzo> GetAll()
        {
            return Indirizzi.ToList();
        }
    }
}
