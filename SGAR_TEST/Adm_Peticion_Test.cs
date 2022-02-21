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
            int id_ambulancia = 1, tipoA = 2, capacidad = 3, disponibilidad = 1;
            string placa = "AAC123", modelo = "modeloxtest", observacion = "NN", msj = "";
            //

            msj = admA.InsertarDatosAmbulancia(id_ambulancia, placa, modelo, tipoA, capacidad, observacion, disponibilidad);


            Assert.AreEqual("La ambulancia ya está registrada", msj);
        }

        [TestMethod]
        public void InsertarDatosAmbulancia_AmbulanciaNueva()
        {
            var admA = new Adm_Ambulancia();
            int id_ambulancia = 1, tipoA = 1, capacidad = 2, disponibilidad = 1;
            string placa = "ABC234", modelo = "modeloxtest2", observacion = "NN", msj = "";

            msj = admA.InsertarDatosAmbulancia(id_ambulancia, placa, modelo, tipoA, capacidad, observacion, disponibilidad);


            Assert.AreEqual("Los datos se insertaron exitosamente", msj);
        }
    }
}
