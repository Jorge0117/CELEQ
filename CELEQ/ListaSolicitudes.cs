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
    public partial class ListaSolicitudes : Form
    {
        AccesoBaseDatos bd;
        public ListaSolicitudes()
        {
            InitializeComponent();

            bd = new AccesoBaseDatos();

            //Solo permite seleccionar filas en el dgv
            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitudes.MultiSelect = false;
            dgvSolicitudes.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void llenarTabla()
        {
            DataTable tabla = null;
            try
            {
                tabla = bd.ejecutarConsultaTabla("select Id, FechaSolicitud, NombreSolicitante, NombreEncargado, CorreoSolicitante, Unidad from Solicitud");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvSolicitudes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvSolicitudes.DataSource = bs;
            for (int i = 0; i < dgvSolicitudes.ColumnCount; ++i)
            {
                dgvSolicitudes.Columns[i].Width = dgvSolicitudes.Width / dgvSolicitudes.ColumnCount - 1;
            }
        }

        private void ListaSolicitudes_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }
    }
}
