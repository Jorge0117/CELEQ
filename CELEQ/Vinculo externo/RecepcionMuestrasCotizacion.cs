using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELEQ.Vinculo_externo
{
    public partial class RecepcionMuestrasCotizacion : Form
    {
        AccesoBaseDatos bd;
        public RecepcionMuestrasCotizacion()
        {
            InitializeComponent();

            bd = new AccesoBaseDatos();

            numAnnoCotizacion.Controls.RemoveAt(0);

            //Solo permite seleccionar filas en el dgv
            dgvMuestras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMuestras.MultiSelect = false;
            dgvMuestras.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);

            dgvServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicios.MultiSelect = false;
            dgvServicios.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void RecepcionMuestrasCotizacion_Load(object sender, EventArgs e)
        {
            try
            {
                comboConsecutivo.DisplayMember = "Text";
                comboConsecutivo.ValueMember = "Value";

                comboReceptor.DisplayMember = "Text";
                comboReceptor.ValueMember = "Value";

                dgvServicios.Columns.Add("analisis", "Analisis");
                dgvServicios.Columns.Add("metodo", "Método");
                dgvServicios.Columns[0].Width = Convert.ToInt32(dgvServicios.Width * 0.7) - 1;
                dgvServicios.Columns[1].Width = Convert.ToInt32(dgvServicios.Width * 0.3) - 1;

                dgvMuestras.Columns.Add("muestra", "Muestra");
                dgvMuestras.Columns.Add("lote", "Lote");
                dgvMuestras.Columns.Add("cantidad", "Cantidad");
                dgvMuestras.Columns.Add("sellada", "Sellada");
                dgvMuestras.Columns.Add("empaque", "Empaque");

                dgvMuestras.Columns[0].Width = Convert.ToInt32(dgvMuestras.Width * 0.37) - 1;
                dgvMuestras.Columns[1].Width = Convert.ToInt32(dgvMuestras.Width * 0.15) - 1;
                dgvMuestras.Columns[2].Width = Convert.ToInt32(dgvMuestras.Width * 0.15) - 1;
                dgvMuestras.Columns[3].Width = Convert.ToInt32(dgvMuestras.Width * 0.15) - 1;
                dgvMuestras.Columns[4].Width = Convert.ToInt32(dgvMuestras.Width * 0.15) - 1;

                comboLaboratorio.Items.Add("Hidrocarburos");
                comboLaboratorio.Items.Add("UMAQ");
                comboLaboratorio.Items.Add("Soplado de vidrio");

                comboMuestreador.Items.Add("CELEQ");
                comboMuestreador.Items.Add("Cliente");
                comboMuestreador.Items.Add("NA");

                SqlDataReader receptores = bd.ejecutarConsulta("select CONCAT(nombre, ' ', apellido1, ' ', apellido2), u.nombreUsuario from usuarios u join " +
                    "puestosUsuarios p on u.nombreUsuario = p.nombreUsuario where p.puesto = 'Secretaria Vinculo Externo'");
                while (receptores.Read())
                {
                    comboReceptor.Items.Add(new { Text = receptores[0], Value = receptores[1] });
                }

                textNumLicitacion.Enabled = false;
                textLinea.Enabled = false;
                comboInstitucion.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al cargar la cotizacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void cargarCotizaciones()
        {
            comboConsecutivo.Items.Clear();
            SqlDataReader consecutivos = bd.ejecutarConsulta("select concat('VE-', FORMAT(id, 'D4'), '-', anno), id from Cotizacion where anno =" + numAnnoCotizacion.Value);
            while (consecutivos.Read())
            {
                comboConsecutivo.Items.Add(new { Text = consecutivos[0], Value = consecutivos[1] });
            }
        }

        private void numAnnoCotizacion_ValueChanged(object sender, EventArgs e)
        {
            comboConsecutivo.SelectedIndex = -1;
            textFecha.Text = "";
            textMonto.Text = "";
            textTiempoEntrega.Text = "";

            textCliente.Text = "";
            textAtencion.Text = "";
            textTelefono1.Text = "";
            textTelefono2.Text = "";
            textDireccion.Text = "";
            textCorreo.Text = "";
            textFax.Text = "";

            dgvServicios.Rows.Clear();

            cargarCotizaciones();
        }

        private void comboConsecutivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboConsecutivo.SelectedIndex != -1)
            {
                try
                {
                    dgvServicios.Rows.Clear();

                    SqlDataReader datosCotizacion = bd.ejecutarConsulta("select fechaCotizacion, granTotal, diasEntregaRes from Cotizacion where id = " + (comboConsecutivo.SelectedItem as dynamic).Value + " and anno = " + numAnnoCotizacion.Value);
                    datosCotizacion.Read();
                    textFecha.Text = Convert.ToDateTime(datosCotizacion[0].ToString()).ToString("dd/MM/yyyy");
                    textMonto.Text = "$" + Convert.ToDecimal(datosCotizacion[1].ToString()).ToString("#.##");
                    textTiempoEntrega.Text = datosCotizacion[2].ToString();

                    SqlDataReader datosCliente = bd.ejecutarConsulta("select c.cliente, ec.atencionDe, cc.telefono, cc.telefono2, cc.direccion, cc.correo, cc.fax from " +
                        "cotizacion c join clienteCotizacion cc on c.cliente = cc.nombre join contactoCotizacion ec on cc.nombre = ec.nombreCliente where ec.ultimoAgregado " +
                        "= 1 and c.id = " + (comboConsecutivo.SelectedItem as dynamic).Value + " and c.anno = " + numAnnoCotizacion.Value);
                    datosCliente.Read();
                    textCliente.Text = datosCliente[0].ToString();
                    textAtencion.Text = datosCliente[1].ToString();
                    textTelefono1.Text = datosCliente[2].ToString();
                    textTelefono2.Text = datosCliente[3].ToString();
                    textDireccion.Text = datosCliente[4].ToString();
                    textCorreo.Text = datosCliente[5].ToString();
                    textFax.Text = datosCliente[6].ToString();

                    SqlDataReader datosAnalisis;
                    SqlDataReader cotizacionAnalisis = bd.ejecutarConsulta("select descripcion, tipoAnalisis from CotizacionAnalisis where idCotizacion = " + (comboConsecutivo.SelectedItem as dynamic).Value + " and annoCotizacion = " + numAnnoCotizacion.Value);
                    var index = 0;
                    while (cotizacionAnalisis.Read())
                    {
                        datosAnalisis = bd.ejecutarConsulta("select metodo from Analisis where descripcion = '" + cotizacionAnalisis[0] + "' and tipoAnalisis = '" + cotizacionAnalisis[1] + "'");
                        datosAnalisis.Read();
                        index = dgvServicios.Rows.Add();
                        dgvServicios.Rows[index].Cells[0].Value = cotizacionAnalisis[0];
                        dgvServicios.Rows[index].Cells[1].Value = datosAnalisis[0];
                    }
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error cargando los datos de la cotización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkLicitacion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLicitacion.Checked)
            {
                textNumLicitacion.Enabled = true;
                textLinea.Enabled = true;
                comboInstitucion.Enabled = true;
            }
            else
            {
                textNumLicitacion.Text = "";
                textLinea.Text = "";
                comboInstitucion.SelectedIndex = -1;

                textNumLicitacion.Enabled = false;
                textLinea.Enabled = false;
                comboInstitucion.Enabled = false;
            }
        }

        private void dgvMuestras_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }


}
