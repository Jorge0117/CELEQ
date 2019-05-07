using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELEQ
{
    public partial class AgregarContactoCotizacion : Form
    {
        AccesoBaseDatos bd;
        string cliente;
        public AgregarContactoCotizacion(string nombreCliente)
        {
            InitializeComponent();
            cliente = nombreCliente;
            bd = new AccesoBaseDatos();
        }

        private void AgregarContactoCotizacion_Load(object sender, EventArgs e)
        {
            textCliente.Text = cliente;
            textCliente.Enabled = false;
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(textContacto.Text == "")
            {
                MessageBox.Show("Por favor llenar los campos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if(bd.agregarContactoCotizacion(cliente, textContacto.Text) == 0)
                {
                    MessageBox.Show("Se agregó el contacto de manera correcta", "Designaciones", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregr contacto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
