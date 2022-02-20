using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Control {
    public class Validacion {

        public int AEntero (string entrada) {
            int x = 0;
            try {
                x = Convert.ToInt32 (entrada);
            } catch (Exception ex) {
                Console.WriteLine (ex.Message);
                //MessageBox.Show("Error: Se esperaba un número entero");
            }
            return x;
        }




        /*------------------------------------------------------*/

        #region Validation: Frm_Conductor_Registrar - errorprovider emtpy fields & incorrect email

        internal bool EsCorrectoGuardar (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, DateTimePicker dtp_FechaContrato, ErrorProvider errorProvider1) {
            bool output = true;
            string mensage = "Campo obligatorio.";
            string correo = txt_Correo.Text.Trim ();
            if (txt_Cedula.Text.Trim () == "") {
                errorProvider1.SetError (txt_Cedula, mensage);
                output = false;
            }
            if (txt_Nombre1.Text.Trim () == "") {
                errorProvider1.SetError (txt_Nombre1, mensage);
                output = false;
            }
            if (txt_Nombre2.Text.Trim () == "") {
                errorProvider1.SetError (txt_Nombre2, mensage);
                output = false;
            }
            if (txt_Apellido1.Text.Trim () == "") {
                errorProvider1.SetError (txt_Apellido1, mensage);
                output = false;
            }
            if (txt_Apellido2.Text.Trim () == "") {
                errorProvider1.SetError (txt_Apellido2, mensage);
                output = false;
            }
            if (correo == "") {
                errorProvider1.SetError (txt_Correo, mensage);
                output = false;
            } else {
                try {
                    var addr = new System.Net.Mail.MailAddress (correo);
                    //return addr.Address == correo;
                } catch {
                    errorProvider1.SetError (txt_Correo, "Correo no valido.");
                    output = false;
                }
            }
            if (txt_Telefono.Text.Trim () == "") {
                errorProvider1.SetError (txt_Telefono, mensage);
                output = false;
            }
            if (rdb_Femenino.Checked ==  rdb_Masculino.Checked) {
                errorProvider1.SetError (rdb_Femenino, mensage);
                output = false;
            }
            if (dtp_FechaNac.Text == null) {
                errorProvider1.SetError (dtp_FechaNac, mensage);
                output = false;
            }

            if (dtp_FechaContrato.Text == null) {
                errorProvider1.SetError (dtp_FechaContrato, mensage);
                output = false;
            }
            return output;
        }

        internal void Validar_Numeros_KeyPress (object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if (!char.IsControl (c) && !char.IsDigit (c)) {
                e.Handled = true;
                return;
            }
        }

        internal void Validar_Letras_KeyPress (object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if (!char.IsLetter (c) && c != ' ' && (c != Convert.ToChar (Keys.Back))) {
                e.Handled = true;
                return;
            }
        }

        internal void Validar_Correo_KeyPress (object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if (!char.IsLetter (c) && !char.IsDigit (e.KeyChar) && (c != '.') && (c != '@') && (c != '-') && (c != '_') && (c != Convert.ToChar (Keys.Back))) {
                e.Handled = true;
                return;
            }
        }

        #endregion

        /*------------------------------------------------------*/
    }
}
