using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica.Core.InterfaceRepositories
{
   public interface IRepository<T>
    {
        
        public List<T> GetAll();
        public T Add(T item);
       
        public bool Delete(T item);

    }
}
