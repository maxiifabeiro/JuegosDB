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
    public partial class Lista_DesarrolladorasJUEGOS : Form
    {
        private DataGridView dgvJuegos;
        public Lista_DesarrolladorasJUEGOS()
        {
            InitializeComponent();

            dgvJuegos = new DataGridView();
            dgvJuegos.Location = new Point(10, 50);
            dgvJuegos.Size = new Size(600, 300);
            dgvJuegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJuegos.Visible = false; 
            this.Controls.Add(dgvJuegos);
        }

        private void btn_DevJuegos_Click(object sender, EventArgs e)
        {
            

        }
    

    private void Lista_DesarrolladorasJUEGOS_Load(object sender, EventArgs e)
        {
            string connectionString = Conexion.ruta;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM desarrolladorasJUEGOS";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvJuegos.DataSource = dt;
                    dgvJuegos.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }
    }
    }

