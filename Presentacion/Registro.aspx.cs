using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            string documento = txtDni.Text.Trim();
            Cliente cliente = new Cliente();
            ClienteNegocio aux = new ClienteNegocio();
            cliente = aux.ObtenerClientePorDocumento(documento);
            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtEmail.Text = cliente.Email;
                txtDireccion.Text = cliente.Direccion;
                txtCiudad.Text = cliente.Ciudad;
                txtCp.Text = cliente.Cp.ToString();

                lblRegistro.Text = "Registrado";
            }
            else
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
                txtDireccion.Text = "";
                txtCiudad.Text = "";
                txtCp.Text = "";

                lblRegistro.Text = "No se encontró Dni registrado";

            }
        }
    }
}