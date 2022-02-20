﻿using Model;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control
{
    public class Adm_Peticion
    {

        /*
            Aplicar el patron de diseño Singleton:
            1. Crear 1 atributo estático y privado de la misma clase.
            2. Cambiar el constructor de public a private.
            3.1. Crear un getter del atributo estático del tipo de la clase.
            3.2.Verificar si atributo es null, si es así, crearlo.
        */

        private static Adm_Peticion adm=null;   // 1.

        Validacion v = null;
        Peticion peticion = null;
        Cliente cliente = null;

        List<Peticion> lista = null;

        Adm_Login admL = Adm_Login.GetAdm();
        Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();

        public List<Peticion> Lista { get => lista; set => lista = value; }

        // Constructor: Adm_Peticion
        private Adm_Peticion()                  // 2.
        {
            v = new Validacion();
            peticion = new Peticion();
            lista = new List<Peticion>();
            cliente = new Cliente();
        }

        // Getter: GetAdm
        public static Adm_Peticion GetAdm()     // 3.1.
        {
            if (adm == null)                    //3.2
            {
                adm = new Adm_Peticion();
            }
            return adm;
        }

        /*--------------------------Frm_Peticion_Registrar-------------------------------*/

        public void guardarPeticion(string cantAmb, string tipo_ambulancia,string punto_Origen, string punto_Destino)
        {
            cliente = new Cliente();
            cliente.Id_cliente = admL.IdUsuario();

            //Validar datos
            int tAmb = v.AEntero(tipo_ambulancia);
            int nAmb = v.AEntero(cantAmb);

            Peticion peticion = new Peticion(cliente, tAmb, nAmb, punto_Origen, punto_Destino, DateTime.Now);
            
            Lista.Add(peticion);            //Añadir la peticion a la lista
            guardarPeticionBDD(peticion);   //Mandar la peticion a la base de datos
        }

        public void datosCliente(Label lbl_cedula, Label lbl_nombre, Label lbl_apellido)
        {
            lbl_cedula.Text = CedulaUsuario();
            lbl_nombre.Text = admL.NombreUsuario();
            lbl_apellido.Text = admL.ApellidoUsuario();
        }

        public void llenarTipoAmb(ComboBox cmb_TAmb)
        {
            admA.LlenarComboTipoAmbulancia(cmb_TAmb);
        }

        public void borrarTipeos(NumericUpDown nud_Ambulancia, TextBox txt_Origen, TextBox txt_Destino)
        {
            nud_Ambulancia.Value=1;
            txt_Origen.Text = "";
            txt_Destino.Text = "";
        }

        public string CedulaUsuario()
        {
            string cedula = "";
            cedula = datosPeticion.consultarCedula(admL.IdUsuario());
            return cedula;
        }

        /*--------------------------Enviar a Base de Datos-------------------------------*/

        Datos_Peticion datosPeticion = new Datos_Peticion();

        // Guardar la petición en la Base de Datos
        private void guardarPeticionBDD(Peticion peticion)
        {
            string mensaje = "";
            mensaje = datosPeticion.insetar(peticion);
            if (mensaje[0] == '1')
                MessageBox.Show("Su petición fue ingresada correctamente.");
            else
                MessageBox.Show("Error: " + mensaje);
        }
    }
}