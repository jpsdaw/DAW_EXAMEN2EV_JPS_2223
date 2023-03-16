using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LotoClassNS;


namespace PruebaLoteria
{
    [TestClass]
    public class UnitTest1
    {
        //Quisiera haber usado excecpciones para manejar la introducción
        //de números no validos, y usando un try catch en la prueba para 
        //capturar la excepción, o usar el ExpectedException, 
        //PERO NO DIO TIEMPO

        [TestMethod]
        public void PruebaNumeroMenor()
        {
       
            int[] misNums = new int[] { 1, 2, 3, 4, 5, 0 };
            
            Loteria loteria = new Loteria(misNums);


            Assert.AreEqual(loteria.CombinacionValida, false);

        }

        [TestMethod]
        public void PruebaNumeroMayor()
        {
           
            int[] misNums = new int[] { 1, 2, 3, 4, 5, 50 };

            Loteria loteria = new Loteria(misNums);


            Assert.AreEqual(loteria.CombinacionValida, false);

        }


    }
}
