using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_InstanciarClaseCentralita_UnObjetoCentralita()
        {
            CentralitaII centralita = new CentralitaII();
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void centralitaExcepcion_LanzarExcepcionCuandoHayDosLocalesIgual_UnaExcepcion()
        {
            //Arrange
            CentralitaII centralita = new CentralitaII();
            Local l1 = new Local("Bernal", "Rosario", 5, 5);
            Local l3 = new Local("Bernal", "Rosario", 3, 2);
            // Act
            centralita += l1;
            centralita += l3;
 
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void centralitaExcepcion_LanzarExcepcionCuandoHayDosProvincialesIgual_UnaExcepcion()
        {
            //Arrange
            CentralitaII centralita = new CentralitaII();
            Provincial l4 = new Provincial("Boedo", Franja.Franja_1, 10, "Caseros");
            Provincial l5 = new Provincial("Boedo", Franja.Franja_1, 10, "Caseros");
            // Act
            centralita += l4;
            centralita += l5;

        }
        [TestMethod]
        public void centralitaExcepcion_ObejtosConValoresIgualesPeroConInstanciaPropia_DevuelveTodoBienMientrasSeanDiferentes()
        {
            CentralitaII centralita = new CentralitaII();
            Local l1 = new Local("Bernal", "Rosario", 5, 5);
            Local l2 = new Local("Bernal", "Rosario", 3, 2);
            Provincial l4 = new Provincial("Bernal", Franja.Franja_1, 10, "Rosario");
            Provincial l5 = new Provincial("Bernal", Franja.Franja_1, 10, "Rosario");

            Assert.AreEqual(l1, l2);
            Assert.AreEqual(l4, l5);
            Assert.AreNotSame(l1, l2);
            Assert.AreNotSame(l4, l5);
        }
    }
}
