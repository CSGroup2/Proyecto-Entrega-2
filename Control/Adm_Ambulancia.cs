using Datos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Control
{
    public class Adm_Ambulancia
    {
        private static Adm_Ambulancia adm = new Adm_Ambulancia();
        Datos_Ambulancia dAmbulancia = new Datos_Ambulancia();

        List<Ambulancia> ambulancias = null;
        Ambulancia a = null;

        public List<Ambulancia> Ambulancias { get => ambulancias; set => ambulancias = value; }
        public Ambulancia A { get => a; set => a = value; }
    
        public static Adm_Ambulancia GetAdm()
        {
            if(adm == null)
            {
                adm = new Adm_Ambulancia();
            }
            return adm;
        }

        public void LlenarComboTipoAmbulancia(ComboBox cmbTipo)
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("---Seleccione---");
            cmbTipo.SelectedIndex = 0;
            cmbTipo.DataSource = dAmbulancia.ConsultarTipo();
            cmbTipo.ValueMember = "ID_AMBULANCIA";
            cmbTipo.DisplayMember = "NOMBRE_TIPO_AMBULANCIA";
            
        }

        // Método que valida las entradas de datos en módulo ambulancias y lanza un error visible para el usuario
        public bool Validar(TextBox txtPlaca, TextBox txtModelo, ComboBox cmbTipo, TextBox txtCapacidad, TextBox txtObservacion, ErrorProvider errorP)
        {
            bool no_error = true;
            string placa = txtPlaca.Text;
            if (String.IsNullOrEmpty(txtPlaca.Text.Trim()))
            {
                errorP.SetError(txtPlaca, "Ingrese la placa");
                no_error = false;
            }
            if (!Regex.IsMatch(placa, "^[A-Z]{3}[0-9]{3}$") || !Regex.IsMatch(placa, "^[A-Z]{3}[0-9]{4}$"))
            {
                errorP.SetError(txtPlaca, "La placa debe contener de 3 letras y 3-4 dígitos");
                no_error = false;
            }
            if (dAmbulancia.ConsultarPlaca(placa))
            {
                errorP.SetError(txtPlaca, "La placa ya está registrada");
                no_error = false;
            }
            if (String.IsNullOrEmpty(txtModelo.Text))
            {
                errorP.SetError(txtModelo, "Ingrese el modelo de la ambulancia");
                no_error = false;
            }
            if (cmbTipo.Text == "--Seleccionar--")
            {
                errorP.SetError(cmbTipo, "Seleccione un tipo de ambulancia");
                no_error = false;
            }
            if (String.IsNullOrEmpty(txtCapacidad.Text.Trim()))
            {
                errorP.SetError(txtCapacidad, "Ingrese la capacidad de la ambulancia");
                no_error = false;
            }
            if (Int32.Parse(txtCapacidad.Text) < 0 || Int32.Parse(txtCapacidad.Text) > 20)
            {
                errorP.SetError(txtCapacidad, "Ingrese un dato real");
                no_error = false;
            }
            if (String.IsNullOrEmpty(txtObservacion.Text))
            {
                errorP.SetError(txtObservacion, "Ingrese detalles de la ambulancia");
                no_error = false;
            }
            return no_error;
        }

        //
        public void Guardar(int id_ambulancia, string placa, string modelo, string tipoA, int capacidad, string observacion)
        {
            Ambulancia a = null;
            if (dAmbulancia.ConsultarPlaca(placa) == false)
            {
                a = new Ambulancia(id_ambulancia, placa, modelo, tipoA, capacidad, observacion, "disponible");
                ambulancias.Add(a);
                GuardarBD(a);
            }
            else
            {
                MessageBox.Show("La ambulancia ya existe");
            }
        }

        public void GuardarBD(Ambulancia a)
        {
            string mensaje = "";
            mensaje = dAmbulancia.InsertarAmbulancia(a);
            if (mensaje[0] == '1')
                MessageBox.Show("Ingreso de datos correctamente");
            else
                MessageBox.Show("Error: " + mensaje);
        }


        public void Agregar(TextBox txtRegistro)
        {
            if (ambulancias.Count != 0)
                txtRegistro.Text += Ambulancias[Ambulancias.Count - 1].ToString() + "\r\n";
        }
    }
}
