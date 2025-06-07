using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WindowsFormsApp1
{
    public partial class FrmDatosArticulo : Form
    {
        Articulo articulo = null;
        bool esModificable;
        List<Imagen> imagenes = new List<Imagen>();

        public FrmDatosArticulo()
        {
            InitializeComponent();
        }

        public FrmDatosArticulo(Articulo articulo, bool esModificable)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.esModificable = esModificable;
            if (esModificable)
            {
                Text = "Modificar Articulo";
            }
            else
            {
                Text = "Detalle Articulo";
                //TODO PONER TXT EN READONLY
            }
        }

        private void btnAceptarAgregarArticulo_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return;
            }
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            bool esNuevo = this.articulo == null;

            try
            {
                if (esNuevo)
                {
                    this.articulo = new Articulo();
                }

                articulo.Nombre = txtNombreArticulo.Text;
                articulo.Codigo = txtCodigoArticulo.Text;
                articulo.Descripcion = txtDescripcionArticulo.Text;
                articulo.precio = Convert.ToDouble(txtPrecioArticulo.Text);
                articulo.Marca = (Marca)cmbMarcaArticulo.SelectedItem;
                articulo.Categoria = (Categoria)cmbCategoriaArticulo.SelectedItem;

                if(esNuevo)
                {
                    articulo.IdArticulos = articuloNegocio.AgregarArticulo(articulo);// inserto a BD y retorna el 
                }
                else
                {
                    articuloNegocio.ModificarArticulo(articulo);
                }

                if (imagenes.Any())
                {
                    foreach (Imagen imagen in imagenes)
                    {
                        imagen.IdArticulo = articulo.IdArticulos;
                    }
                }

                if(esNuevo)
                {
                    imagenNegocio.AgregarImagenes(imagenes);
                    MessageBox.Show("Articulo creado exitosamente");
                }
                else
                {
                    imagenNegocio.ModificarImagenes(imagenes, articulo.IdArticulos);
                    MessageBox.Show("Articulo Modificado exitosamente");
                }
                
                this.Close();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {
          
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            { 
                cmbCategoriaArticulo.DataSource = categoriaNegocio.listar();
                cmbCategoriaArticulo.ValueMember = "IdCategoria";
                cmbCategoriaArticulo.DisplayMember = "Descripcion";
                cmbMarcaArticulo.DataSource = marcaNegocio.listar();
                cmbMarcaArticulo.ValueMember = "IdMarca";
                cmbMarcaArticulo.DisplayMember = "Descripcion";
                

                if(articulo != null)
                {
                    txtCodigoArticulo.Text = articulo.Codigo;
                    txtNombreArticulo.Text = articulo.Nombre;
                    txtDescripcionArticulo.Text = articulo.Descripcion;
                    txtPrecioArticulo.Text = articulo.precio.ToString();
                    imagenes = articulo.Imagenes;
                    cmbCategoriaArticulo.SelectedValue = articulo.Categoria.IdCategoria;
                    cmbMarcaArticulo.SelectedValue = articulo.Marca.IdMarca;
                }
                CargarImagen(imagenes.Count == 0 ? "" : imagenes[0].Url);
                ActualizarEstadoBotones(0);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnCancelarAgregarArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarImagen(string url)
        {
            try
            {
                picImagenArticulo.Load(url);
            }
            catch (Exception ex)
            {
                picImagenArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-ytBNU72ZNhsQfEFpoW2iLtpl80L4ug8AJg&s");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            string url = txtUrlImagenArticulo.Text.Trim();

            if (string.IsNullOrEmpty(url) || EsImagenRepetida(url))
            {
                txtUrlImagenArticulo.Clear();
                return;
            }

            imagenes.Add(new Imagen() { Url = url });
            CargarImagen(url);
            txtUrlImagenArticulo.Clear();

            int indiceActual = imagenes.FindIndex(img => img.Url == url);
            ActualizarEstadoBotones(indiceActual);
        }

        private bool EsImagenRepetida(string url)
        {
            return imagenes.Any(img => img.Url == url);
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            if (!imagenes.Any()) { return; }

            Imagen imagenAQuitar = imagenes.FirstOrDefault(img => img.Url == picImagenArticulo.ImageLocation);

            int indiceActual = imagenes.FindIndex(img => img.Url == picImagenArticulo.ImageLocation);
            int nuevoIndice;

            if(imagenes.Count == 1)
            {
                CargarImagen("");
                nuevoIndice = 0;
            }
            else if (indiceActual == 0)
            {
                CambiarImagen(1);
                nuevoIndice = indiceActual;
            }
            else
            {
                CambiarImagen(-1);
                nuevoIndice = indiceActual - 1;
            }

            imagenes.Remove(imagenAQuitar);
            ActualizarEstadoBotones(indiceActual);
            
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            CambiarImagen(-1);
        }

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            CambiarImagen(1);
        }

        private void CambiarImagen(int desplazamiento)
        {
            if (imagenes.Count == 0 ) return;

            int indiceActual = imagenes.FindIndex(img => img.Url == picImagenArticulo.ImageLocation);

            int nuevoIndice = indiceActual + desplazamiento;

            if (nuevoIndice >= 0 && nuevoIndice < imagenes.Count)
            {
                txtUrlImagenArticulo.Text = imagenes[nuevoIndice].Url;
                CargarImagen(imagenes[nuevoIndice].Url);
                ActualizarEstadoBotones(nuevoIndice);
            }
        }

        private void ActualizarEstadoBotones(int indiceActual)
        {
            if (imagenes.Count <= 1 || indiceActual < 0 || indiceActual >= imagenes.Count)
            {
                btnImagenAnterior.Enabled = false;
                btnImagenSiguiente.Enabled = false;
            }
            else
            {
                btnImagenAnterior.Enabled = indiceActual > 0;
                btnImagenSiguiente.Enabled = indiceActual < imagenes.Count - 1;
            }
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoArticulo.Text))
            {
                MessageBox.Show("El código es obligatorio.");
                txtCodigoArticulo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreArticulo.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                txtNombreArticulo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioArticulo.Text))
            {
                MessageBox.Show("El precio es obligatorio.");
                txtPrecioArticulo.Focus();
                return false;
            }

            if (!double.TryParse(txtPrecioArticulo.Text, out _))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                txtPrecioArticulo.Focus();
                return false;
            }

            return true;
        }
    }
}
