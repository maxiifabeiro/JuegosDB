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
    public partial class CambiarContrasena : Form
    {
        public CambiarContrasena()
        {
            InitializeComponent();
        }

        private void CambiarContrasena_Load(object sender, EventArgs e)
        {
            //Cuando entras al formulario se deshabilitan estos campos hasta verificar el usuario
            txtNuevaContrasena.Enabled = false;
            txtVerificarContrasena.Enabled = false;
            btnCambiarContrasena.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void btnVerificarUsuario_Click(object sender, EventArgs e)
            {
            //Aca tenemos los datos que ingresa el usuario (son los que le pedimos que ingresen)
                string usuario = txtusuario_CC.Text;
                DateTime fecha = dateTimePicker1.Value.Date;

            if (string.IsNullOrEmpty(usuario)) //Debe poner un usuario si o si 
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario.");
                return;
            }


            //Conectamos a la base de datos y tiramos consulta SQL para traer los datos que necesitamos comparar
            string connectionString = @"Data Source=Localhost\SQLEXPRESS;Initial Catalog=JuegosDB;Integrated Security=True";
                string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @usuario AND FechaNacimiento = @fecha";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                //Acá agregamos los valores ingresados a los parametros del SQL, o sea reemplazamos @usuario por ejemplo por el texto real que se ingresó
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@fecha", fecha);

                    con.Open(); //abrimos conexion a la base
                    int count = (int)cmd.ExecuteScalar(); 
                //Aca devuelve la cantidad de coincidencias si "existe" habilita a que cambie la contraseña
                    if (count == 1)
                    {
                        MessageBox.Show("Usuario verificado");

                        // Si el usuario esta verificado se habilitan los campos para cambiar la contraseña sino te tira mensaje de error
                        txtNuevaContrasena.Enabled = true;
                        txtVerificarContrasena.Enabled = true;
                        btnCambiarContrasena.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o fecha incorrectos");
                    }
                }
            }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            
                string usuario = txtusuario_CC.Text;
                string nuevaContrasena = txtNuevaContrasena.Text;
                string verificar = txtVerificarContrasena.Text;

                if (nuevaContrasena != verificar)
                {
                    MessageBox.Show("Las contraseñas no coinciden"); //Si las contraseñas no coinciden se avisa al usuario
                    return;
                }
                //Si coinciden hacemos update en la base de datos
                string connectionString = @"Data Source=Localhost\SQLEXPRESS;Initial Catalog=JuegosDB;Integrated Security=True";
                string query = "UPDATE Usuarios SET Contrasena = @nueva WHERE NombreUsuario = @usuario";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nueva", nuevaContrasena);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery(); //ejecuta la actualizacion y devuelve la cantidad de las filas que cambió 

                    if (filas > 0)
                    {
                        MessageBox.Show("Contraseña actualizada correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar contraseña");
                    }
                }
            }

    }
    }
    

