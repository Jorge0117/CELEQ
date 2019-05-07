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

            //Solo permite seleccionar filas en el dgv
            dgvUnidad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnidad.MultiSelect = false;
            dgvUnidad.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
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
                tabla = bd.ejecutarConsultaTabla("select U.nombre as Unidad, CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Encargado from unidad U left join Usuarios E ON E.nombreUsuario = U.encargado");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvUnidad.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvUnidad.DataSource = bs;
            dgvUnidad.Columns[0].Width = dgvUnidad.Width / 3;
            dgvUnidad.Columns[1].Width = dgvUnidad.Width - dgvUnidad.Width / 3 - 3;

            if (dgvUnidad.Rows.Count > 0)
                butModificar.Enabled = true;
            else
                butModificar.Enabled = false;
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
            if (dgvUnidad.Rows.Count > 0)
            {
                AgregarUnidad ag = new AgregarUnidad(dgvUnidad.SelectedRows[0]);
                ag.ShowDialog();
                ag.Dispose();
                llenarTabla();
            }
        }
    }
}
