using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> ListarPorIdArticulo(int IdArticulo)
        {
            List<Imagen> imagenes = new List<Imagen>();
            AccesoDatos bd = new AccesoDatos();

            try
            {
                bd.setearConsulta("select Id,ImagenUrl from IMAGENES WHERE IdArticulo = @IdArticulo;");
                bd.setearParametro("@IdArticulo", IdArticulo);
                bd.ejecutarLectura();

                while (bd.Lector.Read())
                {
                    Imagen imagen = new Imagen()
                    {
                        IdImagen = (int)bd.Lector["Id"],
                        Url = (string)bd.Lector["ImagenUrl"]
                    };

                    imagenes.Add(imagen);
                }
                return imagenes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                bd.cerrarConexion();
            }
        }
    }
}
