using Model;
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

        public string insetar(Peticion peticion)
        {
            string sql = "";
            Console.WriteLine(sql);
            string mensaje = "";
            //mensaje = con.Conectar();
            if (mensaje[0] == '1')
            {
                try
                {
                    //cmd.Connection = con.Cn1;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    return "1";
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al insertar en la tabla Peticion." + e.Message);
                    return "0" + e.Message;
                }
            }
            //con.Cerrar();
            return mensaje;
        }
    }
}
