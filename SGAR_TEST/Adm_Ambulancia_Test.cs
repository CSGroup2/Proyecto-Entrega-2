using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SGAR_TEST
{
    [TestClass]
    public class Adm_Ambulancia_Test
    {
        [TestMethod]
        public void InsertarDatosAmbulancia_AmbulanciaExistente()
        {
            var admA = new Adm_Ambulancia();
            int tipoA = 2, capacidad = 3;
            string placa = "ABC123", modelo = "modeloxtest", observacion = "NN", msj = "";
            //

            msj = admA.InsertarDatosAmbulancia(placa, modelo, tipoA, capacidad, observacion);


            Assert.AreEqual("La ambulancia ya está registrada", msj);
        }

        [TestMethod]
        public void InsertarDatosAmbulancia_AmbulanciaNueva()
        {
            var admA = new Adm_Ambulancia();
            int tipoA = 1, capacidad = 2;
            string placa = "ACD234", modelo = "modeloxtest2", observacion = "No tiene material de asistencia", msj = "";

            msj = admA.InsertarDatosAmbulancia(placa, modelo, tipoA, capacidad, observacion);


            Assert.AreEqual("Los datos se insertaron exitosamente", msj);
        }
    }
}
