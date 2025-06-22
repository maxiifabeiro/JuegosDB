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
    public partial class ListaDesarrolladorasCONSOLAS : Form
    {
        private DataGridView dgvConsolas;
        public ListaDesarrolladorasCONSOLAS()
        {
            InitializeComponent();

            dgvConsolas = new DataGridView();
            dgvConsolas.Location = new Point(10, 50);
            dgvConsolas.Size = new Size(600, 300);
            dgvConsolas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsolas.Visible = false;
            this.Controls.Add(dgvConsolas);
        }

        private void ListaDesarrolladorasCONSOLAS_Load(object sender, EventArgs e)
        {
            string connectionString = Conexion.ruta;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM desarrolladorasCONSOLAS";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvConsolas.DataSource = dt;
                    dgvConsolas.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }
    }
}
