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
    public partial class AgregarAnalisisCotizacion : Form
    {
        AccesoBaseDatos bd;
        string tipoAnalisis;
        string descripcion;
        public AgregarAnalisisCotizacion(string tipo, string descripcionAnalisis = null)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            tipoAnalisis = tipo;
            descripcion = descripcionAnalisis;
            comboAcreditacion.Items.Add("Método de Ensayo acreditado ante el ECA (INTE-ISO/IEC 17025:2005)");
            comboAcreditacion.Items.Add("Método de Inspección acreditado ante el ECA (INTE-ISO/IEC 17020:2012)");
            comboAcreditacion.Items.Add("Método no acreditado");


        }

        private void AgregarAnalisisCotizacion_Load(object sender, EventArgs e)
        {
            textTipoMuestra.Text = tipoAnalisis;
            textTipoMuestra.Enabled = false;

            if (descripcion != null)
            {
                try
                {
                    SqlDataReader analisis = bd.ejecutarConsulta("select metodo, precio, acreditacion from Analisis where descripcion = '" + descripcion + "' and tipoAnalisis = '" + tipoAnalisis + "'");
                    textDescripcion.Text = descripcion;
                    analisis.Read();
                    textMetodo.Text = analisis[0].ToString();
                    numericPrecio.Value = Convert.ToDecimal(analisis[1]);
                    comboAcreditacion.SelectedIndex = Convert.ToInt32(analisis[2]) - 1;
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error al cargar el análisis", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(textTipoMuestra.Text == "" || textDescripcion.Text == "" || comboAcreditacion.Text == "")
            {
                MessageBox.Show("Por favor llenar los campos requeridos", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (descripcion == null)
                {
                    if (bd.agregarAnalisisCotizacion(textDescripcion.Text, textMetodo.Text, Convert.ToInt32(numericPrecio.Value), comboAcreditacion.SelectedIndex + 1, tipoAnalisis) == 0)
                    {
                        MessageBox.Show("Se ha agregado el análisis de manera correcta", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error agregando el análisis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (bd.modificarAnalisisCotizacion(textDescripcion.Text, descripcion, textMetodo.Text, Convert.ToInt32(numericPrecio.Value), comboAcreditacion.SelectedIndex + 1, tipoAnalisis) == 0)
                    {
                        MessageBox.Show("Se ha agregado el análisis de manera correcta", "Cotizacion", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error agregando el análisis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
