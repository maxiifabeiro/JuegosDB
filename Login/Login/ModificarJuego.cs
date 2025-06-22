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
    public partial class ModificarJuego : Form
    {
        string conexionbd = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = TiendaJuegos; Integrated Security = True;"; /*Conexion Maxi*/
        public ModificarJuego()
        {
            InitializeComponent();
            CargarDesarrolladores();
            CargarCategoria();
            CargarClasificacionEdad();
            CargarFormatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBox1.Text, out id))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionbd))
                {
                    SqlCommand com = new SqlCommand("SP_BuscarJuegoPorID", conexion);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@IdJuego", id);

                    conexion.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    if (reader.Read())
                    {
                        txtID.Text = id.ToString();
                        txtNombre.Text = reader["NombreJuego"].ToString();
                        cmbDesarrolladora.Text = reader["Desarrolladora"].ToString();
                        cmbCategoria.Text = reader["Categoria"].ToString();
                        cmbClasificacion.Text = reader["ClasificacionEdad"].ToString();
                        cmbFormato.Text = reader["Formato"].ToString();
                        dtpFechaLanzamiento.Value = Convert.ToDateTime(reader["FechaLanzamiento"]);
                        txtTamanio.Text = reader["Tamaño"].ToString();
                        txtJugadores.Text = reader["CantidadJugadores"].ToString();
                        txtDescripcion.Text = reader["Descripcion"].ToString();
                        txtPrecio.Text = reader["Precio"].ToString();
                        txtStock.Text = reader["Stock"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Juego no encontrado.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el juego: " + ex.Message);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Primero buscá un juego para modificar.");
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionbd))
                {
                    SqlCommand comando = new SqlCommand("SP_ModificarJuego", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@IdJuego", int.Parse(txtID.Text));
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@IDDesarrolladoraJ", cmbDesarrolladora.SelectedValue);
                    comando.Parameters.AddWithValue("@IdCategoria", cmbCategoria.SelectedValue);
                    comando.Parameters.AddWithValue("@IdFormato", cmbClasificacion.SelectedValue);
                    comando.Parameters.AddWithValue("@IdClasificacionEdad", cmbFormato.SelectedValue);
                    comando.Parameters.AddWithValue("@FechaLanzamiento", dtpFechaLanzamiento.Value);
                    comando.Parameters.AddWithValue("@Tamaño", float.Parse(txtTamanio.Text));
                    comando.Parameters.AddWithValue("@CantidadJugadores", int.Parse(txtJugadores.Text));
                    comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    comando.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecio.Text));
                    comando.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Juego modificado correctamente.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el juego: " + ex.Message);
            }
        }

        private void CargarDesarrolladores()
        {
            SqlDataAdapter daDesarrolladores = new SqlDataAdapter("SELECT IDDesarrolladoraJ, Nombre FROM DesarrolladorasJuegos", conexionbd);
            DataTable dtDesarrolladores = new DataTable();
            try
            {
                daDesarrolladores.Fill(dtDesarrolladores);
                cmbDesarrolladora.DataSource = dtDesarrolladores;
                cmbDesarrolladora.DisplayMember = "Nombre";
                cmbDesarrolladora.ValueMember = "IDDesarrolladoraJ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar desarrolladoras: " + ex.Message);
            }
        }
        private void CargarCategoria()
        {
            SqlDataAdapter daCategorias = new SqlDataAdapter("SELECT IDCategoria, Nombre FROM Categorias", conexionbd);
            DataTable dtCategorias = new DataTable();
            try
            {
                daCategorias.Fill(dtCategorias);
                cmbCategoria.DataSource = dtCategorias;
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "IDCategoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Categorías: " + ex.Message);
            }
        }


        private void CargarClasificacionEdad()
        {
            SqlDataAdapter daClasificacionEdad = new SqlDataAdapter("SELECT IDClasificacionEdad, Nombre FROM ClasificacionEdades", conexionbd);
            DataTable dtClasificacionEdad = new DataTable();
            try
            {
                daClasificacionEdad.Fill(dtClasificacionEdad);
                cmbClasificacion.DataSource = dtClasificacionEdad;
                cmbClasificacion.DisplayMember = "Nombre";
                cmbClasificacion.ValueMember = "IDClasificacionEdad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Clasificación de Edad: " + ex.Message);
            }
        }


        private void CargarFormatos()
        {
            SqlDataAdapter daFormatos = new SqlDataAdapter("SELECT IDFormato, Nombre FROM Formatos", conexionbd);
            DataTable dtFormatos = new DataTable();
            try
            {
                daFormatos.Fill(dtFormatos);
                cmbFormato.DataSource = dtFormatos;
                cmbFormato.DisplayMember = "Nombre";
                cmbFormato.ValueMember = "IDFormato";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Formatos: " + ex.Message);
            }
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

