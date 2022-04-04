using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas_Cartas
{
    [TestClass] 
    public class UnitTest1
    {
        //Valores de prueba:

        //Pruebas unitarias para cada "combo" de valores
        [TestMethod]
        public void TestDeck()
        {
            //El Deck cumple con los límites de cartas 
        }
        [TestMethod]
        public void TestDeckCP()
        {
            //El Deck no sobre pasa su CP al ser llenado
        }
        [TestMethod]
        public void TestCardAttributes() 
        { 
            //Todas las cartas poeseen los atributos base
        }
        [TestMethod]
        public void TestChAttributes()
        {
            //El Character posee todos los atributos
        }
        [TestMethod]
        public void TestChAttack()
        {
            //El Character ataca a un Ch enemigo según sus atributos
        }
        [TestMethod]
        public void TestChIsDestroy()
        {
            //Cuanndo su RP llega a cero el Character es destruido
        }
        [TestMethod]
        public void TestEqAttributes()
        {
            //Equip posee todos los atributos
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
        public void TestSupportAttributes()
        {
            //Conntiene todos los atributos
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
        [TestMethod]
        public void TestGameOver()
        {
            //Condición: que se quede sin personajes
        }
    }
}
