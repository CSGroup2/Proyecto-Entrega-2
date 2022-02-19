using Datos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Control
{
    public class Adm_Ambulancia
    {
        private Conexion con = new Conexion();
        private static Adm_Ambulancia adm = new Adm_Ambulancia();
        Datos_Ambulancia dAmbulancia = new Datos_Ambulancia();

        List<Ambulancia> ambulancias = null;
        Ambulancia a = null;

        public List<Ambulancia> Ambulancias { get => ambulancias; set => ambulancias = value; }
        public Ambulancia A { get => a; set => a = value; }
    
        public static Adm_Ambulancia GetAdm()
        {
            if(adm == null)
            {
                adm = new Adm_Ambulancia();
            }
            return adm;
        }

        //

    }
}
