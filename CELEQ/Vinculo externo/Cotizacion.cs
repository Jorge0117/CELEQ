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
using System.IO;
using System.Net.NetworkInformation;

namespace CELEQ
{
    public partial class Cotizacion : Form
    {
        float dolar;
        AccesoBaseDatos bd;
        int? idCotizacion;
        int? annoCotizacion;
        string tipoMuestra;
        bool hacerCambioSaldoAfavor;
        int tipoAccion; // 0 es agregar, 1 es modificar, 2 es ver
        public Cotizacion(int tipo, int? idCotizacion = null, int? annoCotizacion = null)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();

            tipoAccion = tipo;
            this.idCotizacion = idCotizacion;
            this.annoCotizacion = annoCotizacion;
            numDescuento.Controls.RemoveAt(0);
            numGastosAdm.Controls.RemoveAt(0);
            numSaldoFavor.Controls.RemoveAt(0);
            hacerCambioSaldoAfavor = true;

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

        private void Cotizacion_Load(object sender, EventArgs e)
        {
            try
            {
                comboCotizador.DisplayMember = "Text";
                comboCotizador.ValueMember = "Value";

                SqlDataReader cotizadores = bd.ejecutarConsulta("select concat(nombre, ' ', apellido1, ' ', apellido2), u.nombreUsuario from Usuarios u join puestosUsuarios p on u.nombreUsuario = p.nombreUsuario where p.puesto = 'Secretaria Vinculo Externo'");
                while (cotizadores.Read())
                {
                    comboCotizador.Items.Add(new { Text = cotizadores[0], Value = cotizadores[1] });
                }

                comboQuimico.DisplayMember = "Text";
                comboQuimico.ValueMember = "Value";

                SqlDataReader quimicos = bd.ejecutarConsulta("select concat(nombre, ' ', apellido1, ' ', apellido2), u.nombreUsuario from Usuarios u join puestosUsuarios p on u.nombreUsuario = p.nombreUsuario where p.puesto = 'Químico'");
                while (quimicos.Read())
                {
                    comboQuimico.Items.Add(new { Text = quimicos[0], Value = quimicos[1] });
                }

                comboFirmantes.DisplayMember = "Text";
                comboFirmantes.ValueMember = "Value";

                SqlDataReader firmantes = bd.ejecutarConsulta("select concat(nombre, ' ', apellido1, ' ', apellido2), u.nombreUsuario from Usuarios u join puestosUsuarios p on u.nombreUsuario = p.nombreUsuario where p.puesto = 'Director' or p.puesto = 'Subdirector'");
                while (firmantes.Read())
                {
                    comboFirmantes.Items.Add(new { Text = firmantes[0], Value = firmantes[1] });
                }

                comboUnidad.Items.Add("mL");
                comboUnidad.Items.Add("g");

                SqlDataReader provincias = bd.ejecutarConsulta("select distinct provincia from Localizaciones");
                while (provincias.Read())
                {
                    comboProvincia.Items.Add(provincias[0].ToString());
                }
                SqlDataReader clientes = bd.ejecutarConsulta("select nombre from clienteCotizacion");
                while (clientes.Read())
                {
                    comboCliente.Items.Add(clientes[0].ToString());
                }
                textTotalGira.Enabled = false;

                SqlDataReader tipoMuestra = bd.ejecutarConsulta("select tipo from tipoAnalisis");
                while (tipoMuestra.Read())
                {
                    comboTipoMuestra.Items.Add(tipoMuestra[0].ToString());
                }

                dgvAnalisis.Columns.Add("descripcion", "Análisis");
                dgvAnalisis.Columns.Add("metodo", "Método");
                dgvAnalisis.Columns.Add("precio", "Precio");

                for (int i = 0; i < dgvAnalisis.ColumnCount; ++i)
                {
                    dgvAnalisis.Columns[i].Width = dgvAnalisis.Width / dgvAnalisis.ColumnCount - 1;
                }



                if (tipoAccion == 0)
                {
                    textConsecutivo.Text = ("####-####");

                    textMuestra.Enabled = false;
                    numericMuestras.Enabled = false;
                    numericDias.Enabled = false;
                    numericCantidad.Enabled = false;
                    comboUnidad.Enabled = false;
                    butAnalisis.Enabled = false;
                    butMetales.Enabled = false;
                    butTexto.Enabled = false;
                    butBorrar.Enabled = false;


                    textPrecioUnitario.Text = "0";
                    textPrecioMuestreo.Text = "0";
                    textSubtotal.Text = "0";
                    textDescuento.Text = "0";
                    textGastos.Text = "0";
                    textTotal.Text = "0";

                    textTotalGira.Enabled = false;
                    numProfesionales.Enabled = false;
                    numHoras.Enabled = false;
                    numTecnicos.Enabled = false;
                    numNoches.Enabled = false;
                    comboProvincia.Enabled = false;
                    comboCanton.Enabled = false;
                    comboLocalidad.Enabled = false;
                    butCalcular.Enabled = false;

                }
                //Si se va a consultar o modificar
                else
                {
                    SqlDataReader datosCotizacion = bd.ejecutarConsulta("select licitacion, observaciones, precioMuestreo, descuento, gastosAdm, fechaCotizacion," +
                        "fechaSolicitud, fechaRespuesta, saldoAfavor, granTotal, moneda, cotizador, cliente, precioMuestra, diasEntregaRes, subTotal, numeroMuestras, " +
                        "usuarioQuimico, usuarioFirmante from Cotizacion where id = " + idCotizacion + " and anno = " + annoCotizacion);
                    datosCotizacion.Read();

                    if (Convert.ToInt32(datosCotizacion[0]) == 1)
                    {
                        checkBoxLicitacion.Checked = true;
                    }

                    SqlDataReader datosAnalisis;
                    SqlDataReader cotizacionAnalisis = bd.ejecutarConsulta("select descripcion, tipoAnalisis from CotizacionAnalisis where idCotizacion = " + idCotizacion + " and annoCotizacion = " + annoCotizacion);
                    var index = 0;
                    while (cotizacionAnalisis.Read())
                    {
                        comboTipoMuestra.SelectedItem = comboTipoMuestra.FindStringExact(cotizacionAnalisis[1].ToString());

                        datosAnalisis = bd.ejecutarConsulta("select metodo, precio from Analisis where descripcion = '" + cotizacionAnalisis[0] + "' and tipoAnalisis = '" + cotizacionAnalisis[1] + "'");
                        datosAnalisis.Read();
                        index = dgvAnalisis.Rows.Add();
                        dgvAnalisis.Rows[index].Cells[0].Value = cotizacionAnalisis[0];
                        dgvAnalisis.Rows[index].Cells[1].Value = datosAnalisis[0];
                        dgvAnalisis.Rows[index].Cells[2].Value = "$" + datosAnalisis[1];
                    }

                    textObservaciones.Text = datosCotizacion[1].ToString();
                    textPrecioMuestreo.Text = String.Format("{0:0.00}", datosCotizacion[2]);
                    textDescuento.Text = String.Format("{0:0.00}", datosCotizacion[3]);
                    textGastos.Text = String.Format("{0:0.00}", datosCotizacion[4]);
                    dateTimeFecha.Value = DateTime.Parse(datosCotizacion[5].ToString());
                    dateTimeFechaSolicitud.Value = DateTime.Parse(datosCotizacion[6].ToString());
                    dateTimeFechaRespuesta.Value = DateTime.Parse(datosCotizacion[7].ToString());

                    /*
                     *
                     * NI IDEA PORQUE MUERE
                     *          |
                     *          |
                     *          |
                     *          V
                     *  Por el evento de textChanged gil
                     */
                    hacerCambioSaldoAfavor = false;
                    numSaldoFavor.Value = Convert.ToDecimal(datosCotizacion[8]);
                    hacerCambioSaldoAfavor = true;

                    textTotal.Text = String.Format("{0:0.00}", datosCotizacion[9]);

                    SqlDataReader nombreQuimico = bd.ejecutarConsulta("select concat(nombre, ' ', apellido1, ' ', apellido2) from Usuarios where nombreUsuario = '" + datosCotizacion[17].ToString() + "'");
                    nombreQuimico.Read();
                    SqlDataReader nombreFirmante = bd.ejecutarConsulta("select concat(nombre, ' ', apellido1, ' ', apellido2) from Usuarios where nombreUsuario = '" + datosCotizacion[18].ToString() + "'");
                    nombreFirmante.Read();


                    comboCotizador.SelectedIndex = comboCotizador.FindString(datosCotizacion[11].ToString());
                    comboCliente.SelectedIndex = comboCliente.FindString(datosCotizacion[12].ToString());
                    textPrecioUnitario.Text = String.Format("{0:0.00}", datosCotizacion[13]);
                    numericDias.Value = Convert.ToDecimal(datosCotizacion[14]);
                    textSubtotal.Text = String.Format("{0:0.00}", datosCotizacion[15]);
                    numericMuestras.Value = Convert.ToDecimal(datosCotizacion[16].ToString());
                    comboQuimico.SelectedIndex = comboQuimico.FindString(nombreQuimico[0].ToString());
                    comboFirmantes.SelectedIndex = comboFirmantes.FindString(nombreFirmante[0].ToString());
                    

                    SqlDataReader datosGira = bd.ejecutarConsulta("select horasMuestreo,cantidadProfesionales,nochesAlojamiento,cantidadTecnicos,gastoTotal,provincia,canton,localidad from Gira WHERE idCotizacion = " + idCotizacion + "and annoCotizacion = " + annoCotizacion);
                    datosGira.Read();
                    if(datosGira.HasRows == true) { 
                        numHoras.Value = Convert.ToDecimal(datosGira[0]);
                        numProfesionales.Value = Convert.ToDecimal(datosGira[1]);
                        numNoches.Value = Convert.ToDecimal(datosGira[2]);
                        numTecnicos.Value = Convert.ToDecimal(datosGira[3]);
                        textTotalGira.Text = String.Format("{0:0.00}", datosGira[4]);
                        comboProvincia.Text = datosGira[5].ToString();
                        comboCanton.Text = datosGira[6].ToString();
                        comboLocalidad.Text = datosGira[7].ToString();
                        checkGira.Checked = true;

                        numDescuento.Value = Convert.ToDecimal(textDescuento.Text)/ (Convert.ToDecimal(textTotalGira.Text) + Convert.ToDecimal(textPrecioUnitario.Text)) * 100;
                        numGastosAdm.Value = Convert.ToDecimal(textGastos.Text) / (Convert.ToDecimal(textTotalGira.Text) + Convert.ToDecimal(textPrecioUnitario.Text)) * 100;
                    }
                    else
                    {
                        checkGira.Checked = false;
                        textTotalGira.Enabled = false;
                        numProfesionales.Enabled = false;
                        numHoras.Enabled = false;
                        numTecnicos.Enabled = false;
                        numNoches.Enabled = false;
                        comboProvincia.Enabled = false;
                        comboCanton.Enabled = false;
                        comboLocalidad.Enabled = false;
                        butCalcular.Enabled = false;

                        numDescuento.Value = Convert.ToDecimal(textDescuento.Text) / Convert.ToDecimal(textPrecioUnitario.Text);
                        numGastosAdm.Value = Convert.ToDecimal(textGastos.Text) / Convert.ToDecimal(textPrecioUnitario.Text);
                    }
                    /*
                     * 
                     * 
                     * FALTA LLENAR LOS CIENTES Y LAS GIRAS PERO YA ME ABURRIS
                     * 
                     * 
                     */

                    if (tipoAccion == 2)
                    {
                        foreach (Control control in this.Controls)
                        {
                            control.Enabled = false;
                        }
                        butAceptar.Visible = false;
                        butCancelar.Enabled = true;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al cargar la cotizacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void comboProvincia_TextChanged(object sender, EventArgs e)
        {
            comboCanton.Items.Clear();
            comboLocalidad.Items.Clear();
            SqlDataReader cantones = bd.ejecutarConsulta("select distinct canton from Localizaciones where provincia = '" + comboProvincia.Text + "'");
            while (cantones.Read())
            {
                comboCanton.Items.Add(cantones[0].ToString());
            }
			butCalcular.Enabled = false;
        }

        private void comboCanton_TextChanged(object sender, EventArgs e)
        {
            comboLocalidad.Items.Clear();
            SqlDataReader localidades = bd.ejecutarConsulta("select distinct localidad from Localizaciones where provincia = '" + comboProvincia.Text + "' and canton = '" + comboCanton.Text + "'");
            while (localidades.Read())
            {
                comboLocalidad.Items.Add(localidades[0].ToString());
            }
			butCalcular.Enabled = false;
		}

        private void comboCliente_TextChanged(object sender, EventArgs e)
        {
            comboAtencion.Items.Clear();
            SqlDataReader datos = bd.ejecutarConsulta("select C.telefono, C.telefono2, C.correo, C.fax, C.direccion from ClienteCotizacion C where nombre = '" + comboCliente.Text + "'");
            SqlDataReader atencion = bd.ejecutarConsulta("select atencionDe, ultimoAgregado from contactoCotizacion where nombreCliente = '" + comboCliente.Text + "'");
            while (atencion.Read())
            {
                comboAtencion.Items.Add(atencion[0].ToString());
                if (atencion[1].ToString() == "True")
                {
                    comboAtencion.SelectedIndex = comboAtencion.FindStringExact(atencion[0].ToString());
                }
            }
            datos.Read();
            textTelefono1.Text = datos[0].ToString();
            textTelefono1.Enabled = false;
            textTelefono2.Text = datos[1].ToString();
            textTelefono2.Enabled = false;
            textCorreo.Text = datos[2].ToString();
            textCorreo.Enabled = false;
            textFax.Text = datos[3].ToString();
            textFax.Enabled = false;
            textDireccion.Text = datos[4].ToString();
            textDireccion.Enabled = false;
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            AgregarClienteCotizacion a = new AgregarClienteCotizacion();
            a.ShowDialog();
            string cliente = a.textCliente.Text;
            a.Dispose();
            comboCliente.Items.Clear();
            SqlDataReader clientes = bd.ejecutarConsulta("select nombre from clienteCotizacion");
            while (clientes.Read())
            {
                comboCliente.Items.Add(clientes[0].ToString());
            }
			if (a.cancelar == false)
			{
				SqlDataReader datos = bd.ejecutarConsulta("select C.telefono, C.telefono2, C.correo, C.fax, C.direccion from ClienteCotizacion C where nombre = '" + cliente + "'");
				SqlDataReader atencion = bd.ejecutarConsulta("select atencionDe, ultimoAgregado from contactoCotizacion where nombreCliente = '" + cliente + "'");
				while (atencion.Read())
				{
					comboAtencion.Items.Add(atencion[0].ToString());
					if (atencion[1].ToString() == "True")
					{
						comboAtencion.SelectedIndex = comboAtencion.FindStringExact(atencion[0].ToString());
					}
				}
				datos.Read();
				comboCliente.SelectedIndex = comboCliente.FindStringExact(cliente);
				textTelefono1.Text = datos[0].ToString();
				textTelefono1.Enabled = false;
				textTelefono2.Text = datos[1].ToString();
				textTelefono2.Enabled = false;
				textCorreo.Text = datos[2].ToString();
				textCorreo.Enabled = false;
				textFax.Text = datos[3].ToString();
				textFax.Enabled = false;
				textDireccion.Text = datos[4].ToString();
				textDireccion.Enabled = false;
			}
        }

        

        private void butCalcular_Click(object sender, EventArgs e)
        {
            if (comboProvincia.Text == "" || comboCanton.Text == "" || comboLocalidad.Text == "")
            {
                MessageBox.Show("Por favor llene los campos necesarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlDataReader local = bd.ejecutarConsulta("select distancia, hospedaje from Localizaciones where provincia = '" + comboProvincia.Text + "' and canton = '" +
                comboCanton.Text + "' and localidad = '" + comboLocalidad.Text + "'");
                local.Read();
                float distancia = float.Parse(local[0].ToString());
                float hospedaje = float.Parse(local[1].ToString());

                SqlDataReader gira = bd.ejecutarConsulta("select valorKilometro, valorTecnico, valorProfesional from precioGiras");
                gira.Read();
                float precioK = float.Parse(gira[0].ToString());
                float precioTecnico = float.Parse(gira[1].ToString());
                float precioProfesional = float.Parse(gira[2].ToString());

                float horasViaje = (((distancia * 2) / 80) * float.Parse("1,25"));
                float profesional = (float.Parse(numHoras.Value.ToString()) + horasViaje) * precioProfesional * float.Parse(numProfesionales.Value.ToString());
                float tecnico = (float.Parse(numHoras.Value.ToString()) + horasViaje) * precioTecnico * float.Parse(numTecnicos.Value.ToString());

                //Se obtiene el valor de compra del dolar del banco central
                //CODIGOS:
                //Compra dolar = 317, Venta dolar = 318
                //Libra = 330
                //Euro = 333
                bool connection = NetworkInterface.GetIsNetworkAvailable();
                if (connection == true)
                {
                    banco.wsIndicadoresEconomicos cliente = new banco.wsIndicadoresEconomicos();
                    DataSet tipoCambio = cliente.ObtenerIndicadoresEconomicos("317", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("dd/MM/yyyy"), "Daniel Chavarría", "N");
                    dolar = float.Parse(tipoCambio.Tables[0].Rows[0].ItemArray[2].ToString());
                }
                textTotalGira.Text = ((distancia * 2 * precioK) + profesional + tecnico + ((hospedaje * float.Parse(numNoches.Value.ToString())) / dolar)).ToString();

                textPrecioMuestreo.Text = textTotalGira.Text;
                calcularPrecio();
            }
        }

        private void comboLocalidad_TextChanged(object sender, EventArgs e)
        {
			butCalcular.Enabled = true;
        }
        private void comboTipoMuestra_TextChanged(object sender, EventArgs e)
        {
            textMuestra.Enabled = true;
            numericMuestras.Enabled = true;
            numericDias.Enabled = true;
            numericCantidad.Enabled = true;
            comboUnidad.Enabled = true;
            butAnalisis.Enabled = true;
            butMetales.Enabled = true;
            butTexto.Enabled = true;
            butBorrar.Enabled = true;

            tipoMuestra = comboTipoMuestra.Text;

            do
            {
                foreach (DataGridViewRow row in dgvAnalisis.Rows)
                {
                    dgvAnalisis.Rows.Remove(row);
                }
            } while (dgvAnalisis.Rows.Count > 0);

            textPrecioUnitario.Text = "0";
            calcularPrecio();
        }

        private void butAnalisis_Click(object sender, EventArgs e)
        {
            SeleccionarAnalisisCotizacion sac = new SeleccionarAnalisisCotizacion(comboTipoMuestra.Text);
            sac.ShowDialog();
            DataGridViewRow row = sac.getRow();
            if (row != null)
            {
                dgvAnalisis.Rows.Add(row);
                textPrecioUnitario.Text = Convert.ToString(float.Parse(textPrecioUnitario.Text) + float.Parse(row.Cells[2].Value.ToString().Remove(0, 1)));
                calcularPrecio();
            }
            sac.Dispose();
        }

        private void butMetales_Click(object sender, EventArgs e)
        {
            SeleccionarAnalisisCotizacion sac = new SeleccionarAnalisisCotizacion(null);
            sac.ShowDialog();
            DataGridViewRow row = sac.getRow();
            if (row != null)
            {
                dgvAnalisis.Rows.Add(sac.getRow());
                textPrecioUnitario.Text = Convert.ToString(float.Parse(textPrecioUnitario.Text) + float.Parse(row.Cells[2].Value.ToString().Remove(0, 1)));
                calcularPrecio();
            }
            sac.Dispose();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butBorrar_Click(object sender, EventArgs e)
        {
            if(dgvAnalisis.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAnalisis.SelectedRows[0];
                // Se cae si el valor es 0 NPI por qué
                textPrecioUnitario.Text = Convert.ToString(float.Parse(textPrecioUnitario.Text) - float.Parse(row.Cells[2].Value.ToString().Remove(0, 1)));
                calcularPrecio();
                dgvAnalisis.Rows.Remove(row);
            }
        }

        private void calcularPrecio()
        {
            float total = float.Parse(textPrecioUnitario.Text) + float.Parse(textPrecioMuestreo.Text);
            textSubtotal.Text = Convert.ToString(total);

            textDescuento.Text = Convert.ToString(((float)numDescuento.Value / 100) * total);
            textGastos.Text = Convert.ToString(((float)numGastosAdm.Value / 100) * total);

            total -= float.Parse(textDescuento.Text);
            total += float.Parse(textGastos.Text);
            total -= (float)numSaldoFavor.Value;
            textTotal.Text = Convert.ToString(total);
        }

        private void numDescuento_ValueChanged(object sender, EventArgs e)
        {
            calcularPrecio();
        }

        private void numGastosAdm_ValueChanged(object sender, EventArgs e)
        {
            calcularPrecio();
        }

        private void numSaldoFavor_ValueChanged(object sender, EventArgs e)
        {
            if(hacerCambioSaldoAfavor == true)
                calcularPrecio();
        }

        private void checkGira_CheckedChanged(object sender, EventArgs e)
        {
            if(checkGira.Checked == true)
            {
                textTotalGira.Enabled = true;
                numProfesionales.Enabled = true;
                numHoras.Enabled = true;
                numTecnicos.Enabled = true;
                numNoches.Enabled = true;
                comboProvincia.Enabled = true;
                comboCanton.Enabled = true;
                comboLocalidad.Enabled = true;
                butCalcular.Enabled = true;
            }
            else
            {
                textTotalGira.Enabled = false;
                numProfesionales.Enabled = false;
                numHoras.Enabled = false;
                numTecnicos.Enabled = false;
                numNoches.Enabled = false;
                comboProvincia.Enabled = false;
                comboCanton.Enabled = false;
                comboLocalidad.Enabled = false;
                butCalcular.Enabled = false;

                textTotalGira.Text = "";
                numProfesionales.Value = 0;
                numHoras.Value = 0;
                numTecnicos.Value = 0;
                numNoches.Value = 0;
                comboProvincia.SelectedIndex = -1;
                comboCanton.SelectedIndex = -1;
                comboLocalidad.SelectedIndex = -1;

                textPrecioMuestreo.Text = "0";
                calcularPrecio();
            }
            
        }

        private void generarObservaciones()
        {
            if(textMuestra.Text != "" && numericMuestras.Value > 0 && numericCantidad.Value > 0 && comboUnidad.Text != "")
            {
                string observaciones = "";
                if(numericMuestras.Value == 1)
                {
                    observaciones += "Esta cotización corresponde a una muestra de " + textMuestra.Text + "." + Environment.NewLine;
                }
                else
                {
                    observaciones += "Esta cotización corresponde a " + numericMuestras.Value.ToString() + " muestras de " + textMuestra.Text + "." + Environment.NewLine;
                }
                
                observaciones += "Para los ensayos se requiere al menos " + numericCantidad.Value.ToString() + comboUnidad.Text + " de muestra." + Environment.NewLine;
                observaciones += "La fecha de entrega de resultados puede variar en función de la fecha de recepción de las muestras y del volumen " +
                    "de trabajo que en ese momento se tenga." + Environment.NewLine;

                textObservaciones.Text = observaciones;

            }
        }

        private void textMuestra_KeyUp(object sender, KeyEventArgs e)
        {
            generarObservaciones();
        }

        private void numericMuestras_ValueChanged(object sender, EventArgs e)
        {
            generarObservaciones();
        }

        private void numericDias_ValueChanged(object sender, EventArgs e)
        {
            generarObservaciones();
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            generarObservaciones();
        }

        private void comboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            generarObservaciones();
        }
        //Muestreo y precio muestra van al revez
        private void butAceptar_Click(object sender, EventArgs e)
        {
            int error;
            if (textObservaciones.Text == "" || comboCotizador.Text == "" || comboCliente.Text == "" || comboQuimico.Text == "" ||
                comboFirmantes.Text == "" || dgvAnalisis.Rows.Count == 0 || comboTipoMuestra.Text == "" || textMuestra.Text == "" ||
                numericMuestras.Value == 0 || numericDias.Value == 0 || numericCantidad.Value == 0 || comboUnidad.Text == "")
            {
                MessageBox.Show("Por favor llene los campos requeridos", "Cotización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else  
            {
                if (tipoAccion == 0)    
                {
                    int anno = DateTime.Now.Year;
                    int id = bd.agregarCotizacion(anno, checkBoxLicitacion.Checked ? 1 : 0, textObservaciones.Text, float.Parse(textPrecioMuestreo.Text),
                        float.Parse(textDescuento.Text.ToString()), float.Parse(textGastos.Text), dateTimeFecha.Value.ToShortDateString(), dateTimeFechaSolicitud.Value.ToShortDateString(),
                        dateTimeFechaRespuesta.Value.ToShortDateString(), float.Parse(numSaldoFavor.Value.ToString()), float.Parse(textTotal.Text.ToString()), 'D', (comboCotizador.SelectedItem as dynamic).Value,
                        comboCliente.Text, float.Parse(textPrecioUnitario.Text), (dateTimeFechaRespuesta.Value - dateTimeFecha.Value).Days, float.Parse(textSubtotal.Text), Convert.ToInt32(numericMuestras.Value),
                        (comboQuimico.SelectedItem as dynamic).Value, (comboFirmantes.SelectedItem as dynamic).Value);

                    if (id != -1)
                    {
                        foreach (DataGridViewRow analisis in dgvAnalisis.Rows)
                        {
                            bd.ejecutarConsulta("insert into CotizacionAnalisis values(" + id + ", " + anno + ", '" +
                                analisis.Cells[0].Value.ToString() + "', '" + comboTipoMuestra.SelectedItem.ToString() + "')");
                        }
                        if(checkGira.Checked == true)
                        {
                            int errorGira = bd.agregarGira(Convert.ToInt32(numHoras.Value), Convert.ToInt32(numProfesionales.Value), Convert.ToInt32(numNoches.Value), Convert.ToInt32(numTecnicos.Value), float.Parse(textTotalGira.Text), comboProvincia.Text,
                                comboCanton.Text,comboLocalidad.Text,id,anno);
                            if(errorGira == -1)
                            {
                                MessageBox.Show("a ocurrido un error realizando la solicitd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        ReporteCotizacion reporte = new ReporteCotizacion(id, anno, "P-03:F-01", "CELEQ-VE-" + id.ToString("D4") + "-" + anno, "Cotización", Convert.ToInt32(numGastosAdm.Value), Convert.ToInt32(numDescuento.Value));
                        reporte.ShowDialog();
                        reporte.saveToPdf();
                        reporte.Dispose();
                    }
                    else
                    { 
                        MessageBox.Show("a ocurrido un error realizando la solicitd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(tipoAccion == 1)
                {
                    error = bd.modificarCotizacion(idCotizacion, annoCotizacion, checkBoxLicitacion.Checked ? 1 : 0, textObservaciones.Text, float.Parse(textPrecioMuestreo.Text),
                        float.Parse(textDescuento.Text), float.Parse(textGastos.Text), dateTimeFecha.Value.ToShortDateString(), dateTimeFechaSolicitud.Value.ToShortDateString(),
                        dateTimeFechaRespuesta.Value.ToShortDateString(), float.Parse(numSaldoFavor.Value.ToString()), float.Parse(textTotal.Text), 'D', (comboCotizador.SelectedItem as dynamic).Value,
                        comboCliente.Text, float.Parse(textPrecioUnitario.Text), (dateTimeFechaRespuesta.Value - dateTimeFecha.Value).Days, float.Parse(textSubtotal.Text), Convert.ToInt32(numericMuestras.Value),
                        (comboQuimico.SelectedItem as dynamic).Value, (comboFirmantes.SelectedItem as dynamic).Value);
                    int errorGira = bd.modificarGira(Convert.ToInt32(numHoras.Value), Convert.ToInt32(numProfesionales.Value), Convert.ToInt32(numNoches.Value), Convert.ToInt32(numTecnicos.Value), float.Parse(textTotalGira.Text), comboProvincia.Text,
                                comboCanton.Text, comboLocalidad.Text, Convert.ToInt32(idCotizacion), Convert.ToInt32(annoCotizacion));
                    if (error == 0 && errorGira != -1)  
                    {
                        MessageBox.Show("Cotización modificada de manera correcta", "Unidades", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar cotización\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Close();
            }
        }

        private void numSaldoFavor_ValueChanged(object sender, KeyEventArgs e)
        {

        }
    }
}
