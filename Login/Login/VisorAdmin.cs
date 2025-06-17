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
    public partial class VisorAdmin : Form
    {
        public VisorAdmin()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio formulario = new Inicio();
            formulario.Show();
            this.Hide();
        }

        private void btnAltaJuego_Click(object sender, EventArgs e)
        {
            AltaJuego formulario = new AltaJuego();
            formulario.Show();
            this.Hide();
        }
    }
}
