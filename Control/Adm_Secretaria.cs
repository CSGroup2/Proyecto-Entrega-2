using Datos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control {
    public class Adm_Secretaria {

        /*
           Aplicar el patron de diseño Singleton:
           1. Crear 1 atributo estático y privado de la misma clase.
           2. Cambiar el constructor de public a private.
           3.1. Crear un getter del atributo estático del tipo de la clase.
           3.2.Verificar si atributo es null, si es así, crearlo.
       */

        private static Adm_Secretaria adm_secretaria = null;    // 1.
        List<Secretaria> Lista_Secretaria = null;
        Secretaria Secretaria = null;
        Datos_Secretaria Datos_Secretaria = null;
        Validacion Validacion = null;

        // Constructor: Adm_Login
        private Adm_Secretaria () {                  // 2.
            Lista_Secretaria = new List<Secretaria> ();
            Secretaria = new Secretaria ();
            Datos_Secretaria = new Datos_Secretaria ();
            Validacion = new Validacion ();
        }

        // Getter: GetAdm
        public static Adm_Secretaria GetAdm () {        // 3.1.
            if (adm_secretaria == null) {               //3.2
                adm_secretaria = new Adm_Secretaria ();
            }
            return adm_secretaria;
        }


        /*-----------------------------------------------------*/

    }
}
