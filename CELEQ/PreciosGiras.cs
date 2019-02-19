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
    public partial class PreciosGiras : Form
    {
        AccesoBaseDatos bd;
        public PreciosGiras()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
        }

        private void PreciosGiras_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader montos = bd.ejecutarConsulta("select valorKilometro, valorTecnico, valorProfesional from preciogiras");
                montos.Read();
                numericKilometro.Value = decimal.Parse(montos[0].ToString());
                numericProf.Value = decimal.Parse(montos[2].ToString());
                numericTec.Value = decimal.Parse(montos[1].ToString());
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error cargando los precios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bd.ejecutarConsulta("update precioGiras set valorKilometro = " + numericKilometro.Value + ", valorTecnico = " + numericTec.Value + ", valorProfesional = " + numericProf.Value);
                MessageBox.Show("Se ha cambiado los precios", "Giras", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error modificando los precios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
