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
    public partial class Permisos : Form
    {
        AccesoBaseDatos bd;
        public Permisos()
        {
            bd = new AccesoBaseDatos();
            InitializeComponent();
            dgvPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPermisos.MultiSelect = false;
            dgvPermisos.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        public void llenarTabla(string filtro = "")
        {
            DataTable tabla = null;

            if (filtro == "")
            {
                try
                {
                    tabla = bd.ejecutarConsultaTabla("select id , descripcion as 'Permiso' from Permisos");
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
                    tabla = bd.ejecutarConsultaTabla("select id, descripcion as 'Permiso' from Permisos where descripcion like '%" +
                        filtro + "%'");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvPermisos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvPermisos.DataSource = bs;
            dgvPermisos.Columns[0].Visible = false;
            dgvPermisos.Columns[1].Width = dgvPermisos.Width - 4;

            if (dgvPermisos.Rows.Count > 0)
            {
                butModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                butModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }

        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            AgregarPermiso ap = new AgregarPermiso();
            ap.ShowDialog();
            ap.Dispose();
            llenarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere borrar el permiso?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvPermisos.SelectedRows[0].Cells[0].Value);
                if (bd.eliminarPermiso(id) == 0)
                {
                    MessageBox.Show("Permiso eliminado de manera correcta", "Responsable", MessageBoxButtons.OK, MessageBoxIcon.None);
                    llenarTabla();
                }
                else
                {
                    MessageBox.Show("Error al eliminar permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            llenarTabla();
        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            llenarTabla(textBuscar.Text);
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            AgregarPermiso ap = new AgregarPermiso(dgvPermisos.SelectedRows[0]);
            ap.ShowDialog();
            ap.Dispose();
            llenarTabla();
        }
    }
}
