using GestioneRubrica.Core.Entities;
using GestioneRubrica.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica.Core.BusinessLayer
{
   public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryContatti contattiRepo;
        private readonly IRepositoryIndirizzi indirizziRepo;

        public MainBusinessLayer(IRepositoryContatti contatti, IRepositoryIndirizzi indirizzi)
        {
            contattiRepo = contatti;
            indirizziRepo = indirizzi;
            
        }

        // metodi

        public string EliminaContatto(int IdContattoDaEliminare)
        {
            var contattoEsistente = contattiRepo.GetByIdContatti(IdContattoDaEliminare);
            if (contattoEsistente == null)
            {
                return "Id non valido.Impossibile eliminare.";
            }
            var contattoAssociatoIndirizzo = GetAllIndirizziContatto().FirstOrDefault(i => i.ContattoID == IdContattoDaEliminare);
            if (contattoAssociatoIndirizzo != null)
            {
                return "Impossibile cancellare il contatto perchè contiene almeno un indirizzo";
            }
            contattiRepo.Delete(contattoEsistente);
            return "Contatto eliminato con successo";
        }

        public List<Contatto> GetAllContatti()
        {
            return contattiRepo.GetAll().ToList();
        }

        public List<Indirizzo> GetAllIndirizziContatto()
        {
            throw new NotImplementedException();
        }

        public string InserisciNuovoContatto(Contatto newContatto)
        {
            var ContattoEsistente = GetAllContatti().FirstOrDefault(c => c.Nome == newContatto.Nome && c.Cognome == newContatto.Cognome);

            if (ContattoEsistente != null)
            {
                return "Contatto già esistente";
            }
            contattiRepo.Add(newContatto);
            return "Contatto aggiunto con successo";
        }

        public string InserisciNuovoIndirizzoContatto(Indirizzo newIndirizzo)
        {
            var contatto = contattiRepo.GetByIdContatti(newIndirizzo.ContattoID);
            if (contatto == null)
            {
                return "Codice Contatto errato o inesistente";
            }

            indirizziRepo.Add(newIndirizzo);
            return "Aggiunto indirizzo correttamente";

        }
    }
}
