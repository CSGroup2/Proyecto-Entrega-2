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
    public partial class Frm_Asignacion_Registrar : Form
    {
        Adm_Asignacion adm = Adm_Asignacion.GetAdm();
        public Frm_Asignacion_Registrar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConductor_Click(object sender, EventArgs e)
        {
            Frm_Asignar_Conductor frm = new Frm_Asignar_Conductor(this);
            frm.ShowDialog();
        }

        private void btnAmbulancia_Click(object sender, EventArgs e)
        {
            Frm_Asignar_Ambulancia frm = new Frm_Asignar_Ambulancia(this);
            frm.ShowDialog();
        }

        private void btnPeticion_Click(object sender, EventArgs e)
        {
            Frm_Asignar_PeticionConsulta frm = new Frm_Asignar_PeticionConsulta(this);
            frm.ShowDialog();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }
    }
}
