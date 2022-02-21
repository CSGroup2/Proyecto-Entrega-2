using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SGAR_TEST
{
    [TestClass]
    public class Adm_Peticion_Test
    {
        [TestMethod]
        public void guardarPeticion_PeticionNueva()
        {
            var admP = new Adm_Peticion();
            string cantAmb = "2", tipo_ambulancia = "2", punto_Origen = "Clínica Kennedy", punto_Destino = "Hospital del niño", msj = "";
            //

            msj = admP.guardarPeticion(cantAmb, tipo_ambulancia, punto_Origen, punto_Destino);


            Assert.AreEqual("Su petición fue ingresada correctamente.", msj);
        }

        /*[TestMethod]
        public void guardarPeticion_ErrorConsulta()
        {
            var admA = new Adm_Ambulancia();
            int tipoA = 1, capacidad = 2;
            string placa = "ABC567", modelo = "modeloxtest2", observacion = "NN", msj = "";

            msj = admA.InsertarDatosAmbulancia(placa, modelo, tipoA, capacidad, observacion);


            Assert.AreEqual("Los datos se insertaron exitosamente", msj);
        }*/
    }
}
