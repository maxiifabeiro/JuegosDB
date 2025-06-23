using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Login.Inicio;
using Login.Clases;
using Login.Reportes;

namespace Login
{
    public partial class VisorAdmin : Form
    {
        private DataGridView dgvJuegos;
        public VisorAdmin()
        {
            InitializeComponent();
            lblBienvenido.Text = "Bienvenido " + Sesion.NombreUsuario + "!";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DevJuegos_Click(object sender, EventArgs e)
        {
            Lista_DesarrolladorasJUEGOS ventana = new Lista_DesarrolladorasJUEGOS();
            ventana.ShowDialog();

        }

        private void btn_DevConsolas_Click(object sender, EventArgs e)
        {
            ListaDesarrolladorasCONSOLAS ventana = new ListaDesarrolladorasCONSOLAS();
            ventana.ShowDialog();
        }

        private void btnABMLJuegos_Click(object sender, EventArgs e)
        {
            ABMLJuegos ventana = new ABMLJuegos();
            ventana.ShowDialog();
        }

        private void btnABMLUsuarios_Click(object sender, EventArgs e)
        {
            ABMLUsuario ventana = new ABMLUsuario();
            ventana.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ListarStock ventana = new ListarStock();
            ventana.ShowDialog();
        }

        private void btnVentasMensuales_Click(object sender, EventArgs e)
        {
            VentasMensuales reporte = new VentasMensuales();
            reporte.ShowDialog();
        }

        private void btnEliminarVentaRealizada_Click(object sender, EventArgs e)
        {
            EliminarVentaRealizada ventana = new EliminarVentaRealizada();
            ventana.ShowDialog();
        }
    }

}