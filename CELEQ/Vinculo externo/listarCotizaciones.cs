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
            dgvCotizaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCotizaciones.MultiSelect = false;
            dgvCotizaciones.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
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
                    tabla = bd.ejecutarConsultaTabla("select Co.id, FORMAT(Co.id, 'D4'), Co.anno, CONCAT('CELEQ-VE-',FORMAT(Co.id, 'D4'),'-',Co.anno) as 'Consecutivo', C.nombre as Cliente," +
                        " Co.fechaCotizacion as 'Fecha de emisión' from Cotizacion Co" +
                        " join ClienteCotizacion C on Co.cliente = C.nombre order by anno, id");
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
                    tabla = bd.ejecutarConsultaTabla("select Co.id, FORMAT(Co.id, 'D4'), Co.anno, CONCAT('CELEQ-VE-',FORMAT(Co.id, 'D4'),'-',Co.anno) as 'Consecutivo', C.nombre as Cliente, " +
                        "Co.fechaCotizacion as 'Fecha de emisión' from Cotizacion Co" +
                        " join ClienteCotizacion C on Co.cliente = C.nombre where " +
                        "CONCAT('CELEQ-VE-',FORMAT(Co.id, 'D4'),'-',Co.anno) like '%" + filtro + "%' or C.nombre like '%" + filtro + "%' or Co.fechaCotizacion like '%" +
                        filtro + "%' order by anno, id ");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvCotizaciones.DataSource = bs;
            dgvCotizaciones.Columns[0].Visible = false;
            dgvCotizaciones.Columns[1].Visible = false;
            dgvCotizaciones.Columns[2].Visible = false;
            dgvCotizaciones.Columns[3].Width = (dgvCotizaciones.Width / 3) + 30;
            dgvCotizaciones.Columns[4].Width = (dgvCotizaciones.Width / 3) ;
            dgvCotizaciones.Columns[5].Width = (dgvCotizaciones.Width / 3) - 50;

            if (dgvCotizaciones.Rows.Count > 0){
                butModificar.Enabled = true;
                butVer.Enabled = true;
            }
            else{
                butModificar.Enabled = false;
                butVer.Enabled = false;
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
            Cotizacion c = new Cotizacion(2, Convert.ToInt32(dgvCotizaciones.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dgvCotizaciones.SelectedRows[0].Cells[2].Value));
            c.ShowDialog();
            c.Dispose();
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            Cotizacion c = new Cotizacion(0);
            c.ShowDialog();
            c.Dispose();
            llenarTabla();
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            Cotizacion c = new Cotizacion(1, Convert.ToInt32(dgvCotizaciones.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dgvCotizaciones.SelectedRows[0].Cells[2].Value));
            c.ShowDialog();
            c.Dispose();
            llenarTabla();
        }
    }
}
