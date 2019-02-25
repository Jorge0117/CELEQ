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
        public AgregarClienteCotizacion(string cliente = null)
        {
            InitializeComponent();
            nombreCliente = cliente;
            bd = new AccesoBaseDatos();
        }

        private void butAgregarEncargado_Click(object sender, EventArgs e)
        {
            AgregarContactoCotizacion acc = new AgregarContactoCotizacion();
            acc.ShowDialog();
            acc.Dispose();
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
                textAtencion.Visible = false;
                textCliente.Text = nombreCliente;
                SqlDataReader datos = bd.ejecutarConsulta("select telefono, telefono2, correo, fax, direccion from ClienteCotizacion where nombre = '" + nombreCliente + "'");
                datos.Read();
                textTelefono1.Text = datos[0].ToString();
                textTelefono2.Text = datos[1].ToString();
                textCorreo.Text = datos[2].ToString();
                textFax.Text = datos[3].ToString();
                textDireccion.Text = datos[4].ToString();


                
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
        }
    }
}
