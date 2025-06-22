using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Clases;

namespace Login
{
    public partial class RealizarVenta : Form
    {
        private JuegoNegocio negocio = new JuegoNegocio();
        private Juego juego = null;
        private string usuario;

        public RealizarVenta()
        {
            InitializeComponent();
        }

        public RealizarVenta(Juego aux, string usuario)
        {
            InitializeComponent();
            this.juego = aux;
            this.usuario = usuario;
            cargarDatos(aux);
            cargarFormasDePago();
            actualizarPrecioTotal();
        }

        public void cargarDatos(Juego aux)
        {
            txtJuegoSeleccionado.Text = aux.Nombre;
            txtPrecio.Text = aux.Precio.ToString("C");
            txtStock.Text = aux.Stock.ToString();
            txtUsuarioVendedor.Text = this.usuario;

            txtJuegoSeleccionado.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtUsuarioVendedor.Enabled = false;

            nudCantidad.Maximum = aux.Stock;
            nudCantidad.Minimum = 1;
            nudCantidad.Value = 1;
        }

        private void cargarFormasDePago()
        {
            try
            {
                cbPago.DataSource = negocio.listarFormas();
                cbPago.ValueMember = "IDFormaDePago";
                cbPago.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las formas de pago: " + ex.Message);
            }
        }

        private void actualizarPrecioTotal()
        {
            decimal cantidad = nudCantidad.Value;
            decimal precioUnitario = juego.Precio;
            lblPrecioTotal.Text = (cantidad * precioUnitario).ToString("C");
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            actualizarPrecioTotal();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                int idJuego = this.juego.IDJuego;
                string nombreVendedor = this.usuario;
                int idFormaPago = (int)cbPago.SelectedValue;
                int cantidad = (int)nudCantidad.Value;
                decimal precioTotal = cantidad * this.juego.Precio;

                negocio.registrarVenta(idJuego, nombreVendedor, idFormaPago, cantidad, precioTotal);

                MessageBox.Show("Venta registrada", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
