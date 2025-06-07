using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> categorias = new List<Categoria>();
            AccesoDatos db = new AccesoDatos();

            try
            {
                db.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS;");
                db.ejecutarLectura();

                while (db.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.IdCategoria = (int)db.Lector["Id"];
                    categoria.Descripcion = (string)db.Lector["Descripcion"];

                    categorias.Add(categoria);
                }

                return categorias;
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
