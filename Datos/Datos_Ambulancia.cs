﻿using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Datos_Ambulancia
    {
        Conexion con = new Conexion();

        //INSERTA REGISTROS DE AMBULANCIAS
        public String InsertarAmbulancia(Ambulancia a)
        {
            string msj = "";
            SqlConnection c1 = con.abrir_conexion();
            try
            {
                if (a != null)
                {
                    //comando
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = c1;
                    comando.CommandText = "sp_insertar_ambulancia";
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlParameter param_placa = new SqlParameter();
                    param_placa.ParameterName = "@placa";
                    param_placa.SqlDbType = SqlDbType.VarChar;
                    param_placa.Value = a.Placa;
                    comando.Parameters.Add(param_placa);

                    SqlParameter param_modelo = new SqlParameter();
                    param_modelo.ParameterName = "@modelo";
                    param_modelo.SqlDbType = SqlDbType.VarChar;
                    param_modelo.Value = a.Modelo;
                    comando.Parameters.Add(param_modelo);

                    SqlParameter param_tipo_ambulancia = new SqlParameter();
                    param_tipo_ambulancia.ParameterName = "@tipo_ambulancia";
                    param_tipo_ambulancia.SqlDbType = SqlDbType.Int;
                    param_tipo_ambulancia.Value = a.Tipo_ambulancia;
                    comando.Parameters.Add(param_tipo_ambulancia);

                    SqlParameter param_capacity = new SqlParameter();
                    param_capacity.ParameterName = "@capacidad";
                    param_capacity.SqlDbType = SqlDbType.Int;
                    param_capacity.Value = a.Capacidad;
                    comando.Parameters.Add(param_capacity);

                    SqlParameter param_observacion = new SqlParameter();
                    param_observacion.ParameterName = "@capacidad";
                    param_observacion.SqlDbType = SqlDbType.VarChar;
                    param_observacion.Value = a.Observacion;
                    comando.Parameters.Add(param_observacion);

                    msj = comando.ExecuteNonQuery() == 1 ? "Ok" : "No se ingreso el registro";
                }    
            }
            catch (Exception ex)
            {
                con.cerrar_conexion(c1);
                msj = "OCURRIO UN ERROR " + ex.Message;
            }
            return msj;
        }

        public DataTable ConsultarTipo()
        {
            DataTable DtResultado = new DataTable("TIPO_AMBULANCIA");
            SqlConnection c1 = con.abrir_conexion();
            try
            {
                string sentencia = "Select * from TIPO_AMBULANCIA where ID_ESTADO = 1";
                SqlCommand comando = new SqlCommand(sentencia, c1);
                SqlDataAdapter SqlDat = new SqlDataAdapter(comando);
                SqlDat.Fill(DtResultado);
                DataRow nuevaFila = DtResultado.NewRow();

                nuevaFila["ID_TIPO_AMBULANCIA"] = 0;
                nuevaFila["NOMBRE_TIPO_AMBULANCIA"] = "--Seleccione--";

                DtResultado.Rows.InsertAt(nuevaFila, 0);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                //MessageBox.Show("Eroor: " + ex);
            }
            return DtResultado;
        }

        public bool ConsultarPlaca(string text)
        {
            throw new NotImplementedException();
        }
    }
}