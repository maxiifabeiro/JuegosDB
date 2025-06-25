using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ABMLJuegos : Form
    {
        public ABMLJuegos()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaJuego formulario = new AltaJuego();
            formulario.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarJuego formulario = new EliminarJuego();
            formulario.ShowDialog();
        }


        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            ModificarJuego formulario = new ModificarJuego();
            formulario.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListadoJuegos formulario = new ListadoJuegos();
            formulario.Show();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
