using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion
{
    public partial class Voucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            VoucherNegocio negocio = new VoucherNegocio();
            bool esValido = negocio.ValidarCodigo(codigo);

            if (esValido)
            {
                
                Session["codigoVoucher"] = codigo;
                Response.Redirect("Premios.aspx");
            }
            else
            {
                lblMensaje.Text = "El código es inválido o ya fue canjeado.";
            }
        }
    }
}