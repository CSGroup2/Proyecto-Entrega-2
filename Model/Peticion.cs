using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Peticion
    {
        private int id_peticion;
        private Cliente cliente;
        private int n_ambulancia;
        private string punto_origen;
        private string punto_destino;
        private DateTime fecha_registro;
        private Estado estado;

        public Peticion()
        {
        }

        public Peticion(Cliente cliente, int n_ambulancia, string punto_origen, string punto_destino, DateTime fecha_registro)
        {
            this.cliente = cliente;
            this.n_ambulancia = n_ambulancia;
            this.punto_origen = punto_origen;
            this.punto_destino = punto_destino;
            this.fecha_registro = fecha_registro;
        }

        public int Id_peticion { get => id_peticion; set => id_peticion = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int N_ambulancia { get => n_ambulancia; set => n_ambulancia = value; }
        public string Punto_origen { get => punto_origen; set => punto_origen = value; }
        public string Punto_destino { get => punto_destino; set => punto_destino = value; }
        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        //public Estado EstadoA { get => estado; set => estado = value; }
    }
}
