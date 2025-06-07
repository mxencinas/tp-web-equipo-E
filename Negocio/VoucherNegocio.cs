using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VoucherNegocio
    {
        public bool ValidarCodigo(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM VOUCHERS WHERE CodigoVoucher = @codigo AND IdCliente IS NULL");
                datos.setearParametro("@codigo", codigo);
                datos.ejecutarLectura();

                datos.Lector.Read();
                int count = datos.Lector.GetInt32(0);

                return count > 0; 
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

        public void MarcarComoCanjeado(string codigo, int idCliente, int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(@"UPDATE VOUCHERS 
                                       SET IdCliente = @idCliente, FechaCanje = GETDATE(), IdArticulo = @idArticulo
                                       WHERE CodigoVoucher = @codigo");

                datos.setearParametro("@idCliente", idCliente);
                datos.setearParametro("@idArticulo", idArticulo);
                datos.setearParametro("@codigo", codigo);

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
    }
}
