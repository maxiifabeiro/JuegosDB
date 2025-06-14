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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ComprobarContrasena_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text == txtComprobarContrasena.Text)
            {
                txtFechaNacimiento.Focus();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }


        private void Contrasena_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
          
                string usuario = txtNombreUsuario.Text;
                string correo = txtCorreoElectronico.Text;
                string contrasena = txtContrasena.Text;
                string fechanacimiento = txtFechaNacimiento.Text;
                string pais = txtPais.Text;
                string genero = txtGenero.Text;
                string avatarurl = txtAvatar.Text;
             

                string connectionString = @"Data Source=DESKTOP-806U76I\SQLEXPRESS;Initial Catalog=TiendaJuegos;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Usuarios (NombreUsuario, CorreoElectronico, Contrasena, FechaNacimiento, Pais, Genero, AvatarURL) VALUES (@NombreUsuario, @CorreoElectronico, @Contrasena, @FechaNacimiento, @Pais, @Genero, @Avatar)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", correo);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", fechanacimiento);
                        cmd.Parameters.AddWithValue("@Pais", pais);
                        cmd.Parameters.AddWithValue("@Genero", genero);
                        cmd.Parameters.AddWithValue("@Avatar", avatarurl);
    

                    try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario creado correctamente");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al crear usuario: " + ex.Message);
                        }
                    }
                }
            }


        }

    }
