using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Inventario_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexionBD conexion = new conexionBD();

            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "ID_Categoría";
            cmbCategoria.DataSource = conexion.DS.Tables["Categorías"];
        }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexionBD conexion = new conexionBD();

            int Código = int.Parse(txtCodigo.Text);
            string Nombre = txtNombre.Text;
            string Descripción = txtDescripción.Text;
            float precio = float.Parse(txtPrecio.Text);
            int stock = int.Parse(txtStock.Text);
            int id = cmbCategoria.SelectedIndex;

            conexion.Agregar(Código, Nombre, Descripción, precio, stock, id);

            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtDescripción.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string textoBusqueda = txtBusqueda.Text.Trim();

                if (string.IsNullOrEmpty(textoBusqueda))
                {
                    MessageBox.Show("Ingrese un término de búsqueda");
                    return;
                }

                DataTable resultados = new conexionBD().BuscarProductos(textoBusqueda);
                dgvBD.DataSource = resultados;

                if (resultados.Rows.Count == 0)
                    MessageBox.Show("No se encontraron coincidencias");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexionBD conexion = new conexionBD();
            int Código = int.Parse(txtCodigo.Text);

            conexion.Eliminar(Código);

            txtCodigo.Text = ""; 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_Producto frmM = new Modificar_Producto();
            frmM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable productosBajos = new conexionBD().ObtenerProductosStockBajo();

            if (productosBajos.Rows.Count > 0)
            {
                string mensaje = "Productos con stock bajo:\n\n";
                foreach (DataRow row in productosBajos.Rows)
                {
                    mensaje += $"- {row["Nombre"]} (Stock: {row["Stock"]})\n";
                }

                MessageBox.Show(mensaje, "ALERTA DE STOCK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("No hay productos con stock bajo", "Stock OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
