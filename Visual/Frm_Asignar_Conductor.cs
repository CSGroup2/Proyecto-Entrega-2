using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual
{
    public partial class Frm_Asignar_Conductor : Form
    {
        Adm_Asignacion adm = Adm_Asignacion.GetAdm();
        public Frm_Asignar_Conductor()
        {
            InitializeComponent();
            adm.llenarTablaConductorAsignar(dgvConductores);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
