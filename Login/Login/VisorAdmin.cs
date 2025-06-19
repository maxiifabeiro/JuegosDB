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
            Inicio formulario = new Inicio();
            formulario.Show();
            this.Close();
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

        private void btnABMLJuegos_Click(object sender, EventArgs e)
        {
            ABMLJuegos ventana = new ABMLJuegos();
            ventana.Show();
            this.Close();
        }

    }

}