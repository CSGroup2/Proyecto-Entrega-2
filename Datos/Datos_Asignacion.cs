using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos {
    public class Datos_Asignacion
    {
        Conexion con = new Conexion();

        public string insetarAsignacion(Asignacion_Cabecera ac, Asignacion_Detalle ad)
        {
            string msj = "";
            SqlConnection conexion = con.abrir_conexion();

            try 
            {
                //comando
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "sp_insertar_asignacion";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter param_id_cab = new SqlParameter();
                param_id_cab.ParameterName = "@id_a_cabecera";
                param_id_cab.SqlDbType = SqlDbType.Int;
                param_id_cab.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param_id_cab);

                SqlParameter param_id_peticion = new SqlParameter();
                param_id_peticion.ParameterName = "@id_peticion";
                param_id_peticion.SqlDbType = SqlDbType.Int;
                param_id_peticion.Value = ac.Peticion.Id_peticion;
                comando.Parameters.Add(param_id_peticion);

                SqlParameter param_id_secretaria = new SqlParameter();
                param_id_secretaria.ParameterName = "@id_secretaria";
                param_id_secretaria.SqlDbType = SqlDbType.Int;
                param_id_secretaria.Value = ac.Secretaria.Id_secretaria;
                comando.Parameters.Add(param_id_secretaria);

                SqlParameter param_condicion = new SqlParameter();
                param_condicion.ParameterName = "@condicion";
                param_condicion.SqlDbType = SqlDbType.VarChar;
                param_condicion.Value = ac.Condicion;
                comando.Parameters.Add(param_condicion);

                int idC = Convert.ToInt32(comando.Parameters["@id_a_cabecera"].Value);
                int idP = Convert.ToInt32(comando.Parameters["@id_peticion"].Value);

                foreach (Asignacion_Detalle x in ac.Asignacion_detalle) 
                {
                    if (idP == x.Peticion.Id_peticion) 
                    {
                        SqlParameter param_id_cad_det = new SqlParameter();
                        param_id_cad_det.ParameterName = "@id_a_cab_det";
                        param_id_cad_det.SqlDbType = SqlDbType.Int;
                        param_id_cad_det.Value = idC;
                        comando.Parameters.Add(param_id_cad_det);

                        SqlParameter param_id_conductor = new SqlParameter();
                        param_id_conductor.ParameterName = "@id_conductor";
                        param_id_conductor.SqlDbType = SqlDbType.Int;
                        param_id_conductor.Value = x.Conductor.Id_conductor;
                        comando.Parameters.Add(param_id_conductor);

                        SqlParameter param_id_ambulancia = new SqlParameter();
                        param_id_ambulancia.ParameterName = "@id_ambulancia";
                        param_id_ambulancia.SqlDbType = SqlDbType.Int;
                        param_id_ambulancia.Value = x.Ambulancia.Id_ambulancia;
                        comando.Parameters.Add(param_id_ambulancia);
                    }
                }

                comando.ExecuteNonQuery();
                msj = "1";
            }
            catch (Exception ex)
            {
                con.cerrar_conexion(conexion);
                msj = "OCURRIO UN ERROR " + ex.Message;
            }
            return msj;
        }
    }
}
