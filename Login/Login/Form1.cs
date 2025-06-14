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

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-806U76I\SQLEXPRESS;Initial Catalog=TiendaJuegos;Integrated Security=True");


        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string password = txtcontrasena.Text;

            string connectionString = @"Data Source=DESKTOP-806U76I\SQLEXPRESS;Initial Catalog=TiendaJuegos;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @usuario AND Contrasena = @contrasena";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", password);


                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        Form2 formulario = new Form2();
                        formulario.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
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
