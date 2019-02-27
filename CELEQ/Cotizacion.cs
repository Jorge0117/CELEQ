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

namespace CELEQ
{
    public partial class Cotizacion : Form
    {
        AccesoBaseDatos bd;
        public Cotizacion()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
        }

        private void Cotizacion_Load(object sender, EventArgs e)
        {
            SqlDataReader provincias = bd.ejecutarConsulta("select distinct provincia from Localizaciones");
            while(provincias.Read())
            {
                comboProvincia.Items.Add(provincias[0].ToString());
            }
            SqlDataReader clientes = bd.ejecutarConsulta("select nombre from clienteCotizacion");
            while(clientes.Read())
            {
                comboCliente.Items.Add(clientes[0].ToString());
            }
            textTotalGira.Enabled = false;
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
        }

        private void comboCanton_TextChanged(object sender, EventArgs e)
        {
            comboLocalidad.Items.Clear();
            SqlDataReader localidades = bd.ejecutarConsulta("select distinct localidad from Localizaciones where provincia = '" + comboProvincia.Text + "' and canton = '" + comboCanton.Text + "'");
            while (localidades.Read())
            {
                comboLocalidad.Items.Add(localidades[0].ToString());
            }
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

        private void butCalcular_Click(object sender, EventArgs e)
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
            //Falta el IMEC de feriados prrro :'v
            banco.wsIndicadoresEconomicos cliente = new banco.wsIndicadoresEconomicos();
            DataSet tipoCambio = cliente.ObtenerIndicadoresEconomicos("317", DateTime.Now.ToString("dd/MM/yyyy"),DateTime.Now.ToString("dd/MM/yyyy"), "Daniel Chavarría","N");
            float dolar = float.Parse(tipoCambio.Tables[0].Rows[0].ItemArray[2].ToString());

            textTotalGira.Text = ((distancia * 2 * precioK) + profesional + tecnico + ((hospedaje * float.Parse(numNoches.Value.ToString())) / dolar)).ToString();
        }

    }
}
