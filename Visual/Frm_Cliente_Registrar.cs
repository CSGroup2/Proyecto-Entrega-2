using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual {
    public partial class Frm_Cliente_Registrar : Form {

        Adm_Cliente admclient = Adm_Cliente.GetAdm();
        Btn_Comportamiento cbtn = new Btn_Comportamiento ();

        public Frm_Cliente_Registrar () {
            InitializeComponent ();
        }

        private void FrmClienteReg_Load (object sender, EventArgs e) {
            this.pncontenido.BackColor = Color.FromArgb (200, 255, 255, 255);
            admclient.LlenarComboHospitales(cbxhospitales);

        }

        #region Efectos boton Guardar
        private void btnguardar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnguardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efectos boton Cancelar
        private void btncancelar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btncancelar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efectos boton limpiar
        private void btnlimpiar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnlimpiar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        

        private void txt_soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            admclient.validarSoloNumerosKeyPress(sender, e);
        }

        private void txt_sololetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            admclient.validarSoloLettrasKeyPress(sender, e);
        }

        private void txt_formatocorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            admclient.validarSoloCorreoKeypress(sender, e);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int Id_hospital = Int16.Parse(cbxhospitales.SelectedValue.ToString());
            string mensaje = admclient.guardarDatosCliente(txt_cedula, cbxhospitales, Id_hospital, txt_nombre1, txt_nombre2, txt_apellido1, txt_apellido2, txt_correo, txt_numtelf, opr_masculino, opr_femenino, dtp_fechanac ,txt_usuario, txt_contra, txt_confirmarcontra, errpvdatoscliente);
            if (mensaje[0] != '¡')
            {
                admclient.limpiarCamposGuardarCliente(txt_cedula, cbxhospitales, txt_nombre1, txt_nombre2, txt_apellido1, txt_apellido2, txt_correo, txt_numtelf, opr_masculino, opr_femenino, dtp_fechanac, txt_usuario, txt_contra, txt_confirmarcontra, errpvdatoscliente);
            }
        }
    }
}
