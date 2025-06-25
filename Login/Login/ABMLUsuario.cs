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
            CrearUsuario formulario = new CrearUsuario();
            formulario.ShowDialog();
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            BajaUsuario formulario = new BajaUsuario();
            formulario.ShowDialog();
        }

        private void btnModificacionUsuario_Click(object sender, EventArgs e)
        {
            ModificarUsuario formulario = new ModificarUsuario();
            formulario.ShowDialog();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            ListadoUsuarios formulario = new ListadoUsuarios();
            formulario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}
