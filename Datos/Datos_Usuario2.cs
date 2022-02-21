using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Datos_Usuario2
    {
        public Tuple<string, int> insertarusuario(Usuario2 user, ref SqlTransaction Sqltra, ref SqlConnection connex)
        {

            int id_usuario = 0;
            string msj = "";
            try
            {
                if (user != null)
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = connex;
                    comando.Transaction = Sqltra;
                    comando.CommandText = "insertar_usuario";
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramid_usuario = new SqlParameter();
                    paramid_usuario.ParameterName = "@id_usuario";
                    paramid_usuario.SqlDbType = SqlDbType.Int;
                    paramid_usuario.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(paramid_usuario);

                    SqlParameter paramnameuser = new SqlParameter();
                    paramnameuser.ParameterName = "@nameuser";
                    paramnameuser.SqlDbType = SqlDbType.VarChar;
                    paramnameuser.Value = user.Nombre_usuario;
                    comando.Parameters.Add(paramnameuser);

                    SqlParameter paramcorreo = new SqlParameter();
                    paramcorreo.ParameterName = "@correo";
                    paramcorreo.SqlDbType = SqlDbType.VarChar;
                    paramcorreo.Value = user.Correo;
                    comando.Parameters.Add(paramcorreo);

                    SqlParameter paramcontra = new SqlParameter();
                    paramcontra.ParameterName = "@contra";
                    paramcontra.SqlDbType = SqlDbType.VarChar;
                    paramcontra.Value = user.Contrasenia;
                    comando.Parameters.Add(paramcontra);

                    msj = comando.ExecuteNonQuery() == 1 ? "Ok" : "No se ingreso el registro";

                    id_usuario = Convert.ToInt16(comando.Parameters["@id_usuario"].Value);
                }
            }

            catch (Exception ex)
            {
                msj = "OCURRIO UN ERROR " + ex.Message + ex.StackTrace;
            }
            return Tuple.Create(msj, id_usuario);
        }
    }
}
