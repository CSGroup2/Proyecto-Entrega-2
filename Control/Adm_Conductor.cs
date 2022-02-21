using Datos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control {
    public class Adm_Conductor {

        /*
           Aplicar el patron de diseño Singleton:
           1. Crear 1 atributo estático y privado de la misma clase.
           2. Cambiar el constructor de public a private.
           3.1. Crear un getter del atributo estático del tipo de la clase.
           3.2.Verificar si atributo es null, si es así, crearlo.
       */

        private static Adm_Conductor adm_conductor = null;    // 1.
        List<Conductor> Lista_Conductor = null;
        Conductor Conductor = null;
        Datos_Conductor Datos_Conductor = null;
        Validacion Validacion = null;
        //Persona Persona = null;

        //public Usuario_Cache UsuarioCache { get => usuarioCache; set => usuarioCache = value; }

        // Constructor: Adm_Login
        private Adm_Conductor () {                  // 2.
            Lista_Conductor = new List<Conductor> ();
            Conductor = new Conductor ();
            Datos_Conductor = new Datos_Conductor ();
            Validacion = new Validacion ();
        }

        // Getter: GetAdm
        public static Adm_Conductor GetAdm () {     // 3.1.
            if (adm_conductor == null) {                  //3.2
                adm_conductor = new Adm_Conductor ();
            }
            return adm_conductor;
        }

        /*---------------------Frm_Conductor_Consultar---------------------------------*/

        #region Frm_Conductor_Consultar

        #endregion

        /*---------------------Frm_Conductor_Editar---------------------------------*/

        #region Frm_Conductor_Editar

        #endregion

        /*---------------------Frm_Conductor_Registrar---------------------------------*/

        #region Frm_Conductor_Registrar

        // Methods for KeyPress
        public void validarSoloNumerosKeyPress (object sender, KeyPressEventArgs e) {
            // Only allows numbers on press
            Validacion.validarSoloNumerosKeyPress (sender, e);
        }

        public void validarSoloLettrasKeyPress (object sender, KeyPressEventArgs e) {
            // Only allows alphabetic characters
            Validacion.validarSoloLettrasKeyPress (sender, e);
        }

        public void validarSoloCorreoKeypress (object sender, KeyPressEventArgs e) {
            // Only allows eamil characters
            Validacion.validarSoloCorreoKeypress (sender, e);
        }

        // Methods for Buttons
        public string guardarDatosConductor (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, DateTimePicker dtp_FechaContrato, ErrorProvider errorProvider1) {
            string mensaje = "¡";
            errorProvider1.Clear ();
            if (Validacion.esCorrectoDatosConductor (txt_Cedula, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, dtp_FechaContrato, errorProvider1)) {
                string
                    cedula = txt_Cedula.Text.Trim (),
                    nombre1 = txt_Nombre1.Text.Trim (),
                    nombre2 = txt_Nombre2.Text.Trim (),
                    apellido1 = txt_Apellido1.Text.Trim (),
                    apellido2 = txt_Apellido2.Text.Trim (),
                    correo = txt_Correo.Text.Trim (),
                    telefono = txt_Telefono.Text.Trim (), 
                    sexo = Validacion.esSexo (rdb_Masculino, rdb_Femenino);
                DateTime
                    fecha_nac = dtp_FechaNac.Value.Date,
                    fecha_contrato = dtp_FechaContrato.Value.Date;
                Conductor = new Conductor (0, fecha_contrato, "", 0, cedula, nombre1, nombre2, apellido1, apellido2, sexo, fecha_nac, telefono);
                mensaje = Datos_Conductor.insertarDatosConductor (Conductor);
                MessageBox.Show (mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return mensaje;
        }

        public void limpiarCamposGuardarConductor (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, DateTimePicker dtp_FechaContrato, ErrorProvider errorProvider1) {
            errorProvider1.Clear ();
            txt_Cedula.Clear ();
            txt_Nombre1.Clear ();
            txt_Nombre2.Clear ();
            txt_Apellido1.Clear ();
            txt_Apellido2.Clear ();
            txt_Correo.Clear ();
            txt_Telefono.Clear ();
            rdb_Masculino.Checked = false;
            rdb_Femenino.Checked = false;
            dtp_FechaNac.Value = DateTime.Today;
            dtp_FechaContrato.Value = DateTime.Today;
        }
        #endregion


        /*- Billy ------------------------------------------------------*/
        internal void ListarConductoresDisponibles (DataGridView dgvConductores) {
            dgvConductores.Refresh ();
            Datos_Conductor = new Datos_Conductor ();
            dgvConductores.DataSource = Datos_Conductor.ListarConductoresDisponibles ();
        }


    }
}
