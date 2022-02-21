using Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace SGAR_TEST
{
    [TestClass]
    public class Adm_Ambulancia_Test
    {
        /*[TestMethod]
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
        }*/

        [TestMethod]
        public void ConsultarAmbulancia_NoExistenRegistros()
        {
            var admA = new Adm_Ambulancia();
            DataTable dt = new DataTable();
            int tipoA = 1, disponibilidad = 1, buscarOb =1, buscarOp = 2;
            string dato = "RFG", msj = "";

            dt = admA.ConsultarAmbulancias(dato, tipoA, disponibilidad, buscarOb, buscarOp);

            msj = dt.Rows.Count.ToString();

            Assert.AreEqual("0", msj);
        }

        [TestMethod]
        public void ConsultarAmbulancia_ExistenRegistros()
        {
            var admA = new Adm_Ambulancia();
            DataTable dt = new DataTable();
            int tipoA = 1, disponibilidad = 1, buscarOb = 1, buscarOp = 2;
            string dato = "ABC", msj = "";

            dt = admA.ConsultarAmbulancias(dato, tipoA, disponibilidad, buscarOb, buscarOp);
            if (dt.Rows.Count > 0)
            {
                msj = "Se encontraron los registros";
            }

            Assert.AreEqual("Se encontraron los registros", msj);
        }
    }
}
