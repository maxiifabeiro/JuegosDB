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
    public partial class AltaJuego : Form
    {
        string conexionbd = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = TiendaJuegos; Integrated Security = True"; /*Conexion Maxi*/
        public AltaJuego()
        {
            InitializeComponent();
            CargarDesarrolladores();
            CargarCategoria();
            CargarClasificacionEdad();
            CargarFormatos();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(conexionbd))
            {
                SqlCommand com = new SqlCommand("SP_altaJuego", conexion);
                com.CommandType = CommandType.StoredProcedure;

                // Asigno los parametros y le hago la conversion adecuada de cada tipo
                com.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                com.Parameters.AddWithValue("@IdDesarrolladoraJ", cmbDesarrolladora.SelectedValue);
                com.Parameters.AddWithValue("@IdCategoria", cmbCategoria.SelectedValue);
                com.Parameters.AddWithValue("@IdFormato", cmbFormato.SelectedValue);
                com.Parameters.AddWithValue("@IdClasificacionEdad", cmbClasificacion.SelectedValue);
                com.Parameters.AddWithValue("@FechaLanzamiento", dtpFechaLanzamiento.Value);

                // valido y convierto campos numericos
                int tamanio;
                int jugadores;
                decimal precio;
                int stock;

                if (!int.TryParse(txtTamanio.Text, out tamanio) ||
                    !int.TryParse(txtJugadores.Text, out jugadores) ||
                    !decimal.TryParse(txtPrecio.Text, out precio) ||
                    !int.TryParse(txtStock.Text, out stock))
                {
                    MessageBox.Show("Verificá que Tamaño, Cantidad de Jugadores, Precio y Stock sean valores numéricos válidos.");
                    return;
                }

                com.Parameters.AddWithValue("@Tamaño", tamanio);
                com.Parameters.AddWithValue("@CantidadJugadores", jugadores);
                com.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                com.Parameters.AddWithValue("@Precio", precio);
                com.Parameters.AddWithValue("@Stock", stock);
                try
                {
                    conexion.Open();
                    com.ExecuteNonQuery();
                    MessageBox.Show("Juego agregado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el juego: " + ex.Message);
                }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
