using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public SqlCommand Comando
        {
            get { return comando; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=PROMOS_DB; integrated security=true");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
 
            }
            finally 
            {
                limpiarParametros();
                conexion.Close();
            }
        }

        public void cerrarConexion()
        {
            if(lector != null) 
                lector.Close();
            conexion.Close();
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public int EjecutarAccionYTraerId()
        {
            comando.Connection = conexion;
            int id;

            try
            {
                conexion.Open();
                id = (int)comando.ExecuteScalar();
                return id;
            }
            catch (Exception ex)
            { 
                throw ex;
            }
            finally 
            { 
                conexion.Close(); 
            }
        }

        public void limpiarParametros()
        {
            comando.Parameters.Clear();
        }
    }
}
