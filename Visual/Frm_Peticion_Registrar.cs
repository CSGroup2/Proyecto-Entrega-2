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
    public partial class Frm_Peticion_Registrar : Form {

        Adm_Peticion adm = Adm_Peticion.GetAdm();

        public Frm_Peticion_Registrar () {
            InitializeComponent ();
            adm.datosCliente(lbl_cedula,lbl_nombre, lbl_apellido);
        }

        // Cerrar formulario
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Guardar peticion
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string cantAmb = nud_Ambulancia.Value.ToString(), punto_Origen=txt_Origen.Text, punto_Destino=txt_Destino.Text;
            //verificamos si los campos están llenos
            if (txt_Origen.Text != "" && txt_Destino.Text != "")
                adm.guardarPeticion(cantAmb, punto_Origen, punto_Destino);
            else
                MensajeError("Por favor ingrese los datos necesarios.");
        }

        // Borrar lo que tipeó
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            adm.borrarTipeos(nud_Ambulancia, txt_Origen, txt_Destino);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
