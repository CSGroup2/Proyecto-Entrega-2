using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Usuario2
    {
        private int id_usuario;
        private string nombre_usuario;
        private string correo;
        private string contrasenia;

        public Usuario2()
        {
            this.Id_usuario = 0;
            this.Nombre_usuario = "";
            this.Correo = "";
            this.Contrasenia = "";
        }

        public Usuario2(int id_usuario, string nombre_usuario, string correo, string contrasenia)
        {
            this.Id_usuario = id_usuario;
            this.Nombre_usuario = nombre_usuario;
            this.Correo = correo;
            this.Contrasenia = contrasenia;
        }

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
    }
}
