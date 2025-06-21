using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Login.Inicio;

namespace Login
{
    public partial class VisorUsuario : Form
    {
        public VisorUsuario()
        {
            InitializeComponent();
            lblBienvenido.Text = "Bienvenido " + Sesion.NombreUsuario + "!";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnListadoJuegos_Click(object sender, EventArgs e)
        {
            ListadoJuegos formulario = new ListadoJuegos();
            formulario.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio formulario = new Inicio();
            formulario.Show();
            this.Close();
        }

        private void btnAvisoStock_Click(object sender, EventArgs e)
        {
            AvisoStock formulario = new AvisoStock();
            formulario.Show();
            this.Close();
        }
    }
}
