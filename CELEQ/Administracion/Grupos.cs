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
    public partial class Grupos : Form
    {
        AccesoBaseDatos bd;
        public Grupos()
        {
            bd = new AccesoBaseDatos();
            InitializeComponent();
            dgvGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrupos.MultiSelect = false;
            dgvGrupos.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void Grupos_Load(object sender, EventArgs e)
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
                    tabla = bd.ejecutarConsultaTabla("select id , descripcion as 'Grupo' from Grupos");
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
                    tabla = bd.ejecutarConsultaTabla("select id, descripcion as 'Grupo' from Grupos where descripcion like '%" +
                        filtro + "%'");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvGrupos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvGrupos.DataSource = bs;
            dgvGrupos.Columns[0].Visible = false;
            dgvGrupos.Columns[1].Width = dgvGrupos.Width - 4;

            if (dgvGrupos.Rows.Count > 0)
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
            AgregarGrupo ap = new AgregarGrupo();
            ap.ShowDialog();
            ap.Dispose();
            llenarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere borrar el grupo?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells[0].Value);
                if (bd.eliminarGrupo(id) == 0)
                {
                    MessageBox.Show("Grupo eliminado de manera correcta", "Responsable", MessageBoxButtons.OK, MessageBoxIcon.None);
                    llenarTabla();
                }
                else
                {
                    MessageBox.Show("Error al eliminar grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            AgregarGrupo ap = new AgregarGrupo(dgvGrupos.SelectedRows[0]);
            ap.ShowDialog();
            ap.Dispose();
            llenarTabla();
        }
    }
}
