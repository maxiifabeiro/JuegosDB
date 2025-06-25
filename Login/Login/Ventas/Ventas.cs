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
using Login.Clases;
using static Login.Inicio;

namespace Login
{
    public partial class Ventas : Form
    {
        private JuegoNegocio negocio = new JuegoNegocio();
        public string usuario = Sesion.NombreUsuario;

        public Ventas()
        {
            InitializeComponent();
            ConfigurarDGV();
            CargarClasificacionEdad();
            CargarCategoria();
            CargarJuegos("", 0, 0);
        }

        private void ConfigurarDGV()
        {
            dgvJuegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJuegos.MultiSelect = false;
            dgvJuegos.ReadOnly = true;
            dgvJuegos.RowHeadersVisible = false;
            dgvJuegos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarCategoria()
        {
            try
            {
                List<Categoria> listaCategorias = negocio.listarCategorias();
                listaCategorias.Insert(0, new Categoria { IDCategoria = 0, Nombre = "Todas" });
                cbCategorias.DataSource = listaCategorias;
                cbCategorias.DisplayMember = "Nombre";
                cbCategorias.ValueMember = "IDCategoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Categorías: " + ex.Message);
            }
        }

        private void CargarClasificacionEdad()
        {
            try
            {
                List<Clasificacion> listaClasificaciones = negocio.ListarClasificaciones();
                listaClasificaciones.Insert(0, new Clasificacion { IDClasificacionEdad = 0, Nombre = "Todas" });
                cbClasificaciones.DataSource = listaClasificaciones;
                cbClasificaciones.DisplayMember = "Nombre";
                cbClasificaciones.ValueMember = "IDClasificacionEdad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Clasificación de Edad: " + ex.Message);
            }
        }

        private void BuscarJuegos()
        {
            string terminoBusqueda = txtBuscar.Text.Trim();

            int idCategoria = 0;
            if (cbCategorias.SelectedItem != null)
            {
                Categoria categoriaSeleccionada = cbCategorias.SelectedItem as Categoria;
                if (categoriaSeleccionada != null)
                {
                    idCategoria = categoriaSeleccionada.IDCategoria;
                }
            }

            int idClasificacion = 0;
            if (cbClasificaciones.SelectedItem != null)
            {
                Clasificacion clasificacionSeleccionada = cbClasificaciones.SelectedItem as Clasificacion;
                if (clasificacionSeleccionada != null)
                {
                    idClasificacion = clasificacionSeleccionada.IDClasificacionEdad;
                }
            }

            CargarJuegos(terminoBusqueda, idCategoria, idClasificacion);
        }


        private void CargarJuegos(string terminoBusqueda, int idCategoria, int idClasificacion)
        {
            try
            {
                dgvJuegos.DataSource = negocio.listarJuegos(terminoBusqueda, idCategoria, idClasificacion);
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar juegos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvJuegos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJuegos.SelectedRows.Count > 0)
            {
                btnVender.Enabled = true;
            }
            else
            {
                btnVender.Enabled = false;
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
           if (dgvJuegos.CurrentRow != null)
            {
                Juego seleccionado = (Juego)dgvJuegos.CurrentRow.DataBoundItem;
                RealizarVenta venta = new RealizarVenta(seleccionado, this.usuario);
                venta.ShowDialog();
                BuscarJuegos();
            }
        }

        private void ocultarColumnas()
        {
            if (dgvJuegos.Columns["IDJuego"] != null)
                dgvJuegos.Columns["IDJuego"].Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarJuegos();
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarJuegos();
        }

        private void cbClasificaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarJuegos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
