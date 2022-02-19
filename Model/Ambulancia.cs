using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Ambulancia
    {
        private int id_ambulancia;
        private string placa;
        private string modelo;
        private string tipo_ambulancia;
        private int capacidad;
        private string observacion;
        private string disponibilidad;

        public Ambulancia()
        {
            this.id_ambulancia = 0;
            this.placa = "";
            this.modelo = "";
            this.tipo_ambulancia = "";
            this.capacidad = 0;
            this.observacion = "";
            this.disponibilidad = "";
        }

        public Ambulancia(int id_ambulancia, string placa, string modelo, string tipo_ambulancia, 
            int capacidad, string observacion, string disponibilidad)
        {
            this.id_ambulancia = id_ambulancia;
            this.placa = placa;
            this.modelo = modelo;
            this.tipo_ambulancia = tipo_ambulancia;
            this.capacidad = capacidad;
            this.observacion = observacion;
            this.disponibilidad = disponibilidad;
        }

        public int Id_ambulancia { get => id_ambulancia; set => id_ambulancia = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tipo_ambulancia { get => tipo_ambulancia; set => tipo_ambulancia = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string Disponibilidad { get => disponibilidad; set => disponibilidad = value; }

        public override string ToString()
        {
            return "\r\nPlaca: " + placa+
                "\r\nModelo: " + modelo +
                "\r\nTipo de ambulancia:" + tipo_ambulancia +
                "\r\nCapacidad: " + capacidad +
                "\r\nObservación: " + observacion +
                "\r\nDisponibilidad: " + disponibilidad ;
        }

        /*public string Estado(int d)
        {
            string estado = "";
            if (d == 1)
            {
                estado = "Disponible";
            }
            else if (d > 1)
            {
                estado = "Ocupado";
            }
            return estado;
        }*/

    }
}
