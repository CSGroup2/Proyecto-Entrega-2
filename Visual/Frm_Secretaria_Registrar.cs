using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual {
    public partial class Frm_Secretaria_Registrar : Form {
        Adm_Secretaria admSecretaria = Adm_Secretaria.GetAdm ();

        public Frm_Secretaria_Registrar () {
            InitializeComponent ();
        }

        private void txt_Cedula_KeyPress (object sender, KeyPressEventArgs e) {
            admSecretaria.validarSoloNumerosKeyPress (sender, e);
        }

        private void txt_Nombre1_KeyPress (object sender, KeyPressEventArgs e) {
            admSecretaria.validarSoloLettrasKeyPress (sender, e);
        }

        private void txt_Correo_KeyPress (object sender, KeyPressEventArgs e) {
            admSecretaria.validarSoloCorreoKeypress (sender, e);
        }

        private void btn_Guardar_Click (object sender, EventArgs e) {
            string mensaje = admSecretaria.guardarDatosSecretaria (txt_Cedula, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, dtp_FechaContrato, txt_NombreUsuario, txt_Contrasenia1, txt_Contrasenia2, errorProvider1);
        }

        private void btn_Cancelar_Click (object sender, EventArgs e) {

        }

        private void btn_Limpiar_Click (object sender, EventArgs e) {

        }

        

    }
}
