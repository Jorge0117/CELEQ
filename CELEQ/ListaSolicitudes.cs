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
        /* 
        * Tipo 0 = pendientes
        * Tipo 1 = historial
        * Tipo 2 = de un usuario
        */
        int tipo;
        public ListaSolicitudes(int tipo)
        {
            InitializeComponent();

            bd = new AccesoBaseDatos();
            this.tipo = tipo;
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
            if(tipo == 0)
            {
                try
                {
                    tabla = bd.ejecutarConsultaTabla("select Id, FechaSolicitud, NombreSolicitante, NombreEncargado, CorreoSolicitante, Unidad from Solicitud where Estado = 'Solicitado'");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(tipo == 1)
            {
                try
                {
                    tabla = bd.ejecutarConsultaTabla("select Id, FechaSolicitud, NombreSolicitante, NombreEncargado, CorreoSolicitante, Unidad, Estado from Solicitud");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    tabla = bd.ejecutarConsultaTabla("select Id, FechaSolicitud, NombreSolicitante, NombreEncargado, CorreoSolicitante, Unidad, Estado from Solicitud where usuarioSolicitante = '" + Globals.usuario + "'");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void butDetalles_Click(object sender, EventArgs e)
        {
            if(dgvSolicitudes.Rows.Count > 0)
            {
                DetallesSolicitud detallesSolicitud;
                if (tipo == 0)
                {
                    detallesSolicitud = new DetallesSolicitud(dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString(), false, dgvSolicitudes.SelectedRows[0].Cells[4].Value.ToString());
                }
                else
                {
                    detallesSolicitud = new DetallesSolicitud(dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString(), true);
                }

                detallesSolicitud.ShowDialog();
                detallesSolicitud.Dispose();
                llenarTabla();
            }
        }
    }
}
