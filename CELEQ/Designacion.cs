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
    public partial class Designacion : Form
    {
        AccesoBaseDatos bd;
        public Designacion()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
        }

        private void Designacion_Load(object sender, EventArgs e)
        {
            comboTipoId.Items.Add("Cédula nacional");
            comboTipoId.Items.Add("Cédula residencia");
            comboTipoId.Items.Add("Pasaporte");
            comboTipoId.Items.Add("Permiso residencia");
            comboTipoId.SelectedIndex = 0;

            SqlDataReader encargados = bd.ejecutarConsulta("select concat(nombre, ' ', apellido1, ' ', apellido2) from Usuarios where categoria != 'Estudiante'");
            while (encargados.Read())
            {
                comboResponsable.Items.Add(encargados[0].ToString());
            }

            SqlDataReader unidades = bd.ejecutarConsulta("select nombre from unidad");
            while (unidades.Read())
            {
                comboUnidad.Items.Add(unidades[0].ToString());
            }

            comboCiclo.Items.Add("I");
            comboCiclo.Items.Add("I I.C");
            comboCiclo.Items.Add("II");
            comboCiclo.Items.Add("II I.C");
            comboCiclo.Items.Add("III");

            comboModalidad.Items.Add("H.E");
            comboModalidad.Items.Add("H.A");
            comboModalidad.Items.Add("H.A.P");

            SqlDataReader presupuestos = bd.ejecutarConsulta("select codigo from presupuesto");
            while (presupuestos.Read())
            {
                comboPresupuesto.Items.Add(presupuestos[0].ToString());
            }

            labelMotivo.Visible = false;
            textInopia.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelMotivo.Visible = !labelMotivo.Visible;
            textInopia.Visible = !textInopia.Visible;
            textInopia.Text = "";
        }

        private void comboP9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!comboP9.Items.Contains(comboP9.Text) && comboP9.Text!= "")
                {
                    comboP9.Items.Add(comboP9.Text);
                }      
            }
        }
    }
}
