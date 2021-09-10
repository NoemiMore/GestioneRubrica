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
    class RepositoryContattiEF : IRepositoryContatti
    {
        public Contatto Add(Contatto item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Contatti.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Contatto item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Contatti.Remove(item);
                ctx.SaveChanges();
            }
            return true;
        }

        public List<Contatto> GetAll()
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Contatti.Include(x => x.Indirizzi).ToList();
            }
        }

        public Contatto GetByIdContatti(int id)
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Contatti.Include(x => x.Indirizzi).FirstOrDefault(c => c.ContattoID == id);
            }
        }
    }
}
