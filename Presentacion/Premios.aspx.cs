using Dominio;
using Microsoft.AspNet.FriendlyUrls;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Premios : System.Web.UI.Page
    {
        List<Articulo> premios = new List<Articulo>();
        ArticuloNegocio articuloNegocio;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["codigoVoucher"] is null)
            {
                Response.Redirect("Voucher.aspx");
                return;
            }

            if (!IsPostBack)
            {
                articuloNegocio = new ArticuloNegocio();
                try
                {
                    premios = articuloNegocio.Listar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                rptArticulos.DataSource = premios;
                rptArticulos.DataBind();
            }
        }

        protected void btnElegir_Click(object sender, EventArgs e)
        {
            int idArticulo = int.Parse(((Button)sender).CommandArgument);
            
            Session["idArticulo"] = idArticulo;

            Response.Redirect("Registro.aspx");
        }
    }
}