using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMarca : Form
    {
        private Marca marca = null;
        List<Marca> marcaList;
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            MarcaNegocio negoio = new MarcaNegocio();

            try
            {
                marcaList = negoio.listar();
                dgvMarca.DataSource = marcaList;
                dgvMarca.Columns["IdMarca"].Visible = false;
                dgvMarca.RowHeadersVisible = false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAgregar.Text))
            {
                MessageBox.Show("Debes ingresar una Marca antes de continuar.");
                return;
            }
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (marca == null)
                {
                    Marca marca = new Marca();
                    marca.Descripcion = txtAgregar.Text;


                    negocio.agregar(marca);
                    MessageBox.Show("agregado exitosamente..");
                    dgvMarca.DataSource = dgvMarca;

                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAgregar.Text))
            {
                MessageBox.Show("Debes seleccionar una fila antes de continuar.");
                return;
            }
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            DialogResult respuesta = MessageBox.Show("¿Eliminar Marca?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                negocio.eliminar(seleccionado.Descripcion);
                dgvMarca.DataSource = dgvMarca;
            }
        }
    }
}
