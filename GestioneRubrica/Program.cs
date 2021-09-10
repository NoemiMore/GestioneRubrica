using GestioneRubrica.Core.BusinessLayer;
using GestioneRubrica.Core.Entities;
using GestioneRubrica.RepositoryMock;
using System;

namespace GestioneRubrica
{
    class Program
    { //repoMock
       private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryContattiMock(), new RepositoryIndirizziMock());
      // private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryContattiMock(), new RepositoryIndirizziMock());
       
        
        
        static void Main(string[] args)
        {
            bool continuare = true;
            int scelta;

            while (continuare)
            {
                Console.WriteLine("Premi 1 per  Visualizzare tutti i Contatti.");
                Console.WriteLine("Premi 2 per Aggiungere un nuovo Contatto");
                Console.WriteLine("Premi 3 per Aggiungere un Indirizzo ad un contatto.");
                Console.WriteLine("Premi 4 per Eliminare un Contatto");
                Console.WriteLine("Premi 0 per uscire");

                do
                {
                    Console.WriteLine("Fai la tua scelta");
                } while (!int.TryParse(Console.ReadLine(), out scelta));

                switch (scelta)
                {
                    case 1:
                        {
                            VisualizzaContatti();
                            break;
                        }
                    case 2:
                        {
                            InserisciNuovoContatto(); ;
                            break;
                        }
                    case 3:
                        {
                            InserisciNuovoIndirizzoContatto();
                            break;
                        }
                    case 4:
                        {
                            EliminaContatto();
                            break;
                        }
                   
                    case 0:
                        {
                            continuare = false;
                            break;
                        }
                }
            }
        }

        private static void VisualizzaContatti()
        {
            var contatti = bl.GetAllContatti();
            Console.WriteLine("I docenti disponibili sono:");
            if (contatti.Count == 0)
            {
                Console.WriteLine("Lista vuota");
            }
            else
            {
                foreach (var item in contatti)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void EliminaContatto()
        {
            Console.WriteLine("Ecco l'elenco dei contatti :");
            VisualizzaContatti();
            Console.WriteLine("Quale contatto vuoi eliminare? Inserisci l'id");
            int IdContattoDaEliminare = int.Parse(Console.ReadLine());
            string esito = bl.EliminaContatto(IdContattoDaEliminare);
            Console.WriteLine(esito);
        }

        private static void InserisciNuovoIndirizzoContatto()
        {
            Console.WriteLine("Inserisci nuovo indirizzo del contatto :");
            Console.Write("Scrivi la Residenza:  ");
            string residenza = Console.ReadLine();
            Console.Write("Scrivi il domicilio: ");
            string domicilio = Console.ReadLine();
            Console.Write("Scrivi la Via:  ");
            string via = Console.ReadLine();
            Console.Write("Scrivi la città: ");
            string città = Console.ReadLine();
            Console.Write("Scrivi il cap: ");
            int cap = int.Parse(Console.ReadLine());
            Console.Write("Scrivi la provincia: ");
            string provincia = Console.ReadLine();
            Console.Write("Scrivi la nazione: ");
            string nazione = Console.ReadLine();
            
          
            Console.WriteLine("Elenco contatti disponibili:");
            VisualizzaContatti();
            Console.Write("\nId Contatto a cui vuoi associare l'indirizzo: ");
            int contattoId = int.Parse(Console.ReadLine());



            Indirizzo nuovoIndirizzo = new Indirizzo();
            nuovoIndirizzo.Residenza = residenza;
            nuovoIndirizzo.Domicilio = domicilio;
            nuovoIndirizzo.Via = via;
            nuovoIndirizzo.Città = città;
            nuovoIndirizzo.Cap = cap;
            nuovoIndirizzo.Provincia = provincia;
            nuovoIndirizzo.Nazione = nazione;
            nuovoIndirizzo.ContattoID = contattoId;

            
            string esito = bl.InserisciNuovoIndirizzoContatto(nuovoIndirizzo);
           
            Console.WriteLine(esito);



        }

        private static void InserisciNuovoContatto()
        {
                   
            Console.WriteLine("Inserisci il nome del nuovo Contatto");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome del nuovo Contatto");
            string cognome = Console.ReadLine();
           

            
            Contatto nuovoContatto = new Contatto();
            nuovoContatto.Nome = nome;
            nuovoContatto.Cognome = cognome;
            

            //lo passo al business layer per controllare i dati ed aggiungerlo poi nel "DB".
            string esito = bl.InserisciNuovoContatto(nuovoContatto);
            
            Console.WriteLine(esito);
        }
    }

        
    
}
