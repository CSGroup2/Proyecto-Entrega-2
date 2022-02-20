using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    public class Conductor {

        // Variables
        private int id_conductor;
        private Persona persona;
        private DateTime fecha_contrato;
        private string diponibilidad;
        
        // Constructor: Default
        public Conductor () {
            this.id_conductor = 0;
            this.persona = null;
            this.fecha_contrato = new DateTime ();
            this.diponibilidad = "";
        }

        // Constructor: Parameterized
        public Conductor (int id_conductor, Persona persona, DateTime fecha_contrato, string diponibilidad) {
            this.id_conductor = id_conductor;
            this.persona = persona;
            this.fecha_contrato = fecha_contrato;
            this.diponibilidad = diponibilidad;
        }

        // Getters & Setter
        public int Id_conductor { get => id_conductor; set => id_conductor = value; }
        public Persona Persona { get => persona; set => persona = value; }
        public DateTime Fecha_contrato { get => fecha_contrato; set => fecha_contrato = value; }
        public string Diponibilidad { get => diponibilidad; set => diponibilidad = value; }

        // ToString
        public override string ToString () {
            return 
                persona.ToString() +
                "\r\nFecha de Contrato: " + fecha_contrato +
                "\r\nDisonibilidad: " + diponibilidad;
        }

    }
}
