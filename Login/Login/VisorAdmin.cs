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

namespace Login
{
    public partial class VisorAdmin : Form
    {
        private DataGridView dgvJuegos;
        public VisorAdmin()
        {
            InitializeComponent();
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio formulario = new Inicio();
            formulario.Show();
            this.Close();
        }

        private void btnAltaJuego_Click(object sender, EventArgs e)
        {
            AltaJuego formulario = new AltaJuego();
            formulario.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarJuego formulario = new EliminarJuego();
            formulario.Show();
            this.Hide();
        }

        private void btn_DevJuegos_Click(object sender, EventArgs e)
        {
            Lista_DesarrolladorasJUEGOS ventana = new Lista_DesarrolladorasJUEGOS();
            ventana.Show();

        }

        private void btn_DevConsolas_Click(object sender, EventArgs e)
        {
            ListaDesarrolladorasCONSOLAS ventana = new ListaDesarrolladorasCONSOLAS();
            ventana.Show();
        }
    }

}