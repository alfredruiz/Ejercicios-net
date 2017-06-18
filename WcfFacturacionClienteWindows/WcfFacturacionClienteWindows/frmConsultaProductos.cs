using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfFacturacionClienteWindows.WcfFacturacion;

namespace WcfFacturacionClienteWindows
{
    public partial class frmConsultaProductos : Form
    {
        public frmConsultaProductos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIDProducto.Text == "") {
                MessageBox.Show("Debe ingresar un ID de producto");
                txtIDProducto.Focus();
                return;
            }
            ServicioFacturacionClient sfc = new ServicioFacturacionClient();
            Producto producto = sfc.GetProducto(txtIDProducto.Text);

            if (producto == null)
            {
                MessageBox.Show("El producto no existe");
                txtDescripcion.Text = "";
                txtPrecio.Text = "";
                txtStock.Text = "";
                txtNotas.Text = "";
                txtIDProducto.Focus();
                return;
            }

            txtDescripcion.Text = producto.Descripcion;
            txtPrecio.Text = producto.Precio.ToString();
            txtStock.Text = producto.Stock.ToString();
            txtNotas.Text = producto.Notas;

            txtIDProducto.Focus();
        }
    }
}
