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

            cargarCotizaciones();
        }

        private void comboConsecutivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboConsecutivo.SelectedIndex != -1)
            {
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
            }
        }
    }


}
