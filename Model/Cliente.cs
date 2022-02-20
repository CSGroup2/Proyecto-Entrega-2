using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Cliente : Persona2
    {
        private int id_cliente;
        private int id_hospital;
        private Usuario2 usuario;

        public Cliente() : base()
        {
            this.id_hospital = 0; 
            this.usuario = null; 
        }

        public Cliente(int id_cliente, int id_hospital, Usuario2 usuario)
        {
            this.id_cliente = id_cliente;
            this.id_hospital = id_hospital;
            this.usuario = usuario;
        }

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_hospital { get => id_hospital; set => id_hospital = value; }
        public Usuario2 Usuario { get => usuario; set => usuario = value; }
    }
}
