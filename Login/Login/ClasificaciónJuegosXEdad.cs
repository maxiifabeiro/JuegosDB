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

namespace Login
{
    public partial class ClasificaciónJuegosXEdad : Form
    {
        public ClasificaciónJuegosXEdad()
        {
            InitializeComponent();
        }

        private void DGV_JuegosXEdad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClasificaciónJuegosXEdad_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=Localhost\SQLEXPRESS;Initial Catalog=JuegosDB;Integrated Security=True";
            string consulta = "SELECT * FROM VW_JuegosConClasificacion";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    DGV_JuegosXEdad.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
    }
}
