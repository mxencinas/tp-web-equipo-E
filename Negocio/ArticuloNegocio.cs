using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> listas = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {
                datos.setearConsulta(@"Select a.Id, a.Codigo, a.Nombre, a.Descripcion,a.Precio, 
                    c.Id IdCategoria, c.Descripcion CategoriaDescripcion,m.Id IdMarca, m.Descripcion MarcaDescripcion 
                    from ARTICULOS a inner join CATEGORIAS c on a.IdCategoria = c.Id 
                    inner join MARCAS m on a.IdMarca = m.Id");


                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Articulo articulo = new Articulo
                    {
                        IdArticulos = (int)datos.Lector["Id"],
                        Codigo = (string)datos.Lector["Codigo"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Precio = Convert.ToDouble(datos.Lector["Precio"]),
                        Categoria = new Categoria
                        {
                            IdCategoria = (int)datos.Lector["IdCategoria"],
                            Descripcion = (string)datos.Lector["CategoriaDescripcion"]
                        },
                        Marca = new Marca
                        {
                            IdMarca = (int)datos.Lector["IdMarca"],
                            Descripcion = (string)datos.Lector["MarcaDescripcion"]
                        },
                        Imagenes = imagenNegocio.ListarPorIdArticulo((int)datos.Lector["Id"])  
                    };
                    listas.Add(articulo);
                }

                return listas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        
        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ARTICULOS where id = @Id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
           

        public int AgregarArticulo(Articulo articulo)
        {
            int id;
            AccesoDatos bd = new AccesoDatos();

            try
            {
                bd.setearConsulta(@"INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,Precio,IdCategoria,IdMarca)
                                    OUTPUT INSERTED.Id 
                                    VALUES (@Codigo, @Nombre, @Descripcion ,@Precio , @IdCategoria, @IdMarca)");
                bd.setearParametro("@Codigo", articulo.Codigo);
                bd.setearParametro("@Nombre", articulo.Nombre);
                bd.setearParametro("@Descripcion", articulo.Descripcion);
                bd.setearParametro("@Precio", articulo.Precio);
                bd.setearParametro("@IdCategoria", articulo.Categoria.IdCategoria);
                bd.setearParametro("@IdMarca", articulo.Marca.IdMarca);

                id = bd.EjecutarAccionYTraerId();

                return id;

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