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
    public partial class Feriados : Form
    {
        AccesoBaseDatos bd;
        public Feriados()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();

            //Solo permite seleccionar filas en el dgv
            dgvFeriados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFeriados.MultiSelect = false;
            dgvFeriados.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void Feriados_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void llenarTabla()
        {
            DataTable tabla = null;

            try
            {
                tabla = bd.ejecutarConsultaTabla("select id, descripcion as Feriado, fechaInicio as Fecha from Feriados");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvFeriados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvFeriados.DataSource = bs;
            dgvFeriados.Columns["id"].Visible = false;

            dgvFeriados.Columns[1].Width = dgvFeriados.Width / 2 + 120;
            dgvFeriados.Columns[2].Width = dgvFeriados.Width  / 2 - 122;

            if (dgvFeriados.Rows.Count > 0)
            {
                butEliminar.Enabled = true;
                butModificar.Enabled = true;
            }
            else
            {
                butEliminar.Enabled = false;
                butModificar.Enabled = false;
            }
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFeriados.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro que quiere borrar el feriado?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bd.eliminarFeriado(Convert.ToInt32(dgvFeriados.SelectedRows[0].Cells[0].Value.ToString())) == 0)
                    {
                        MessageBox.Show("Feriado eliminado de manera correcta", "Feriados", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar feriado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                llenarTabla();
            }
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            AgregarFeriado f = new AgregarFeriado();
            f.ShowDialog();
            f.Dispose();
            llenarTabla();
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            AgregarFeriado f = new AgregarFeriado(dgvFeriados.SelectedRows[0]);
            f.ShowDialog();
            f.Dispose();
            llenarTabla();
        }

    }
}
