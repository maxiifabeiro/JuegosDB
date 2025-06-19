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
    public partial class ABMLUsuario : Form
    {
        public ABMLUsuario()
        {
            InitializeComponent();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            //Comprobacion para que no se permita abrir varias ventanas 
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(CrearUsuario))
                {
                    MessageBox.Show("Ya se ha abierto una instancia de esta ventana. Termine de trabajar allí");
                    return;
                }
            }

            CrearUsuario formulario = new CrearUsuario();
            formulario.Show();
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            //Comprobacion para que no se permita abrir varias ventanas 
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(BajaUsuario))
                {
                    MessageBox.Show("Ya se ha abierto una instancia de esta ventana. Termine de trabajar allí");
                    return;
                }
            }

            BajaUsuario formulario = new BajaUsuario();
            formulario.Show();
        }

        private void btnModificacionUsuario_Click(object sender, EventArgs e)
        {
            //Comprobacion para que no se permita abrir varias ventanas 
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModificarUsuario))
                {
                    MessageBox.Show("Ya se ha abierto una instancia de esta ventana. Termine de trabajar allí");
                    return;
                }
            }

            ModificarUsuario formulario = new ModificarUsuario();
            formulario.Show();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            //Comprobacion para que no se permita abrir varias ventanas 
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ListadoUsuarios))
                {
                    MessageBox.Show("Ya se ha abierto una instancia de esta ventana. Termine de trabajar allí");
                    return;
                }
            }

            ListadoUsuarios formulario = new ListadoUsuarios();
            formulario.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }

}
