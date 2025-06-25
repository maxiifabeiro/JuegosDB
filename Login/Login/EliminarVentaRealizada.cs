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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class EliminarVentaRealizada : Form
    {
        string conexionbd = Conexion.ruta;
        public EliminarVentaRealizada()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEliminarVenta.SelectedRows.Count > 0)
            {
                int idVenta = Convert.ToInt32(dgvEliminarVenta.SelectedRows[0].Cells["IDVenta"].Value);

                using (SqlConnection conn = new SqlConnection(conexionbd))
                {
                    string query = "DELETE FROM InfoVentas WHERE IDVenta = @IDVenta";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IDVenta", idVenta);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Venta eliminada correctamente.");
                        btnMostrarTodas.PerformClick(); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexionbd))
            {
                string consulta = "SELECT IDVenta, IDJuego, Cantidad, PrecioTotal FROM InfoVentas";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, con);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                dgvEliminarVenta.DataSource = tabla;
            }
        }

        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conexionbd))
            {
                string query = @"
                    SELECT V.IDVenta, J.Nombre AS Juego, V.Cantidad, V.PrecioTotal, V.FechaVenta
                    FROM InfoVentas V
                    INNER JOIN Juegos J ON V.IDJuego = J.IDJuego";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                dgvEliminarVenta.DataSource = tabla;
            }
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
