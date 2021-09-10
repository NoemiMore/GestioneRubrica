using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica.Core.Entities
{
   public  class Indirizzo
    {
        public int IndirizzoID { get; set; }
        //  public TipoEnum Tipologia { get; set; }
        public string Residenza { get; set; }
        public string Domicilio { get; set; }
      
        public string Via { get; set; }
        public string Città { get; set; }
        public int Cap { get; set; }
        
        public string Provincia { get; set; }
        public string Nazione { get; set; }


        //FK 
        public int ContattoID { get; set; }
        public Contatto Contatto { get; set; }

        public override string ToString()
        {
            return $"Indirizzo: {IndirizzoID}\tResidenza :{Residenza}\t Domicilio: {Domicilio}\tVia: {Via}\tCittà: {Città}\n Cap: {Cap}\n Provincia: {Provincia}\n  Nazione: {Nazione}\n Contatto: {Contatto.ToString()}";
        }

    }

   /* public enum TipoEnum
    {
        Residenza = 1,
       Domicilio = 2,
        
    }*/



}
