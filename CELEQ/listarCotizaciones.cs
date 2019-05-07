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
    public partial class listarCotizaciones : Form
    {
        AccesoBaseDatos bd;
        public listarCotizaciones()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            //Solo permite seleccionar filas en el dgv
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
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
                    tabla = bd.ejecutarConsultaTabla("select CONCAT('CELEQ-VE-',FORMAT(id, 'D4'),'-',anno) as 'Consecutivo' from Cotizacion order by anno, id");
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
                    tabla = bd.ejecutarConsultaTabla("select CONCAT('CELEQ-VE-',FORMAT(id, 'D4'),'-',anno) as 'Consecutivo' from Cotizacion where " +
                        "CONCAT('CELEQ-VE-',FORMAT(id, 'D4'),'-',anno) like '%" + filtro + "%' order by anno, id ");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvClientes.DataSource = bs;
            for (int i = 0; i < dgvClientes.ColumnCount; ++i)
            {
                dgvClientes.Columns[i].Width = dgvClientes.Width / dgvClientes.ColumnCount - 1;
            }

        }

        private void listarCotizaciones_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            llenarTabla(textBuscar.Text);
        }

        private void butVer_Click(object sender, EventArgs e)
        {

        }

        private void butAgregar_Click(object sender, EventArgs e)
        {

        }

        private void butModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
