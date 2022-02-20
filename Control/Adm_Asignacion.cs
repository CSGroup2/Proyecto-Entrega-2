using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control {
    public class Adm_Asignacion {

        /*
            Aplicar el patron de diseño Singleton:
            1. Crear 1 atributo estático y privado de la misma clase.
            2. Cambiar el constructor de public a private.
            3.1. Crear un getter del atributo estático del tipo de la clase.
            3.2.Verificar si atributo es null, si es así, crearlo.
        */

        private static Adm_Asignacion adm = null;   // 1.

        Validacion v = null;
        Peticion p = null;
        Cliente cl = null;
        Conductor co = null;
        Ambulancia a = null;

        List<Asignacion_Cabecera> listaC = null;
        List<Asignacion_Detalle> listaD = null;

        Adm_Login admL = Adm_Login.GetAdm();
        Adm_Peticion admP = Adm_Peticion.GetAdm();
        Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();
        Adm_Conductor admC = Adm_Conductor.GetAdm();

        public List<Asignacion_Cabecera> ListaC { get => listaC; set => listaC = value; }
        public List<Asignacion_Detalle> ListaD { get => listaD; set => listaD = value; }

        private Adm_Asignacion() 
        {
            v = new Validacion();
            p = new Peticion();
            cl = new Cliente();
            co = new Conductor();
            a = new Ambulancia();

            listaC = new List<Asignacion_Cabecera>();
            listaD = new List<Asignacion_Detalle>();
        }

        public static Adm_Asignacion GetAdm() 
        {
            if (adm == null)                    //3.2
            {
                adm = new Adm_Asignacion();
            }
            return adm;
        }

        /*--------------------------Frm_Asignacion_Registrar-------------------------------*/

        public void llenarTablaPeticion(DataGridView dgvPeticion)
        {
            admP.llenarTablaPeticion(dgvPeticion);
        }
    }
}
