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
    public partial class AgregarPuesto : Form
    {
        string puesto;
        AccesoBaseDatos bd;
        public AgregarPuesto(string puesto = "")
        {
            InitializeComponent();
            this.puesto = puesto;
            bd = new AccesoBaseDatos();
            textPuesto.Text = puesto;
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (puesto == "")
                {
                    bd.ejecutarConsulta("insert into puestos values('" + textPuesto.Text + "')");
                    MessageBox.Show("Se ha agregado el puesto de manera correcta", "Puesto", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    bd.ejecutarConsulta("update puestos set puesto = '" + textPuesto.Text + "' where puesto = '" + puesto + "'");
                    MessageBox.Show("Se ha modificado el puesto de manera correcta", "Puesto", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
