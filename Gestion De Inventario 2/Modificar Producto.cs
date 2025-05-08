using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Inventario_2
{
    public partial class Modificar_Producto : Form
    {
        public Modificar_Producto()
        {
            InitializeComponent();
        }

        private void Modificar_Producto_Load(object sender, EventArgs e)
        {
            cmbCategoriaM.Items.Add("Electrónicos");
            cmbCategoriaM.Items.Add("Hogar");
            cmbCategoriaM.Items.Add("Oficina");
            cmbCategoriaM.Items.Add("Alimentos");

            txtNombreM.Enabled = false;
            cmbCategoriaM.Enabled = false;
            txtPrecioM.Enabled = false;
            txtStockM.Enabled = false;
            txtDescripcionM.Enabled = false;

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            txtNombreM.Enabled = true;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            cmbCategoriaM.Enabled = true;
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            txtPrecioM.Enabled = true;
        }

        private void btnStrock_Click(object sender, EventArgs e)
        {
            txtStockM.Enabled= true;
        }

        private void btnDescripción_Click(object sender, EventArgs e)
        {
            txtDescripcionM.Enabled= true;
        }

        private void btnMostrarFormulario_Click(object sender, EventArgs e)
        {
            try
            {
                conexionBD conexion = new conexionBD();

                // Validaciones y conversiones seguras
                if (!int.TryParse(txtCodigoM.Text, out int CodigoM))
                {
                    MessageBox.Show("Código debe ser un número válido");
                    return;
                }

                if (!int.TryParse(txtStockM.Text, out int StockM))
                {
                    MessageBox.Show("Stock debe ser un número válido");
                    return;
                }

                if (!int.TryParse(txtPrecioM.Text, out int PrecioM))
                {
                    MessageBox.Show("Precio debe ser un número válido");
                    return;
                }

                string NombreM = txtNombreM.Text;
                int CategoriaM = cmbCategoriaM.SelectedIndex;
                string DescripcionM = txtDescripcionM.Text;

                conexion.Modificar(CodigoM, NombreM, CategoriaM, PrecioM, StockM, DescripcionM);

                MessageBox.Show("Producto modificado correctamente");

                // Limpiar y deshabilitar campos
                txtCodigoM.Text = "";
                txtNombreM.Text = "";
                txtPrecioM.Text = "";
                txtStockM.Text = "";
                txtDescripcionM.Text = "";
                cmbCategoriaM.SelectedIndex = -1;

                txtNombreM.Enabled = false;
                cmbCategoriaM.Enabled = false;
                txtPrecioM.Enabled = false;
                txtStockM.Enabled = false;
                txtDescripcionM.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }

        }

    }
}
