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

        private void btnListadoJuegos_Click(object sender, EventArgs e)
        {
            //Comprobacion para que no se permita abrir varias ventanas 
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ListadoJuegos))
                {
                    MessageBox.Show("Ya se ha abierto una instancia de esta ventana. Termine de trabajar allí");
                    return;
                }
            }

            ListadoJuegos formulario = new ListadoJuegos();
            formulario.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAvisoStock_Click(object sender, EventArgs e)
        {
            AvisoStock formulario = new AvisoStock();
            formulario.ShowDialog();
        }

        private void bntInfoVenta_Click(object sender, EventArgs e)
        {
            Ventas formulario = new Ventas();
            formulario.ShowDialog();
        }
    }
}
