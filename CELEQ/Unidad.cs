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

namespace CELEQ
{
    public partial class Unidad : Form
    {
        AccesoBaseDatos bd;
        public Unidad()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
        }


        private void Unidad_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }


        private void llenarTabla()
        {
            DataTable tabla = null;

            try
            {
                tabla = bd.ejecutarConsultaTabla("select nombre as Unidad from unidad");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvUnidad.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvUnidad.DataSource = bs;
            for (int i = 0; i < dgvUnidad.ColumnCount; ++i)
            {
                dgvUnidad.Columns[i].Width = dgvUnidad.Width / dgvUnidad.ColumnCount - 1;
            }
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            AgregarUnidad ag = new AgregarUnidad();
            ag.ShowDialog();
            ag.Dispose();
            llenarTabla();
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            AgregarUnidad ag = new AgregarUnidad(dgvUnidad.SelectedRows[0]);
            ag.ShowDialog();
            ag.Dispose();
            llenarTabla();
        }
    }
}
