using GestioneRubrica.Core.Entities;
using GestioneRubrica.Core.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica.RepositoryEF.RepositoryEF
{
    class RepositoryIndirizziEF : IRepositoryIndirizzi
    {
        public Indirizzo Add(Indirizzo item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Indirizzi.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Indirizzo item)
        {
            throw new NotImplementedException();
        }

        public List<Indirizzo> GetAll()
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Indirizzi.Include(x => x.Contatto).ToList();
            }
        }
    }
}
