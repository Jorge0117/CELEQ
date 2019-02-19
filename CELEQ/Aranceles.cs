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
    public partial class Aranceles : Form
    {
        AccesoBaseDatos bd;
        public Aranceles()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
        }

        private void Aranceles_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader montos = bd.ejecutarConsulta("select monto from montoHoras");
                montos.Read();
                numericEst.Value = Int32.Parse(montos[0].ToString());
                montos.Read();
                numericAsi.Value = Int32.Parse(montos[0].ToString());
                montos.Read();
                numericPos.Value = Int32.Parse(montos[0].ToString());
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error cargando los aranceles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bd.ejecutarConsulta("Update montoHoras set monto = " + numericEst.Value + " where tipo = 'HE'");
                bd.ejecutarConsulta("Update montoHoras set monto = " + numericAsi.Value + " where tipo = 'HA'");
                bd.ejecutarConsulta("Update montoHoras set monto = " + numericPos.Value + " where tipo = 'HP'");

                MessageBox.Show("Se ha cambiado los montos de las horas", "Aranceles", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error modificando los aranceles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
