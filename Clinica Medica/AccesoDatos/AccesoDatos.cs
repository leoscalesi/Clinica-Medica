using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        //EN EL CONSTRUCTOR ARMO EL ConnectionString
        //INSTANCIO UN OBJETO DE TIPO SqlCommand
        public AccesoDatos()        
        {
            conexion = new SqlConnection("server=(local)\\SQLEXPRESS ; database=Clinica_Medica; integrated security= true");
            comando = new SqlCommand();
        }

        //HAGO EL GET DEL LECTOR
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //LE PASO AL COMANDO LA CONSULTA
        public void setearConsulta (string consulta)
        {
            //LE DIGO QUE MI CONSULTA VIENE DESDE UN STRING
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }


        public void ejecutarLectura()
        {
            //LE PASO AL COMNADO EL Connection String
            comando.Connection = conexion;

            //EJECUTO Y GURADO EN UN OBJETO DE TIPO SqlDataReader
            //EL RESULTADO DE LA CONSULTA

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }

            catch(Exception ex)
            {
                throw ex;
            }
        }
    
    }
}
