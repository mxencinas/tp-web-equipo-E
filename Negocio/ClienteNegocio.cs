using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {
        public Cliente ObtenerClientePorDocumento(string documento)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Nombre, Apellido, Email, Direccion, Ciudad, Cp FROM Clientes WHERE Documento = @documento");
                datos.setearParametro("@documento", documento);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        Nombre = (string)datos.Lector["Nombre"],
                        Apellido = (string)datos.Lector["Apellido"],
                        Email = (string)datos.Lector["Email"],
                        Direccion = (string)datos.Lector["Direccion"],
                        Ciudad = (string)datos.Lector["Ciudad"],
                        Cp = (int)datos.Lector["Cp"]
                    };

                    return cliente;
                }

                return null;
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

    }
}
