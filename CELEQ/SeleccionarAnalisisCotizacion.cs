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
    public partial class SeleccionarAnalisisCotizacion : Form
    {
        string tipoAnalisis;
        AccesoBaseDatos bd;
        DataGridViewRow returnRow;
        public SeleccionarAnalisisCotizacion(string tipoAnalisis)
        {
            InitializeComponent();
            this.tipoAnalisis = tipoAnalisis;
            bd = new AccesoBaseDatos();
            returnRow = null;

            //Solo permite seleccionar filas en el dgv
            dgvAnalisis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnalisis.MultiSelect = false;
            dgvAnalisis.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);

        }
        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }


        private void SeleccionarAnalisisCotizacion_Load(object sender, EventArgs e)
        {
            if(tipoAnalisis != null)
            {
                labelSeleccion.Text = "Selección de análisis";
                labelMetodo.Visible = false;
                comboMetodo.Visible = false;
                llenarTabla();
            }
            else
            {
                butAceptar.Enabled = false;
                labelSeleccion.Text = "Selección de metales";
                comboMetodo.Items.Add("AA");
                comboMetodo.Items.Add("Rayos X cuantitativo");
                comboMetodo.Items.Add("Rayos X semicuantitativo");
            }
        }
        private void llenarTabla()
        {
            DataTable tabla = null;

            if (tipoAnalisis != "")
            {
                try
                {
                    tabla = bd.ejecutarConsultaTabla("select descripcion as 'Análisis', metodo as 'Método', concat('$', precio) as 'Precio' from Analisis where tipoAnalisis = '" + tipoAnalisis + "'");
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
                    tabla = bd.ejecutarConsultaTabla("select descripcion as 'Análisis', metodo as 'Método', concat('$', precio) as 'Precio' from Analisis where tipoAnalisis = '" + comboMetodo.Text + "'");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvAnalisis.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvAnalisis.DataSource = bs;
            for (int i = 0; i < dgvAnalisis.ColumnCount; ++i)
            {
                dgvAnalisis.Columns[i].Width = dgvAnalisis.Width / dgvAnalisis.ColumnCount - 1;
            }
            butAceptar.Enabled = true;
        }

        private void comboMetodo_TextChanged(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAnalisis_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAnalisis.SelectedRows.Count > 0)
                returnRow = dgvAnalisis.SelectedRows[0];
            this.Close();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(dgvAnalisis.SelectedRows.Count > 0)
                returnRow = dgvAnalisis.SelectedRows[0];
            this.Close();
        }

        public DataGridViewRow getRow()
        {
            DataGridViewRow row = null;
            if (returnRow != null)
            {
                row = (DataGridViewRow)returnRow.Clone();
                for (int index = 0; index < returnRow.Cells.Count; index++)
                {
                    row.Cells[index].Value = returnRow.Cells[index].Value;
                }
            }
            
            return row;
        }
    }
}
