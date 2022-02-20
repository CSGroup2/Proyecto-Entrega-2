using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    public class Asignacion_Detalle {

        // Variables
        private int id_asignacion_detalle;
        private Conductor conductor;
        private Ambulancia ambulancia;

        // Constructor: Default
        public Asignacion_Detalle () {
            this.id_asignacion_detalle = 0;
            this.conductor = null;
            this.ambulancia = null;
        }

        // Constructor: Parameterized
        public Asignacion_Detalle (int id_asignacion_detalle, Conductor conductor, Ambulancia ambulancia) {
            this.id_asignacion_detalle = id_asignacion_detalle;
            this.conductor = conductor;
            this.ambulancia = ambulancia;
        }

        // Getters & Setters
        public int Id_asignacion_detalle { get => id_asignacion_detalle; set => id_asignacion_detalle = value; }
        public Conductor Conductor { get => conductor; set => conductor = value; }
        public Ambulancia Ambulancia { get => ambulancia; set => ambulancia = value; }

        // ToString
        public override string ToString () {
            return
                "\r\nConductor: " + conductor.ToString () +
                "\r\nAmbulancia: " + ambulancia.ToString ();
        }

    }
}
