using Datos;
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
        Asignacion_Detalle ad = null;
        Asignacion_Cabecera ac = null;
        Secretaria s = null;

        List<Asignacion_Cabecera> listaC = null;
        List<Asignacion_Detalle> listaD = null;

        Adm_Login admL = Adm_Login.GetAdm();
        Adm_Peticion admP = Adm_Peticion.GetAdm();
        Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();
        Adm_Conductor admCo = Adm_Conductor.GetAdm();

        public List<Asignacion_Cabecera> ListaC { get => listaC; set => listaC = value; }
        public List<Asignacion_Detalle> ListaD { get => listaD; set => listaD = value; }

        private Adm_Asignacion() 
        {
            v = new Validacion();
            p = new Peticion();
            cl = new Cliente();
            co = new Conductor();
            a = new Ambulancia();
            ad = new Asignacion_Detalle();
            ac = new Asignacion_Cabecera();
            s = new Secretaria();

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


        /*--------------------------Frm_Asignar_Ambulancia-------------------------------*/

        public void llenarTablaAmbulanciaAsignar(DataGridView dgvAmbulancia)
        {
            admA.ListarAmbulanciasDisponibles(dgvAmbulancia);
        }

        public void llenarTablaConductorAsignar(DataGridView dgvConductores)
        {
            admCo.ListarConductoresDisponibles(dgvConductores);
        }

        public void enlistarCond_AmbAsignados(string id_peticion, string id_conductor, string id_ambulancia, DataGridView dgvAmb_Cond)
        {
            int id_P = v.AEntero(id_peticion), id_C=v.AEntero(id_conductor), id_A=v.AEntero(id_ambulancia);

            p = new Peticion();
            p.Id_peticion = id_P;

            co = new Conductor();
            co.Id_conductor = id_C;

            a = new Ambulancia();
            a.Id_ambulancia = id_A;

            ad = new Asignacion_Detalle(p, co, a);
            ListaD.Add(ad);
            llenarDgvCA(dgvAmb_Cond,ListaD);
        }

        private void llenarDgvCA(DataGridView dgvAmb_Cond, List<Asignacion_Detalle> listaD)
        {
            dgvAmb_Cond.Rows.Clear();
            foreach (Asignacion_Detalle x in listaD) 
            {
                dgvAmb_Cond.Rows.Add(x.Peticion.Id_peticion, x.Conductor.Id_conductor, x.Ambulancia.Id_ambulancia);
            }
        }

        public void guardarAsignacion(string id_peticion)
        {
            int id_S = admL.IdUsuario();
            int id_P = v.AEntero(id_peticion);

            p = new Peticion();
            p.Id_peticion = id_P;

            s = new Secretaria();
            s.Id_secretaria = id_S;

            ac = new Asignacion_Cabecera(p, s, "En Progreso", ListaD);
            
            ListaC.Add(ac);
            guardarAsignacionBD(ListaC,ListaD);
        }

        Datos_Asignacion datosAsignacion = new Datos_Asignacion();

        private void guardarAsignacionBD(List<Asignacion_Cabecera> ac,List<Asignacion_Detalle> ad)
        {
            string mensaje = "";
            mensaje = datosAsignacion.insetarAsignacion(ac,ad);
            if (mensaje[0] == '1')
                MessageBox.Show("La Asignación fue ingresada correctamente.");
            else
                MessageBox.Show("Error: " + mensaje);
        }
    }
}
