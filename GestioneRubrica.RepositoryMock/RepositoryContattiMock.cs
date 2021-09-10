using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneRubrica.Core.Entities;
using GestioneRubrica.Core.InterfaceRepositories;


namespace GestioneRubrica.RepositoryMock
{
    public class RepositoryContattiMock : IRepositoryContatti
    {
        public static List<Contatto> Contatti = new List<Contatto>
         {
           new Contatto {ContattoID =1, Nome="Giorgio", Cognome="Rossi"},
          new Contatto {ContattoID =1, Nome="Francesco", Cognome="Gigio"}
            };


         public Contatto Add(Contatto item)
        {
            if (Contatti.Count() == 0)
            {
                item.ContattoID = 1;
            }
            else
            {
                item.ContattoID = Contatti.Max(x => x.ContattoID) + 1;
            }
            Contatti.Add(item);
            return item;
        }

        public bool Delete(Contatto item)
        {
            Contatti.Remove(item);
            return true;
        }

        public List<Contatto> GetAll()
        {
            return Contatti.ToList();
        }

        public Contatto GetByIdContatti(int id)
        {
            return GetAll().FirstOrDefault(c => c.ContattoID == id);
        }
    }
}
