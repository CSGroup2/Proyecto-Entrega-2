using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Cliente : Persona
    {
        private int id_cliente;
        private int id_hospital;
        private Usuario usuario;

        public Cliente() : base()
        {
            this.id_hospital = 0; 
            this.usuario = null; 
        }

        public Cliente(int id_hospital, Usuario usuario, int id_persona, string cedula, string nombre_1, string nombre_2, string apellido_1, string apellido_2, string sexo, DateTime fecha_nac, string telefono) : base(id_persona, cedula, nombre_1, nombre_2, apellido_1, apellido_2, sexo, fecha_nac, telefono)
        {
            this.id_hospital = id_hospital;
            this.usuario = usuario;
        }


        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_hospital { get => id_hospital; set => id_hospital = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
    }
}
