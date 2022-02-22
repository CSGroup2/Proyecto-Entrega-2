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
        Datos_Cliente Datos_client = null;
        Validacion validacion = null;


        // Constructor: Adm_Cliente
        private Adm_Cliente()  // 2.
        {                 
            client = new Cliente();
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

        public void LlenarComboTipoAmbulancia(ComboBox cmbTipo)
        {
            cmbTipo.Items.Clear();
            // cmbTipo.DataSource = dAmbulancia.ConsultarTipo();
            cmbTipo.ValueMember = "ID_TIPO_AMBULANCIA";
            cmbTipo.DisplayMember = "NOMBRE_TIPO_AMBULANCIA";

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


    }
}
