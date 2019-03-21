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
    public partial class ListaMaestra : Form
    {
        AccesoBaseDatos bd;
        public ListaMaestra()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();

            //Solo permite seleccionar filas en el dgv
            dgvListaM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaM.MultiSelect = false;
            dgvListaM.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
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
                if(comboOpcionMostrar.Text == "Todos")
                    tabla = bd.ejecutarConsultaTabla("select Codigo as Código, ver as Versión, Nombre, FechaEntV as 'Entrada en vigencia' from ListaMaestra");
                else
                    tabla = bd.ejecutarConsultaTabla("select Codigo as Código, ver as Versión, Nombre, FechaEntV as 'Entrada en vigencia' from ListaMaestraActual");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvListaM.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvListaM.DataSource = bs;
            int tamCelda = dgvListaM.Width / 4;
            dgvListaM.Columns[0].Width = tamCelda -50;
            dgvListaM.Columns[1].Width = tamCelda -60;
            dgvListaM.Columns[2].Width = tamCelda + 153;
            dgvListaM.Columns[3].Width = tamCelda - 40;

            if (dgvListaM.Rows.Count > 0)
            {
                butModificar.Enabled = true;
                butActualizar.Enabled = true;
            }
            else
            {
                butModificar.Enabled = false;
                butActualizar.Enabled = false;
            }
        }

        private void ListaMaestra_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {

        }

        private void butModificar_Click(object sender, EventArgs e)
        {

        }

        private void butActualizar_Click(object sender, EventArgs e)
        {

        }

    }
}
