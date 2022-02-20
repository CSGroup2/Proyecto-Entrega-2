
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

        public string consultarCedula(int v)
        {
            string ced = "";
            SqlConnection conexion = con.abrir_conexion();
            try 
            {
                SqlCommand cmd = new SqlCommand("SELECT P.CEDULA FROM PERSONA P, CLIENTE C WHERE (P.ID_PERSONA=C.ID_PERSONA AND C.ID_ESTADO=1) AND C.ID_CLIENTE=@ID;", conexion);
                cmd.Parameters.AddWithValue("@ID", v);
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    ced = registro["CEDULA"].ToString();
                }
            } catch (Exception ex)
            {
                con.cerrar_conexion(conexion);
            }
            return ced;
        }

        public string insetar(Peticion peticion)
        {
            throw new NotImplementedException();
        }
    }
}
