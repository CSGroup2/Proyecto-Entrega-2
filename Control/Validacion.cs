using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Control {
    public class Validacion {

        public int AEntero(string entrada)
        {
            int x = 0;
            try
            {
                x = Convert.ToInt32(entrada);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show("Error: Se esperaba un número entero");
            }
            return x;
        }
    }
}
