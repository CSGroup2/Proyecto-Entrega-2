using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Datos_Cliente
    {
        Conexion con = new Conexion();













        // Metodo para poder cargar todos los hospitales disponibles de la base de datos
        public DataTable ConsultarHospitales()
        {
            // Se definen las variables necesarias para la conexion y ejecucion de comandos. 
            DataTable DtResultado = new DataTable("HOSPITAL");
            SqlConnection sqlconn = con.abrir_conexion();
            SqlCommand sql_comando = null;
            try
            {
                string procedimeinto = "sp_consultar_hospitales"; //Se define que procedimiento ejecutar
                sql_comando = new SqlCommand(procedimeinto, sqlconn);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure; //Se especifico que el comando es de tipo procedimiento
                SqlDataAdapter SqlDat = new SqlDataAdapter(sql_comando);
                SqlDat.Fill(DtResultado);  //empiezo a recoger los datos
                DataRow nuevaFila = DtResultado.NewRow();

                // creo la opcion por defecto
                nuevaFila["ID_HOSPITAL"] = 0;
                nuevaFila["NOMBRE_HOSPITAL"] = "--Seleccione--";
                //inserto la opcion por defecto
                DtResultado.Rows.InsertAt(nuevaFila, 0);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                Console.WriteLine("Error al consultar los hospitales " + ex.Message);
            }
            finally
            {
                con.cerrar_conexion(sqlconn);
            }
            return DtResultado;
        }

        public string insertarDatosCliente(Cliente cliente)
        {
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            string mensaje = "";
            string procedimeinto = "sp_insertar_cliente";  // Stored Procedure name
            try
            {
                conexion = new Conexion();
                sql_conexion = conexion.abrir_conexion();              // Opens conexion to sql server
                sql_comando = new SqlCommand(procedimeinto, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                if (cliente != null)
                {
                    // Adding values to paramerters to SqlCommand below
                    sql_comando.Parameters.AddWithValue("@cedula", secretaria.Cedula);
                    sql_comando.Parameters.AddWithValue("@nombre_1", secretaria.Nombre_1);
                    sql_comando.Parameters.AddWithValue("@nombre_2", secretaria.Nombre_2);
                    sql_comando.Parameters.AddWithValue("@apellido_1", secretaria.Apellido_1);
                    sql_comando.Parameters.AddWithValue("@apellido_2", secretaria.Apellido_2);
                    sql_comando.Parameters.AddWithValue("@sexo", secretaria.Sexo);
                    sql_comando.Parameters.AddWithValue("@fecha_nac", secretaria.Fecha_nac);
                    sql_comando.Parameters.AddWithValue("@telefono", secretaria.Telefono);
                    sql_comando.Parameters.AddWithValue("@nombre_usuario", secretaria.Usuario.Nombre_usuario);
                    sql_comando.Parameters.AddWithValue("@correo", secretaria.Usuario.Correo);
                    sql_comando.Parameters.AddWithValue("@contrasenia", secretaria.Usuario.Contrasenia);
                    mensaje = Convert.ToString(sql_comando.ExecuteNonQuery());
                    if (mensaje == "-1")
                    {
                        mensaje = "¡DATOS NO GUARDADOS!";
                    }
                    else
                    {
                        mensaje = "DATOS GUARDADOS CORRECTAMENTE.";
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "OCURRIO UN ERROR. \n" + ex.Message;
            }
            finally
            {
                conexion.cerrar_conexion(sql_conexion);
            }
            return mensaje;
        }
    }
}
