using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    public class Secretaria : Persona{

        // Variables
        private Usuario usuario;

        public Secretaria () : base () {
            this.usuario = null;
        }

        public Secretaria (Usuario usuario, int id_persona, string cedula, string nombre_1, string nombre_2, string apellido_1, string apellido_2, string sexo, DateTime fecha_nac, string telefono) : base (id_persona, cedula, nombre_1, nombre_2, apellido_1,  apellido_2, sexo, fecha_nac, telefono) {
            this.usuario = usuario;
        }

        public Usuario Usuario { get => usuario; set => usuario = value; }

        public override string ToString () {
            return
                base.ToString ()+
                usuario.ToString();
        }
    }
}
