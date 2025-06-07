using System;
using System.Collections;
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
    public partial class FrmArticulo : Form
    {
        private List<Articulo> listaArticulo;
        public FrmArticulo()
        {
            InitializeComponent();
            dgvArticulo.SelectionChanged += dgvArticulo_SelectionChanged;
        }

        private void msAdmiistrarCategorias_Click(object sender, EventArgs e)
        {
            FrmCategoria ventanaCategoria = new FrmCategoria();
            ventanaCategoria.ShowDialog();
        }

        private void administrarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca ventanaMarca = new FrmMarca();
            ventanaMarca.ShowDialog();
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            FrmDatosArticulo ventanaAgregarArticulo = new FrmDatosArticulo();
            ventanaAgregarArticulo.ShowDialog();
            Cargar();
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {

            if (dgvArticulo.CurrentRow == null )
            {
                MessageBox.Show("Seleccione un artículo.", "Atención");
                return;
            }

            Articulo articuloSeleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;

 
            FrmDatosArticulo ventanaModificarArticulo = new FrmDatosArticulo(articuloSeleccionado, true);
            ventanaModificarArticulo.ShowDialog();
            Cargar();
            

        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            txtBuscar.Enabled = !rbTodos.Checked;
            listaArticulo = articuloNegocio.listar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listas;

            if (rbTodos.Checked)
            {
                listas = negocio.listar();

            }
            else if (rbnombre.Checked)
            {
                listas = negocio.buscarPorNombre(txtBuscar.Text);
            }
            else if (rbCodigo.Checked)
            {
                listas = negocio.buscarPorCodigo(txtBuscar.Text);
            }
            else
            {
                MessageBox.Show("Seleccione algun criterio para buscar.");
                return;
            }

            dgvArticulo.DataSource = listas;
            dgvArticulo.RowHeadersVisible = false;
            dgvArticulo.Columns["IdArticulos"].Visible = false;   //saco estas columnas del dgv
            dgvArticulo.Columns["Descripcion"].Visible = false;
            dgvArticulo.Columns["ImagenUrl"].Visible = false;
            dgvArticulo.Columns["MarcaDescripcion"].HeaderText = "Marca"; //renombro las columnas para el dgv
            dgvArticulo.Columns["CategoriaDescripcion"].HeaderText = "Categoría";
            dgvArticulo.Columns["Marca"].Visible = false;
            dgvArticulo.Columns["Categoria"].Visible = false;
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            // txtBuscar.Enabled = !rbTodos.Checked;

            if (rbTodos.Checked)
            {
                txtBuscar.Enabled = false;
                txtBuscar.Text = "";
            }
            else if (rbnombre.Checked)
            {
                txtBuscar.Enabled = true;
                dgvArticulo.DataSource = null;
            }
            else if (rbCodigo.Checked)
            {
                txtBuscar.Enabled = true;
                dgvArticulo.DataSource = null;
            }
        }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Deseas eliminar el artículo seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                    imagenNegocio.EliminarImagenesDeArticulo(seleccionado.IdArticulos);
                    negocio.eliminar(seleccionado.IdArticulos);
                    dgvArticulo.DataSource = dgvArticulo;
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            Cargar();
        }

        private void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listas = negocio.listar();

            dgvArticulo.DataSource = listas;
            dgvArticulo.RowHeadersVisible = false;
            dgvArticulo.Columns["IdArticulos"].Visible = false;   //saco estas columnas del dgv
            dgvArticulo.Columns["Descripcion"].Visible = false;
            dgvArticulo.Columns["MarcaDescripcion"].HeaderText = "Marca"; //renombro las columnas para el dgv
            dgvArticulo.Columns["CategoriaDescripcion"].HeaderText = "Categoría";
            dgvArticulo.Columns["Marca"].Visible = false;
            dgvArticulo.Columns["Categoria"].Visible = false;
            dgvArticulo.Columns["ImagenUrl"].Visible = false;
        }

        private void btnDetalleArt_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (dgvArticulo.CurrentRow != null)
            {
                string codigo = dgvArticulo.CurrentRow.Cells["Codigo"].Value.ToString();
                string descripcion = negocio.obtenerDescripcion(codigo);

                if (string.IsNullOrEmpty(descripcion)) 
                { 
                    descripcion = "Articulo sin descripcion"; 
                }

                MessageBox.Show(descripcion, "Descripción del artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccioná un artículo primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow == null)
            {
                pxbArticulo.Image = null;
                return;
            }
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;

            try
            {

                pxbArticulo.Load(seleccionado.Imagenes[0].Url);

            }
            catch (Exception ex)
            {

                pxbArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
            finally
            {

            }

        }
    }
}