using Datos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control
{
    public class Adm_Cliente
    {
        /*
            Aplicar el patron de diseño Singleton:
            1. Crear 1 atributo estático y privado de la misma clase.
            2. Cambiar el constructor de public a private.
            3.1. Crear un getter del atributo estático del tipo de la clase.
            3.2.Verificar si atributo es null, si es así, crearlo.
        */

        private static Adm_Cliente adm_client = null;    // 1.
        Cliente client = null;
        Usuario usuario = null;
        Datos_Cliente Datos_client = null;
        Validacion validacion = null;


        // Constructor: Adm_Cliente
        private Adm_Cliente()  // 2.
        {                 
            client = new Cliente();
            usuario = new Usuario();
            Datos_client = new Datos_Cliente();
            validacion = new Validacion();
        }

        // Getter: GetAdm
        public static Adm_Cliente GetAdm()
        {     // 3.1.
            if (adm_client == null)
            {                  //3.2
                adm_client = new Adm_Cliente();
            }
            return adm_client;
        }

        public void LlenarComboHospitales(ComboBox cmbhospitales)
        {
            cmbhospitales.Items.Clear();
            cmbhospitales.DataSource = Datos_client.ConsultarHospitales();
            cmbhospitales.ValueMember = "ID_HOSPITAL";
            cmbhospitales.DisplayMember = "NOMBRE_HOSPITAL";
        }

        #region Validaciones
        // Methods for KeyPress
        public void validarSoloNumerosKeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows numbers on press
            validacion.validarSoloNumerosKeyPress(sender, e);
        }

        public void validarSoloLettrasKeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows alphabetic characters
            validacion.validarSoloLettrasKeyPress(sender, e);
        }

        public void validarSoloCorreoKeypress(object sender, KeyPressEventArgs e)
        {
            // Only allows eamil characters
            validacion.validarSoloCorreoKeypress(sender, e);
        }
        #endregion 

        public string guardarDatosCliente(TextBox txt_Cedula, ComboBox cmbhospital, int id_hospital , TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, TextBox txt_NombreUsuario, TextBox txt_Contrasenia1, TextBox txt_Contrasenia2, ErrorProvider errorProvider1)
        {
            string mensaje = "¡";
            errorProvider1.Clear();
            if (validacion.esCorrectoDatosCliente(txt_Cedula, cmbhospital, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, txt_NombreUsuario, txt_Contrasenia1, txt_Contrasenia2, errorProvider1))
            {
                int id_hosp = id_hospital; 
                string
                    cedula = txt_Cedula.Text.Trim(),
                    nombre1 = txt_Nombre1.Text.Trim(),
                    nombre2 = txt_Nombre2.Text.Trim(),
                    apellido1 = txt_Apellido1.Text.Trim(),
                    apellido2 = txt_Apellido2.Text.Trim(),
                    correo = txt_Correo.Text.Trim(),
                    telefono = txt_Telefono.Text.Trim(),
                    sexo = validacion.esSexo(rdb_Masculino, rdb_Femenino),
                    nombre_usuario = txt_NombreUsuario.Text.Trim(),
                    contrasenia1 = txt_Contrasenia1.Text.Trim();
                DateTime
                    fecha_nac = dtp_FechaNac.Value.Date;
                usuario = new Usuario(0, correo, nombre_usuario, contrasenia1);
                client = new Cliente(id_hosp, usuario, 0,  cedula, nombre1, nombre2, apellido1, apellido2, sexo,  fecha_nac, telefono);
                mensaje = Datos_client.insertarDatosCliente(client);
                MessageBox.Show(mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return mensaje;
        }

        public void limpiarCamposGuardarCliente(TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, TextBox txt_NombreUsuario, TextBox txt_Contrasenia1, TextBox txt_Contrasenia2, ErrorProvider errorProvider1)
        {
            errorProvider1.Clear();
            txt_Cedula.Clear();
            txt_Nombre1.Clear();
            txt_Nombre2.Clear();
            txt_Apellido1.Clear();
            txt_Apellido2.Clear();
            txt_Correo.Clear();
            txt_Telefono.Clear();
            rdb_Masculino.Checked = false;
            rdb_Femenino.Checked = false;
            dtp_FechaNac.Value = DateTime.Today;
            txt_NombreUsuario.Clear();
            txt_Contrasenia1.Clear();
            txt_Contrasenia2.Clear();
        }

    }
}
