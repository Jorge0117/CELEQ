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
    public partial class Presupuesto : Form
    {
        AccesoBaseDatos bd;
        public Presupuesto()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            //Solo permite seleccionar filas en el dgv
            dgvPresupuesto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPresupuesto.MultiSelect = false;
            dgvPresupuesto.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void llenarTabla(string filtro = "")
        {
            DataTable tabla = null;

            if (filtro == "")
            {
                try
                {
                    tabla = bd.ejecutarConsultaTabla("select codigo as 'Codigo', nombre as 'Nombre' from presupuesto");
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
                    tabla = bd.ejecutarConsultaTabla("select codigo as 'Codigo', nombre as 'Nombre'  from presupuesto where codigo like '%" +
                        filtro + "%' or nombre like '%" + filtro + "%'");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvPresupuesto.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvPresupuesto.DataSource = bs;
            int tamano = dgvPresupuesto.Width / 7;
            dgvPresupuesto.Columns[0].Width = tamano;
            dgvPresupuesto.Columns[1].Width = dgvPresupuesto.Width - tamano;
        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            llenarTabla(textBuscar.Text);
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            AgregarPresupuesto ag = new AgregarPresupuesto();
            ag.ShowDialog();
            ag.Dispose();
            llenarTabla();
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            AgregarPresupuesto ag = new AgregarPresupuesto(dgvPresupuesto.SelectedRows[0]);
            ag.ShowDialog();
            ag.Dispose();
            llenarTabla();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            string codigo = dgvPresupuesto.SelectedRows[0].Cells[0].Value.ToString();
            int error = bd.eliminarPresupuesto(codigo);
            if (dgvPresupuesto.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro que quiere borrar el presupuesto?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvPresupuesto.Rows.Remove(dgvPresupuesto.SelectedRows[0]);
                }
            }
            if (error == 1)
            {
                MessageBox.Show("Presupuesto eliminado de manera correcta", "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.None); 
            }
            else
            {
                MessageBox.Show("Error al eliminar presupuesto\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Presupuesto_Load(object sender, EventArgs e)
        {
            llenarTabla();
            dgvPresupuesto.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPresupuesto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

    }
}
