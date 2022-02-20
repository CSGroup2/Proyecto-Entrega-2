using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos {
    public class Datos_Conductor
    {
        Conexion con = new Conexion();
        public object ListarConductoresDisponibles()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_listar_conductores_disponibles", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                Console.WriteLine("Error al listar los conductores " + ex.Message);
            }

            return dt;
        }
    }
}
