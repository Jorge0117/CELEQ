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
    public partial class ListaPuestos : Form
    {
        AccesoBaseDatos bd;
        bool seleccionar;
        DataGridViewRow returnRow;
        public ListaPuestos(bool seleccionar)
        {
            InitializeComponent();
            this.seleccionar = seleccionar;
            bd = new AccesoBaseDatos();

            //Solo permite seleccionar filas en el dgv
            dgvPuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPuestos.MultiSelect = false;
            dgvPuestos.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void ListaPuestos_Load(object sender, EventArgs e)
        {
            try
            {
                if (!seleccionar)
                {
                    llenarDataGridView();
                }
                else
                {
                    butAgregar.Visible = false;
                    butModificar.Visible = false;
                    this.Size = new Size(685, 550);
                    llenarDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Error cargando el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void llenarDataGridView()
        {
            DataTable tabla = null;

            try
            {
                tabla = bd.ejecutarConsultaTabla("select puesto as 'Puesto' from puestos");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvPuestos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvPuestos.DataSource = bs;
            for (int i = 0; i < dgvPuestos.ColumnCount; ++i)
            {
                dgvPuestos.Columns[i].Width = dgvPuestos.Width / dgvPuestos.ColumnCount - 1;
            }

            if (dgvPuestos.Rows.Count > 0)
            {
                butModificar.Enabled = true;
            }
            else
            {
                butModificar.Enabled = false;
            }

        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            AgregarPuesto ag = new AgregarPuesto();
            ag.ShowDialog();
            ag.Dispose();
            llenarDataGridView();
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            if(dgvPuestos.SelectedRows.Count > 0)
            {
                AgregarPuesto ag = new AgregarPuesto(dgvPuestos.SelectedRows[0].Cells[0].Value.ToString());
                ag.ShowDialog();
                ag.Dispose();
                llenarDataGridView();
            }
            
        }

        private void dgvPuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPuestos.SelectedRows.Count > 0)
            {
                returnRow = dgvPuestos.SelectedRows[0];
                this.Close();
            }
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

