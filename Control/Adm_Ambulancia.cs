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

        //Si los haces null los llamas en los metodos de abajo no los vuelves a crear
        List<Ambulancia> ambulancias = null;
        Ambulancia a = null;//ta por gusto

        //Tienes que llamar a estos que tienen letra mauscula revisa mi Adm_Peticion en el guardar
        public List<Ambulancia> Ambulancias { get => ambulancias; set => ambulancias = value; }
        public Ambulancia A { get => a; set => a = value; }//ta por gusto

        public Adm_Ambulancia()
        {
            ambulancias = new List<Ambulancia>();
        }

        public static Adm_Ambulancia GetAdm()
        {
            if(adm == null)
            {
                adm = new Adm_Ambulancia();
            }
            return adm;
        }

        //método para cargar los datos al combobox de Tipo Ambulancia
        public void LlenarComboTipoAmbulancia(ComboBox cmbTipo)
        {
            cmbTipo.Items.Clear();
            cmbTipo.DataSource = dAmbulancia.ConsultarTipo();
            cmbTipo.ValueMember = "ID_TIPO_AMBULANCIA";
            cmbTipo.DisplayMember = "NOMBRE_TIPO_AMBULANCIA";
            
        }

        // Método que valida las entradas de datos en módulo ambulancias y lanza un error visible para el usuario
        public bool Validar(TextBox txtPlaca, TextBox txtModelo, ComboBox cmbTipo, TextBox txtCapacidad, TextBox txtObservacion, ErrorProvider errorP)
        {
            bool no_error = true;
            string placa = txtPlaca.Text;
            var regex = new Regex("[a-zA-Z]{3}[0-9]{3}|[a-zA-Z]{3}[0-9]{4}");
            if (String.IsNullOrEmpty(txtPlaca.Text.Trim()))
            {
                errorP.SetError(txtPlaca, "Ingrese la placa");
                no_error = false;
            }
            if (!regex.IsMatch(placa))
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
            if (cmbTipo.Text == "--Seleccione--")
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

        //método para receptar los datos y guardar temporalmente en una lista
        public void Guardar(int id_ambulancia, string placa, string modelo, int tipoA, int capacidad, string observacion, int disponibilidad)
        {
            Ambulancia a = null;//esta linea ta por gusto
            if (dAmbulancia.ConsultarPlaca(placa) == false)
            {
                a = new Ambulancia(id_ambulancia, placa, modelo, tipoA, capacidad, observacion, disponibilidad);
                ambulancias.Add(a); // Ambulancias.add(a);
                GuardarBD(a);
            }
            else
            {
                MessageBox.Show("La ambulancia ya existe");
            }
        }

        //método para insertar los datos de la lista en la BD
        public void GuardarBD(Ambulancia a)
        {
            string mensaje = "";
            mensaje = dAmbulancia.InsertarAmbulancia(a);
            if (mensaje[0] == '1')
            {
                MessageBox.Show("Ingreso de datos correctamente");
            }
            else
            {
                MessageBox.Show("Error: " + mensaje);
            }
                
        }

        //método para limpiar campos
        public void LimpiarCampos(TextBox txtPlaca, TextBox txtModelo, ComboBox cmbTipo, TextBox txtCapacidad, TextBox txtObservacion)
        {
            txtPlaca.Text = "";
            txtModelo.Text = "";
            cmbTipo.SelectedIndex = 0;
            txtCapacidad.Text = "";
            txtObservacion.Text = "";
        }

        //

    }
}
