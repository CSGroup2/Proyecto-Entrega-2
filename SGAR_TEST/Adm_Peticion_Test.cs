using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SGAR_TEST
{
    [TestClass]
    public class Adm_Peticion_Test
    {
        [TestMethod]
        public void dfdfsd()
        {
            var admA = new Adm_Ambulancia();
            int tipoA = 2, capacidad = 3;
            string placa = "AAC123", modelo = "modeloxtest", observacion = "NN", msj = "";
            //

            msj = admA.InsertarDatosAmbulancia(placa, modelo, tipoA, capacidad, observacion);


            Assert.AreEqual("La ambulancia ya está registrada", msj);
        }

        [TestMethod]
        public void InsertarDatosAmbulancia_AmbulanciaNueva()
        {
            var admA = new Adm_Ambulancia();
            int tipoA = 1, capacidad = 2;
            string placa = "ABC567", modelo = "modeloxtest2", observacion = "NN", msj = "";

            msj = admA.InsertarDatosAmbulancia(placa, modelo, tipoA, capacidad, observacion);


            Assert.AreEqual("Los datos se insertaron exitosamente", msj);
        }
    }
}
