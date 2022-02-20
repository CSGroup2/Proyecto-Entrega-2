using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Persona2
    {
        private int id_persona;
        private string cedula;
        private string nombre1;
        private string nombre_2;
        private string apellido_1;
        private string apellido_2;
        private string sexo;
        private DateTime fecha_nac;
        private string telefono;

        public Persona2(int id_persona, string cedula, string nombre1, string nombre_2, string apellido_1, string apellido_2, string sexo, DateTime fecha_nac, string telefono)
        {
            this.Id_persona = id_persona;
            this.Cedula = cedula;
            this.Nombre1 = nombre1;
            this.Nombre_2 = nombre_2;
            this.Apellido_1 = apellido_1;
            this.Apellido_2 = apellido_2;
            this.Sexo = sexo;
            this.Fecha_nac = fecha_nac;
            this.Telefono = telefono;
        }

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre1 { get => nombre1; set => nombre1 = value; }
        public string Nombre_2 { get => nombre_2; set => nombre_2 = value; }
        public string Apellido_1 { get => apellido_1; set => apellido_1 = value; }
        public string Apellido_2 { get => apellido_2; set => apellido_2 = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
