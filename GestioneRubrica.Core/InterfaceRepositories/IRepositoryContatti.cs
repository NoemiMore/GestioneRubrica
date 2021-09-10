using GestioneRubrica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica.Core.InterfaceRepositories
{
   public interface IRepositoryContatti: IRepository<Contatto>
    {
         public Contatto GetByIdContatti(int id);
    }
}
