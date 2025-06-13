using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\v11.0;Initial Catalog=TiendaJuegosPrueba;Integrated Security=True");


        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario, password;

            usuario = txtusuario.Text;
            password = txtcontrasena.Text;

            if (usuario == txtusuario.Text && password == txtcontrasena.Text)
            {
                Form2 formulario = new Form2();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos, intente nuevamente.");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
           txtcontrasena.Text = "";
                
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LogoTiendaJuego_Click(object sender, EventArgs e)
        {
            LogoTiendaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void CrearUsuario_Click(object sender, EventArgs e)
        {
            Form3 formulario = new Form3();
            formulario.Show();
        }
    }
}
