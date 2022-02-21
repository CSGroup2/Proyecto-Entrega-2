using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Datos_Persona2
    {
        Conexion con = new Conexion();

        public String insertarpersona(Persona2 person, ref SqlTransaction Sqltra, ref SqlConnection connex)
        {
            string msj = "";

            //ref SqlTransaction Sqltra;
            /*try
            {*/
                SqlCommand comando = new SqlCommand();
                comando.Connection = connex;
                comando.Transaction = Sqltra;
                comando.CommandText = "insertar_persona";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter paramid_persona = new SqlParameter();
                paramid_persona.ParameterName = "@id_persona";
                paramid_persona.SqlDbType = SqlDbType.Int;
                paramid_persona.Direction = ParameterDirection.Output;
                comando.Parameters.Add(paramid_persona);

                SqlParameter paramcedula = new SqlParameter();
                paramcedula.ParameterName = "@cedula";
                paramcedula.SqlDbType = SqlDbType.VarChar;
                paramcedula.Value = person.Cedula;
                comando.Parameters.Add(paramcedula);

                SqlParameter paramnombre1 = new SqlParameter();
                paramnombre1.ParameterName = "@nombre1";
                paramnombre1.SqlDbType = SqlDbType.VarChar;
                paramnombre1.Value = person.Nombre_1;
                comando.Parameters.Add(paramnombre1);

                SqlParameter paramnombre2 = new SqlParameter();
                paramnombre2.ParameterName = "@nombre2";
                paramnombre2.SqlDbType = SqlDbType.VarChar;
                paramnombre2.Value = person.Nombre_2;
                comando.Parameters.Add(paramnombre2);

                SqlParameter parapellido1 = new SqlParameter();
                parapellido1.ParameterName = "@apellido1";
                parapellido1.SqlDbType = SqlDbType.VarChar;
                parapellido1.Value = person.Apellido_1;
                comando.Parameters.Add(parapellido1);

                SqlParameter parapellido2 = new SqlParameter();
                parapellido2.ParameterName = "@apellido2";
                parapellido2.SqlDbType = SqlDbType.VarChar;
                parapellido2.Value = person.Apellido_2;
                comando.Parameters.Add(parapellido2);

                SqlParameter sexo = new SqlParameter();
                sexo.ParameterName = "@sexo";
                sexo.SqlDbType = SqlDbType.VarChar;
                sexo.Value = person.Sexo;
                comando.Parameters.Add(sexo);

                SqlParameter paramfechanac = new SqlParameter();
                paramfechanac.ParameterName = "@fechanac";
                paramfechanac.SqlDbType = SqlDbType.Date;
                paramfechanac.Value = person.Fecha_nac;
                comando.Parameters.Add(paramfechanac);

                SqlParameter telefono = new SqlParameter();
                telefono.ParameterName = "@telefono";
                telefono.SqlDbType = SqlDbType.VarChar;
                telefono.Value = person.Fecha_nac;
                comando.Parameters.Add(telefono);


            return msj;
        }


    }
}
