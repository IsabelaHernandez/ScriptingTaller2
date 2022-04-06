using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Pruebas_Cartas
{
    [TestClass] 
    public class UnitTest1
    {
        //Valores de prueba:


        //Pruebas unitarias para cada "combo" de valores
        [TestMethod]
        public void TestDeckLimit()
        {
            Deck deckTest01 = new Deck();
            deckTest01.LlenarDeck();

            Console.WriteLine(deckTest01.chInsedeDeck);
            Console.WriteLine(deckTest01.eqInsedeDeck);
            Console.WriteLine(deckTest01.spInsedeDeck);
            //El Deck cumple con los límites de cartas 
            Assert.AreEqual(0, deckTest01.CPbaraja);
            Assert.AreNotEqual(0, deckTest01.chInsedeDeck);
            Assert.AreNotEqual(6, deckTest01.chInsedeDeck);
            Assert.AreNotEqual(1, deckTest01.eqInsedeDeck);
            Assert.AreNotEqual(6, deckTest01.spInsedeDeck);

        }
        [TestMethod]
        public void TestChAttributes()
        {
            
            //El Character posee todos los atributos
            int AP = 0;
            int RP = 0;
            int CP = 0;

            Character actualChar = new Character(AP, RP, CP);

            Deck deckTest03 = new Deck();
            deckTest03.CreateCharacter();
            //Equip Character
            for (int i = 0; i < deckTest03.cartas.Count; i++)
            {

                if (deckTest03.cartas[i] is Character)
                {
                    actualChar = (deckTest03.cartas[i] as Character);
                }
            }
            actualChar = (Character)deckTest03.cartas[0];

            Assert.IsNotNull(actualChar);
            Assert.AreNotEqual(0, actualChar.AP);
            Assert.AreNotEqual(0, actualChar.RP);
            Assert.AreNotEqual(0, actualChar.CP); 
        }
        [TestMethod]
        public void TestEqAttributes()
        {
            //Equip posee todos los atributos
            int EP = 0;
            int CP = 0;

            Equip actualEq = new Equip(EP, CP);

            Deck deckTest05 = new Deck();
            deckTest05.CreateEquip();

            //Equip Character
            for (int i = 0; i < deckTest05.cartas.Count; i++)
            {

                if (deckTest05.cartas[i] is Equip)
                {
                    actualEq = (deckTest05.cartas[i] as Equip);
                }
            }
            actualEq = (Equip)deckTest05.cartas[0];

            Assert.IsNotNull(actualEq);
            Assert.AreNotEqual(0, actualEq.EP);
            Assert.AreNotEqual(0, actualEq.CP);
        }
        [TestMethod]
        public void TestSupportAttributes()
        {
            //Conntiene todos los atributos
            int EPs = 0;
            int CPs = 0;

            Support actualSp = new Support(EPs, CPs);

            Deck deckTest10 = new Deck();
            deckTest10.CreateSupport();

            //Equip Character
            for (int i = 0; i < deckTest10.cartas.Count; i++)
            {

                if (deckTest10.cartas[i] is Support)
                {
                    actualSp = (deckTest10.cartas[i] as Support);
                }
            }
            actualSp = (Support)deckTest10.cartas[0];

            Assert.IsNotNull(actualSp);
            Assert.AreNotEqual(0, actualSp.EP);
            Assert.AreNotEqual(0, actualSp.CP);
        }
        [TestMethod]
        public void TestChAttack()
        {
            //El Character ataca a un Ch enemigo según sus atributos
            //Enfrentamiento Batalla01 = new Enfrentamiento();
            //Batalla01.BatallaAMuerte();


        }
        [TestMethod]
        public void TestChIsDestroy()
        {
            //Cuanndo su RP llega a cero el Character es destruido
            //Revisión muertos


        }
        [TestMethod]
        public void TestEquipTA()
        {
            //Solo afecta al atributo indicado en TA
        }
        [TestMethod]
        public void TestEquipEP()
        {
            //Solo Modifica la cantidad indicada en EP
        }
        [TestMethod]
        public void TestEquipAffinity()
        {
            //Se equipa solo cuando posee la misma afinidad que el Character
        }
        
        [TestMethod]
        public void TestSupportET()
        {
            //Hace solo el efecto indicado en ET
        }
        [TestMethod]
        public void TestSupportEP()
        {
            //Modifica la cantidad indicada en Ep
        }
        [TestMethod]
        public void TestETDestroyOlny1Card()
        {
            //DestroyEquip solo puede destruir una carta a la vez
        }
        [TestMethod]
        public void TestCardPermaDeath()
        {
            //Nada de resurección, la destrucción de una carta es permamente  
        }
    }
}
