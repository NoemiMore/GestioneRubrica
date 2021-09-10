using GestioneRubrica.Core.Entities;
using System;
using Xunit;

namespace GestioneRubrica.Test
{
    public class GestioneRubricaTest
    {
        [Fact]
        public void TestVisualizzaContatti()
        {
            //Arrange: predisposizione del test
            Contatto contatto1 = new Contatto();

           
            string risultato = contatto1.GetAll();

            

        }
    }
}
