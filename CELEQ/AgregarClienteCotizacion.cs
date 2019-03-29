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
    public partial class AgregarClienteCotizacion : Form
    {
        AccesoBaseDatos bd;
        string nombreCliente;
		public bool cancelar;
        public AgregarClienteCotizacion(string cliente = null)
        {
            InitializeComponent();
            nombreCliente = cliente;
            bd = new AccesoBaseDatos();
			cancelar = false;

		}

        private void butAgregarEncargado_Click(object sender, EventArgs e)
        {
            AgregarContactoCotizacion acc = new AgregarContactoCotizacion(nombreCliente);
            acc.ShowDialog();
            acc.Dispose();


            comboAtencion.Items.Clear();
            SqlDataReader contactos = bd.ejecutarConsulta("select atencionDe, ultimoAgregado from ContactoCotizacion where nombreCliente = '" + nombreCliente + "'");
            while (contactos.Read())
            {
                comboAtencion.Items.Add(contactos[0]);
                if (contactos[1].ToString() == "True")
                {
                    comboAtencion.SelectedIndex = comboAtencion.FindStringExact(contactos[0].ToString());
                }
            }
        }

        private void AgregarClienteCotizacion_Load(object sender, EventArgs e)
        {
            if(nombreCliente == null)
            {
                comboAtencion.Visible = false;
                butAgregarEncargado.Visible = false;
            }
            else
            {
                try
                {
                    textAtencion.Visible = false;
                    textCliente.Text = nombreCliente;
                    SqlDataReader datos = bd.ejecutarConsulta("select telefono, telefono2, correo, fax, direccion from ClienteCotizacion where nombre = '" + nombreCliente + "'");
                    datos.Read();
                    textTelefono1.Text = datos[0].ToString();
                    textTelefono2.Text = datos[1].ToString();
                    textCorreo.Text = datos[2].ToString();
                    textFax.Text = datos[3].ToString();
                    textDireccion.Text = datos[4].ToString();

                    SqlDataReader contactos = bd.ejecutarConsulta("select atencionDe, ultimoAgregado from ContactoCotizacion where nombreCliente = '" + nombreCliente + "'");
                    while (contactos.Read())
                    {
                        comboAtencion.Items.Add(contactos[0].ToString());
                        if (contactos[1].ToString() == "True")
                        {
                            comboAtencion.SelectedIndex = comboAtencion.FindStringExact(contactos[0].ToString());
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error al cargar el cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(nombreCliente == null)
            {
                if (textCliente.Text == "" || textAtencion.Text == "" || textDireccion.Text == "" || (textTelefono1.Text == "" && textTelefono2.Text == "") || textCorreo.Text == "")
                {
                    MessageBox.Show("Por favor llenar los campos requeridos", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (bd.agregarClienteCotizacion(textCliente.Text, textTelefono1.Text, textTelefono2.Text, textCorreo.Text, textFax.Text, textDireccion.Text, textAtencion.Text) == 0)
                    {
                        MessageBox.Show("Se ha agregado el cliente de manera correcta", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error agregando el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (textCliente.Text == "" || textDireccion.Text == "" || (textTelefono1.Text == "" && textTelefono2.Text == "") || textCorreo.Text == "")
                {
                    MessageBox.Show("Por favor llenar los campos requeridos", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (bd.modificarClienteCotizacion(nombreCliente, textCliente.Text, textTelefono1.Text, textTelefono2.Text, textCorreo.Text, textFax.Text, textDireccion.Text, comboAtencion.Text) == 0)
                    {
                        MessageBox.Show("Se ha modificado el cliente de manera correcta", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error agregando el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
			cancelar = true;
        }
    }
}
