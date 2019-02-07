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
    public partial class Encargados : Form
    {
        AccesoBaseDatos bd;
        public Encargados()
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


        private void Encargados_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void llenarTabla()
        {
            DataTable tabla = null;

            try
            {
                tabla = bd.ejecutarConsultaTabla("select nombre as Nombre from responsable");
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
            string encargado = Microsoft.VisualBasic.Interaction.InputBox("Digite el nombre del responsable", "Responsable", "");
            if (encargado != "")
            {
                bd.ejecutarConsulta("insert into responsable values ('" + encargado + "')");
                MessageBox.Show("Responsable agregado correctamente", "Responsable", MessageBoxButtons.OK, MessageBoxIcon.None);
                llenarTabla();
            }
            else
            {
                MessageBox.Show("Por favor digite el nombre del responsable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            
        }

    }
}
