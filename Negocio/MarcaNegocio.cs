using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {
            List<Marca> marcas = new List<Marca>();
            AccesoDatos db = new AccesoDatos();

            try
            {
                db.setearConsulta("SELECT Id, Descripcion FROM MARCAS;");
                db.ejecutarLectura();

                while (db.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.IdMarca = (int)db.Lector["Id"];
                    marca.Descripcion = (string)db.Lector["Descripcion"];
                    
                    marcas.Add(marca);
                }

                return marcas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                db.cerrarConexion();
            }
        }
    }
}
