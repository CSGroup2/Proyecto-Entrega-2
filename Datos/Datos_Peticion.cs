
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Datos_Peticion
    {
        Conexion con = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public object cargarTipoAmb()
        {
            throw new NotImplementedException();
        }
    }
}
